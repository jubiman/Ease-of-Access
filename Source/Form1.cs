using System;
using System.Windows.Forms;

namespace Facebook_Function
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUrl_keyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                webBrowser1.Navigate(txtUrl.Text);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUrl.Text)) {
                webBrowser1.Navigate(txtUrl.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://google.nl");
            this.WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }
        
        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Focus();
            System.Windows.Forms.SendKeys.Send("{PGUP}");
        }

        private void btn_homepage_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://google.nl");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Down_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Focus();
            System.Windows.Forms.SendKeys.Send("{PGDN}");
        }
    }
}
