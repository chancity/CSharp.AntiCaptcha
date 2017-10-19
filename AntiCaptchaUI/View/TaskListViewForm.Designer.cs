namespace AntiCaptchaUI.View
{
    partial class TaskListViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.taskListView1 = new TaskListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // taskListView1
            // 
            this.taskListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskListView1.Location = new System.Drawing.Point(0, 0);
            this.taskListView1.Name = "taskListView1";
            this.taskListView1.Size = new System.Drawing.Size(906, 593);
            this.taskListView1.TabIndex = 0;
            // 
            // TaskListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 593);
            this.Controls.Add(this.taskListView1);
            this.Name = "TaskListViewForm";
            this.Text = "TaskListViewForm";
            this.ResumeLayout(false);

        }

        #endregion

        private TaskListView taskListView1;
        private System.Windows.Forms.Timer timer1;
    }
}