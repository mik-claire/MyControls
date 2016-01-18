using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MyControls
{
    public partial class Mik_Form : Form
    {
        public string Title
        {
            get
            {
                return this.label_Title.Text;
            }
            set
            {
                this.label_Title.Text = value;
            }
        }

        public Mik_Form()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            this.label_Title.Width = this.Width;
            this.label_Close.Location = new Point(this.Width - this.label_Close.Width, 0);
            this.label_Minimize.Location = new Point(this.Width - this.label_Close.Width - this.label_Minimize.Width - 3, 0);
        }

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(
            IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();
        private void label_Title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //マウスのキャプチャを解除
                ReleaseCapture();
                //タイトルバーでマウスの左ボタンが押されたことにする
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            }
        }

        private void label_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            // ((Label)sender).ForeColor = Color.RoyalBlue;
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            // ((Label)sender).ForeColor = Color.AliceBlue;
        }

    }
}
