namespace AntiCaptchaUI.View
{
    partial class CaptchaListViewForm
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
            this.captchaListView1 = new CaptchaListView();
            this.SuspendLayout();
            // 
            // captchaListView1
            // 
            this.captchaListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.captchaListView1.Location = new System.Drawing.Point(0, 0);
            this.captchaListView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.captchaListView1.Name = "captchaListView1";
            this.captchaListView1.Size = new System.Drawing.Size(858, 636);
            this.captchaListView1.TabIndex = 0;
            // 
            // CaptchaListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 636);
            this.Controls.Add(this.captchaListView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CaptchaListViewForm";
            this.Text = "Tester";
            this.ResumeLayout(false);

        }

        #endregion

        private CaptchaListView captchaListView1;
    }
}