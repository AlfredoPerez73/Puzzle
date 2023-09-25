using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RompeCabeza
{
    public partial class PrimariaGUI : Form
    {
        public PrimariaGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button1.Text;
                button1.Text = "";
                return;
            }
            if (button5.Text == "")
            {
                button5.Text = button1.Text;
                button1.Text = "";
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button2.Text;
                button2.Text = "";
                return;
            }
            if (button3.Text == "")
            {
                button3.Text = button2.Text;
                button2.Text = "";
                return;
            }
            if (button6.Text == "")
            {
                button6.Text = button2.Text;
                button2.Text = "";
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button3.Text;
                button3.Text = "";
                return;
            }
            if (button4.Text == "")
            {
                button4.Text = button3.Text;
                button3.Text = "";
                return;
            }
            if (button7.Text == "")
            {
                button7.Text = button3.Text;
                button3.Text = "";
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = button4.Text;
                button4.Text = "";
                return;
            }
            if (button8.Text == "")
            {
                button8.Text = button4.Text;
                button4.Text = "";
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button5.Text;
                button5.Text = "";
                return;
            }
            if (button6.Text == "")
            {
                button6.Text = button5.Text;
                button5.Text = "";
                return;
            }
            if (button9.Text == "")
            {
                button9.Text = button5.Text;
                button5.Text = "";
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button3.Text = button6.Text;
                button6.Text = "";
                return;
            }
            if (button5.Text == "")
            {
                button5.Text = button6.Text;
                button6.Text = "";
                return;
            }
            if (button7.Text == "")
            {
                button7.Text = button6.Text;
                button6.Text = "";
                return;
            }
            if (button10.Text == "")
            {
                button10.Text = button6.Text;
                button6.Text = "";
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = button7.Text;
                button7.Text = "";
                return;
            }
            if (button6.Text == "")
            {
                button6.Text = button7.Text;
                button7.Text = "";
                return;
            }
            if (button8.Text == "")
            {
                button8.Text = button7.Text;
                button7.Text = "";
                return;
            }
            if (button11.Text == "")
            {
                button11.Text = button7.Text;
                button7.Text = "";
                return;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = button8.Text;
                button8.Text = "";
                return;
            }
            if (button7.Text == "")
            {
                button7.Text = button8.Text;
                button8.Text = "";
                return;
            }
            if (button12.Text == "")
            {
                button12.Text = button8.Text;
                button8.Text = "";
                return;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = button9.Text;
                button9.Text = "";
                return;
            }
            if (button10.Text == "")
            {
                button10.Text = button9.Text;
                button9.Text = "";
                return;
            }
            if (button13.Text == "")
            {
                button13.Text = button9.Text;
                button9.Text = "";
                return;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = button10.Text;
                button10.Text = "";
                return;
            }
            if (button9.Text == "")
            {
                button9.Text = button10.Text;
                button10.Text = "";
                return;
            }
            if (button11.Text == "")
            {
                button11.Text = button10.Text;
                button10.Text = "";
                return;
            }
            if (button14.Text == "")
            {
                button14.Text = button10.Text;
                button10.Text = "";
                return;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = button11.Text;
                button11.Text = "";
                return;
            }
            if (button10.Text == "")
            {
                button10.Text = button11.Text;
                button11.Text = "";
                return;
            }
            if (button12.Text == "")
            {
                button12.Text = button11.Text;
                button11.Text = "";
                return;
            }
            if (button15.Text == "")
            {
                button15.Text = button11.Text;
                button11.Text = "";
                return;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                button8.Text = button12.Text;
                button12.Text = "";
                return;
            }
            if (button11.Text == "")
            {
                button11.Text = button12.Text;
                button12.Text = "";
                return;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                button9.Text = button13.Text;
                button13.Text = "";
                return;
            }
            if (button14.Text == "")
            {
                button14.Text = button13.Text;
                button13.Text = "";
                return;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button10.Text == "")
            {
                button10.Text = button14.Text;
                button14.Text = "";
                return;
            }
            if (button13.Text == "")
            {
                button13.Text = button14.Text;
                button14.Text = "";
                return;
            }
            if (button15.Text == "")
            {
                button15.Text = button14.Text;
                button14.Text = "";
                return;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button11.Text == "")
            {
                button11.Text = button15.Text;
                button15.Text = "";
                return;
            }
            if (button14.Text == "")
            {
                button14.Text = button15.Text;
                button15.Text = "";
                return;
            }
            if (button16.Text == "")
            {
                button16.Text = button15.Text;
                button15.Text = "";
                return;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button12.Text == "")
            {
                button12.Text = button16.Text;
                button16.Text = "";
                return;
            }
            if (button15.Text == "")
            {
                button15.Text = button16.Text;
                button16.Text = "";
                return;
            }
        }
    }
}
