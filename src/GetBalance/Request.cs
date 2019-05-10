using Newtonsoft.Json;

namespace AntiCaptcha.GetBalance
{
    public class GetBalanceRequest
    {
        [JsonProperty("clientKey")]
        public string ClientKey { get; set; }

        public GetBalanceRequest(string clientKey)
        {
            ClientKey = clientKey;
        }
    }
}