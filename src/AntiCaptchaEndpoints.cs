namespace AntiCaptcha
{
    internal class AntiCaptchaEndpoints
    {
        private const string BaseUrl = "https://api.anti-captcha.com";
        public const string ReportIncorrectImageCaptchaUrl = BaseUrl + "/reportIncorrectImageCaptcha";
        public const string GetTaskUrl = BaseUrl + "/getTaskResult";
        public const string GetQueueStatsUrl = BaseUrl + "/getQueueStats";
        public const string GetBalanceUrl = BaseUrl + "/getBalance";
        public const string CreateTaskUrl = BaseUrl + "/createTask";
    }
}
