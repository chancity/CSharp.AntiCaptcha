using Newtonsoft.Json;

namespace AntiCaptcha.GetBalance
{
    public class GetBalanceResponse
    {
        [JsonProperty("errorId")]
        public int ErrorId { get; private set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; private set; }

        [JsonProperty("errorDescription")]
        public string ErrorDescription { get; private set; }

        [JsonProperty("balance")]
        public float Balance { get; private set; }
    }
}