using Newtonsoft.Json;

namespace AntiCaptcha.ReportIncorrectImageCaptcha
{
    public class ReportIncorrectImageCaptchaRequest
    {
        [JsonProperty("clientKey")]
        public string ClientKey { get; }

        [JsonProperty("taskId")]
        public int TaskId { get; }

        public ReportIncorrectImageCaptchaRequest(string clientKey, int taskId)
        {
            ClientKey = clientKey;
            TaskId = taskId;
        }
    }
}