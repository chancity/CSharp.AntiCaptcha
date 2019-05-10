namespace AntiCaptcha.CreateTask
{
    public class FunCaptchaTask : ProxifiedCreateTask
    {
        public FunCaptchaTask(string websiteUrl, string websiteKey, string proxyType, string proxyAddress,
            int proxyPort, string proxyLogin = null, string proxyPassword = null,
            string userAgent =
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36")
            : base("FunCaptchaTask", websiteUrl, websiteKey, proxyType, proxyAddress, proxyPort, proxyLogin,
                proxyPassword, userAgent) { }
    }
}