using Newtonsoft.Json;

namespace AntiCaptcha.CreateTask
{

    public class CreateTaskRequest
    {

        [JsonProperty("clientKey")]
        public string ClientKey { get; set; }
        [JsonProperty("task")]
        public ICreateTask CreateTask { get; set; }
        [JsonProperty("softId")]
        public int SoftId { get; set; } = 0;
        [JsonProperty("languagePool")]
        public string LanguagePool { get; set; } = "en";


        public CreateTaskRequest(string clientKey, ICreateTask createTask)
        {
            ClientKey = clientKey;
            CreateTask = createTask;
        }
        public CreateTaskRequest(string clientKey, ICreateTask createTask, int softId)
        {
            ClientKey = clientKey;
            CreateTask = createTask;
            SoftId = softId;
        }
        public CreateTaskRequest(string clientKey, ICreateTask createTask, string languagePool)
        {
            ClientKey = clientKey;
            CreateTask = createTask;
            LanguagePool = languagePool;
        }
        public CreateTaskRequest(string clientKey, ICreateTask createTask, string languagePool, int softId)
        {
            ClientKey = clientKey;
            CreateTask = createTask;
            LanguagePool = languagePool;
            SoftId = softId;
        }

    }
}

