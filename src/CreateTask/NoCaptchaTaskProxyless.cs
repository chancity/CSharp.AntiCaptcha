using Newtonsoft.Json;

namespace AntiCaptcha.CreateTask
{
    public class NoCaptchaTaskProxyless : ICreateTask
    {
        public NoCaptchaTaskProxyless(string websiteUrl, string websiteKey)
        {
            WebsiteUrl = websiteUrl;
            WebsiteKey = websiteKey;
        }

        [JsonProperty("type")]
        public string Type { get; set; } = "NoCaptchaTaskProxyless";

        [JsonProperty("websiteURL")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("websiteKey")]
        public string WebsiteKey { get; set; }

    }
}

