using AntiCaptcha.GetTask;
using Newtonsoft.Json;

namespace AntiCaptcha.CreateTask
{

    public class CreateTaskResponse
    {
        [JsonProperty("errorId")]
        public int ErrorId { get; private set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; private set; }

        [JsonProperty("errorDescription")]
        public string ErrorDescription { get; private set; }

        [JsonProperty("taskId")]
        public int TaskId { get; private set; }

        public GetTaskResponse TaskResponse { get; set; }

        protected bool Equals(CreateTaskResponse other)
        {
            return TaskId == other.TaskId;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((CreateTaskResponse) obj);
        }

        public override int GetHashCode()
        {
            return TaskId;
        }
    }
}
