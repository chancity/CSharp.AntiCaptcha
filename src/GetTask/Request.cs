using Newtonsoft.Json;

namespace AntiCaptcha.GetTask
{
    public class GetTaskRequest
    {
        [JsonProperty("clientKey")]
        public string ClientKey { get; }

        [JsonProperty("taskId")]
        public int TaskId { get; }

        [JsonProperty("isExtended")]
        public bool IsExtended { get; }

        public GetTaskRequest(string clientKey, int taskId, bool isExtended = false)
        {
            ClientKey = clientKey;
            TaskId = taskId;
            IsExtended = isExtended;
        }
    }
}