using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyControls
{
    public partial class Mik_Form : Form
    {
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

        private void label_Minimize_Click(object sender, EventArgs e)
        {

        }

        private void label_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.RoyalBlue;
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.AliceBlue;
        }
    }
}
