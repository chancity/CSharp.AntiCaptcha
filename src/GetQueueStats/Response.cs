using System.Threading;
using Newtonsoft.Json;

namespace AntiCaptcha.GetQueueStats
{
    public class GetQueueStatsResponse
    {
        private int _waiting;

        [JsonProperty("waiting")]
        public int Waiting
        {
            get => _waiting;
            private set => _waiting = value;
        }

        [JsonProperty("load")]
        public double Load { get; private set; }

        [JsonProperty("bid")]
        public double Bid { get; private set; }

        [JsonProperty("speed")]
        public double Speed { get; private set; }

        [JsonProperty("total")]
        public int Total { get; private set; }

        public string ToStringLoad => $"{Waiting} / {Total} / {Load}%";


        public void DecrementWaiting()
        {
            Interlocked.Decrement(ref _waiting);
        }
    }
}