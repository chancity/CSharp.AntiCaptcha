using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
