using Newtonsoft.Json;

namespace AntiCaptcha.ReportIncorrectImageCaptcha
{
    public class ReportIncorrectImageCaptchaResponse
    {
        [JsonProperty("errorId")]
        public int ErrorId { get; private set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; private set; }

        [JsonProperty("errorDescription")]
        public string ErrorDescription { get; private set; }

        [JsonProperty("status")]
        public string Status { get; private set; }
    }
}