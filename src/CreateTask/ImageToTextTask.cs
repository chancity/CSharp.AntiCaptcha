using Newtonsoft.Json;

namespace AntiCaptcha.CreateTask
{

    public class ImageToTextTask : ICreateTask
    {
        [JsonProperty("type")]
        public string Type { get; set; } = "ImageToTextTask";

        [JsonProperty("body")]
        public string BodyBase64 { get; set; } = "";

        [JsonProperty("phrase")]
        public bool Phrase { get; set; } = false;

        [JsonProperty("case")]
        public bool Case { get; set; } = false;

        [JsonProperty("numeric")]
        public bool Numeric { get; set; } = false;

        [JsonProperty("math")]
        public int Math { get; set; } = 0;
        [JsonProperty("minLength")]
        public int MinLength {  get; set; } = 0;
        [JsonProperty("maxLength")]
        public int MaxLength {  get; set; } = 0;

    }
}

