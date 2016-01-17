using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyControls
{
    public partial class Mik_LabelButton : Mik_Label
    {
        public Mik_LabelButton()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void Mik_Label_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.RoyalBlue;
        }

        private void Mik_Label_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.AliceBlue;
        }
    }
}
