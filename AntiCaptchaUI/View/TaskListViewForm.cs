using System.Windows.Forms;
using AntiCaptcha.CreateTask;

namespace AntiCaptchaUI.View
{
    public partial class TaskListViewForm : Form
    {
        public TaskListViewForm(CreateTaskResponse[] tasks)
        {
            InitializeComponent();
            taskListView1.SetObjects(tasks);

        }


    }
}
