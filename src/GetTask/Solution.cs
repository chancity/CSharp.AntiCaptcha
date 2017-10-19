using Newtonsoft.Json;

namespace AntiCaptcha.GetTask
{

    public class Solution
    {
        [JsonProperty("gRecaptchaResponse")]
        public string GRecaptchaResponse { get; private set; }

        [JsonProperty("gRecaptchaResponseMD5")]
        public string GRecaptchaResponseMd5 { get; private set; }

        [JsonProperty("url")]
        public string Url { get; private set; }

        [JsonProperty("text")]
        public string Text { get; private set; }

        [JsonProperty("token")]
        public string Token { get; private set; }
    }
}

