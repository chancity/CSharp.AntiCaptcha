using Newtonsoft.Json;

namespace AntiCaptcha.CreateTask
{
    public class NoCaptchaTaskProxyless : ICreateTask
    {
        [JsonProperty("websiteURL")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("websiteKey")]
        public string WebsiteKey { get; set; }

        public NoCaptchaTaskProxyless(string websiteUrl, string websiteKey)
        {
            WebsiteUrl = websiteUrl;
            WebsiteKey = websiteKey;
        }

        [JsonProperty("type")]
        public string Type { get; set; } = "NoCaptchaTaskProxyless";
    }
}