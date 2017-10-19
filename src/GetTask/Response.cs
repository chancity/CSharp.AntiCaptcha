using System.Threading;
using Newtonsoft.Json;

namespace AntiCaptcha.GetTask
{
    public class GetTaskResponse
    {
        [JsonProperty("errorId")]
        public int ErrorId { get; private set; }
        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
        [JsonProperty("errorDescription")]
        public string ErrorDescription { get; private set; }
        [JsonProperty("status")]
        public string Status { get;  set; }
        [JsonProperty("solution")]
        public Solution Solution { get; private set; }
        [JsonProperty("cost")]
        public string Cost { get; private set; }
        [JsonProperty("ip")]
        public string Ip { get; private set; }
        [JsonProperty("createTime")]
        public int CreateTime { get; private set; }
        [JsonProperty("endTime")]
        public int EndTime { get; private set; }
        [JsonProperty("solveCount")]
        public string SolveCount { get; private set; }

        [JsonIgnore]
        public int SolveTime => EndTime - CreateTime;

        private int _usedCount;

        [JsonIgnore]
        public int UsedCount => _usedCount;

        public void IncreaseUsedCount()
        {
            Interlocked.Increment(ref _usedCount);
        }
    }
}

