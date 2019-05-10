using Newtonsoft.Json;

namespace AntiCaptcha.CreateTask
{
    public class ImageToTextTask : ICreateTask
    {
        [JsonProperty("body")]
        public string BodyBase64 { get; set; } = "";

        [JsonProperty("phrase")]
        public bool Phrase { get; set; }

        [JsonProperty("case")]
        public bool Case { get; set; }

        [JsonProperty("numeric")]
        public bool Numeric { get; set; }

        [JsonProperty("math")]
        public int Math { get; set; }

        [JsonProperty("minLength")]
        public int MinLength { get; set; }

        [JsonProperty("maxLength")]
        public int MaxLength { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; } = "ImageToTextTask";
    }
}