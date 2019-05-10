using Newtonsoft.Json;

namespace AntiCaptcha.CreateTask
{
    public abstract class ProxifiedCreateTask : ICreateTask
    {
        [JsonProperty("websiteURL")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("websitePublicKey")]
        public string WebsiteKey { get; set; }

        [JsonProperty("proxyType")]
        public string ProxyType { get; set; }

        [JsonProperty("proxyAddress")]
        public string ProxyAddress { get; set; }

        [JsonProperty("proxyPort")]
        public int ProxyPort { get; set; }

        [JsonProperty("proxyLogin")]
        public string ProxyLogin { get; set; }

        [JsonProperty("proxyPassword")]
        public string ProxyPassword { get; set; }

        [JsonProperty("userAgent")]
        public string UserAgent { get; set; }

        public ProxifiedCreateTask(string type, string websiteUrl, string websiteKey,
            string proxyType,
            string proxyAddress,
            int proxyPort,
            string proxyLogin = null,
            string proxyPassword = null,
            string userAgent =
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36")
        {
            Type = type;
            WebsiteUrl = websiteUrl;
            WebsiteKey = websiteKey;
            ProxyType = proxyType;
            ProxyAddress = proxyAddress;
            ProxyPort = proxyPort;
            ProxyLogin = proxyLogin;
            ProxyPassword = proxyPassword;
            UserAgent = userAgent;
        }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}