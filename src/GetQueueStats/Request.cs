using Newtonsoft.Json;

namespace AntiCaptcha.GetQueueStats
{
    public class GetQueueStatsRequest
    {
        [JsonProperty("queueId")]
        public QueueIdEnum QueueId { get; set; }

        public GetQueueStatsRequest(QueueIdEnum queueId)
        {
            QueueId = queueId;
        }
    }
}