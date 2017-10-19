using Newtonsoft.Json;

namespace AntiCaptcha.GetQueueStats
{

    public class GetQueueStatsResponse
    {
        [JsonProperty("waiting")]
        public int Waiting { get; private set; }

        [JsonProperty("load")]
        public double Load { get; private set; }

        [JsonProperty("bid")]
        public string Bid { get; private set; }

        [JsonProperty("speed")]
        public double Speed { get; private set; }

        [JsonProperty("total")]
        public int Total { get; private set; }

        public string ToStringLoad => $"{Waiting} / {Total} / {Load}%";
    }


}

