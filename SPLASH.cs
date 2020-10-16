using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace timer
{
    public partial class SPLASH : Form
    {
        public SPLASH()

        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {
                progressBar1.ForeColor = Color.Red;
                progressBar1.Value += 1;
            }else
            {
                timer1.Stop();
                SEGON fm2 = new SEGON();
                fm2.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)
                   {
                timer1.Stop();
                KEYPAD fm3 = new KEYPAD();
                fm3.Show();
                this.Hide();
                   }
        }
    }
}
