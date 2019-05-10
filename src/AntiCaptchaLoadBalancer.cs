using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AntiCaptcha.CreateTask;
using AntiCaptcha.GetTask;

namespace AntiCaptcha
{
    public class AntiCaptchaLoadBalancer
    {
        private static readonly HashSet<AntiCaptchaKey> CaptchaKeys;
        private static readonly Random GetRandom;
        private static readonly ConcurrentQueue<GetTaskResponse> Queue;

        public static int SolvedCaptchaCount
        {
            get
            {
                lock (CaptchaKeys)
                {
                    return CaptchaKeys.Sum(k => k.TotalCount - k.QueuedCount);
                }
            }
        }

        static AntiCaptchaLoadBalancer()
        {
            CaptchaKeys = new HashSet<AntiCaptchaKey>();
            Queue = new ConcurrentQueue<GetTaskResponse>();
            GetRandom = new Random();
        }

        public static bool AddKey(AntiCaptchaKey antiCaptchaKey)
        {
            lock (CaptchaKeys)
            {
                return CaptchaKeys.Add(antiCaptchaKey);
            }
        }

        public static bool RemoveKey(AntiCaptchaKey antiCaptchaKey)
        {
            lock (CaptchaKeys)
            {
                return CaptchaKeys.Remove(antiCaptchaKey);
            }
        }

        public static AntiCaptchaKey GetValidAntiCaptchaKey()
        {
            List<AntiCaptchaKey> availableAntiCaptchaKey;

            lock (CaptchaKeys)
            {
                availableAntiCaptchaKey = CaptchaKeys.Where(key => key.IsReady).ToList();
            }

            if (availableAntiCaptchaKey.Count == 0)
            {
                throw new AntiCaptchaException("No valid Anti-Captca keys configured.");
            }

            AntiCaptchaKey ret = availableAntiCaptchaKey[GetRandomNumber(0, availableAntiCaptchaKey.Count)];

            if (ret == null)
            {
                throw new AntiCaptchaException("No valid Anti-Captca keys configured.");
            }


            return ret;
        }

        public static void EnqueueResponse(GetTaskResponse response)
        {
            if (!Queue.Contains(response))
            {
                Queue.Enqueue(response);
            }
        }

        public static async Task<GetTaskResponse> GetSolvedCaptcha(ICreateTask task)
        {
            GetTaskResponse ret;

            if (!Queue.TryDequeue(out ret))
            {
                AntiCaptchaKey key = GetValidAntiCaptchaKey();
                ret = await key.GetSolvedCaptcha(task);
            }

            if (ret.UsedCount > AntiCaptchaGlobals.CaptchaRetryLimit)
            {
                AntiCaptchaKey key = GetValidAntiCaptchaKey();
                ret = await key.GetSolvedCaptcha(task);
            }

            ret.IncreaseUsedCount();
            return ret;
        }


        private static int GetRandomNumber(int min, int max)
        {
            lock (GetRandom)
            {
                return GetRandom.Next(min, max);
            }
        }
    }
}