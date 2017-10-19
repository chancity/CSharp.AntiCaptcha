using System.Linq;
using System.Windows.Forms;
using AntiCaptcha.CreateTask;

namespace AntiCaptchaUI.View
{
    public partial class TaskListView : UserControl
    {
        private CreateTaskResponse[] _task;
        public TaskListView()
        {
            InitializeComponent();
        }

        public void SetObjects(CreateTaskResponse[] task)
        {
            _task = task;
            fastObjectListViewTask.SetObjects(_task);
        }

        private void timerRefresh_Tick(object sender, System.EventArgs e)
        {
            if (_task == null || _task.Length == 0) return;

            fastObjectListViewTask.RefreshObject(_task.FirstOrDefault());
        }
    }
}
