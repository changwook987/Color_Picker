using System;
using System.Drawing;
using System.Windows.Forms;

namespace Oh
{
    public partial class palet : Form
    {
        public palet()
        {
            InitializeComponent();
        }
        public void set()
        {
            int r = RED_SLB.Value;
            int g = GREEN_SLB.Value;
            int b = BLUE_SLB.Value;
            if (r > 128 && g > 128 && b > 128)
                Result.BackColor = Color.Black;
            else
                Result.BackColor = Color.White;
            Result.ForeColor = Color.FromArgb(r, g, b);
            RESULT_HEX.Text = RED_SLB.Value.ToString("X2") + GREEN_SLB.Value.ToString("X2") + BLUE_SLB.Value.ToString("X2");
        }
        private void RED_SLB_Scroll(object sender, ScrollEventArgs e)
        {
            set();
            RED.ForeColor = Color.FromArgb(RED_SLB.Value, 0, 0);
        }

        private void GREEN_SLB_Scroll(object sender, ScrollEventArgs e)
        {
            set();
            GREEN.ForeColor = Color.FromArgb(0, GREEN_SLB.Value, 0);
        }

        private void BLUE_SLB_Scroll(object sender, ScrollEventArgs e)
        {
            set();
            BLUE.ForeColor = Color.FromArgb(0, 0, BLUE_SLB.Value);
        }

        private void RESULT_HEX_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RESULT_HEX.Text);
            _ = MessageBox.Show("클립보드에 저장되었습니다.");
        }
    }
}
