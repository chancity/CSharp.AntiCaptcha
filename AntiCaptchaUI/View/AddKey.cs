using System;
using System.Windows.Forms;

namespace AntiCaptchaUI.View
{
    public partial class AddKey : Form
    {
        public string ClientKey;
        public string WebsiteUrl;
        public string ReCaptchaKey;

        public AddKey()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAntiCaptchaKey.Text))
            {
                MessageBox.Show(this, "Invalid input", "Error");
                return;
            }

            ClientKey = textBoxAntiCaptchaKey.Text;


            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
