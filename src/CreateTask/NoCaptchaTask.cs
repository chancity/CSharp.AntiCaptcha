namespace AntiCaptcha.CreateTask
{

    public class NoCaptchaTask : ProxifiedCreateTask
    {
        public NoCaptchaTask(string websiteUrl, string websiteKey, string proxyType, string proxyAddress, int proxyPort, string proxyLogin = null, string proxyPassword = null, string userAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36") : base("NoCaptchaTask", websiteUrl, websiteKey, proxyType, proxyAddress, proxyPort, proxyLogin, proxyPassword, userAgent)
        {
        }
    }
}
