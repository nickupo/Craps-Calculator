using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace craps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int result = Convert.ToInt32(textBox1.Text);
                result = result * 3;
                label_Output.Text = Convert.ToString("Payout: $" + result);
            }
            catch
            {
                label_Output.Text = "Invalid Input";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                double bet = Convert.ToInt32(textBox1.Text);
                double result = Math.Floor(bet * 27 / 4);
                label_Output.Text = Convert.ToString("Payout: $" + result);
            }
            catch {
                label_Output.Text = "Invalid Input";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int bet = Convert.ToInt32(textBox1.Text);
                double result = Math.Floor(bet * 14.5);
                label_Output.Text = Convert.ToString("Payout: $" + result);
            }
            catch
            {
                label_Output.Text = "Invalid Input";
            }
        }

        private void btn_twoWayL_Click(object sender, EventArgs e)
        {
            try
            {
                double bet = Convert.ToInt32(textBox1.Text);
                double result = Math.Floor(bet * 7);
                label_Output.Text = Convert.ToString("Payout: $" + result);
            }
            catch
            {
                label_Output.Text = "Invalid Input";
            }
        }

        private void btn_threeWayH_Click(object sender, EventArgs e)
        {
            try
            {
                double bet = Convert.ToInt32(textBox1.Text);
                double result = Math.Floor((bet * 10) - (.6666 * bet));
                label_Output.Text = Convert.ToString("Payout: $" + result);
            }
            catch
            {
                label_Output.Text = "Invalid Input";
            }
        }

        private void btn_threeWayL_Click(object sender, EventArgs e)
        {
            try
            {
                double bet = Convert.ToInt32(textBox1.Text);
                double result = Math.Floor((bet / 3) * 15 - (.66666 * bet));
                label_Output.Text = Convert.ToString("Payout: $" + result);
            }
            catch
            {
                label_Output.Text = "Invalid Input";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                double bet = Convert.ToInt32(textBox1.Text);
                double result = Math.Floor(bet * 7);
                label_Output.Text = Convert.ToString("Payout: $" + result);
            }
            catch
            {
                label_Output.Text = "Invalid Input";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                double bet = Convert.ToInt32(textBox1.Text);
                double result = Math.Floor((bet / 3) * 15 - (.66666 * bet));
                label_Output.Text = Convert.ToString("Payout: $" + result);
            }
            catch
            {
                label_Output.Text = "Invalid Input";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                int bet = Convert.ToInt32(textBox1.Text);
                double result = Math.Floor(bet * 14.5);
                label_Output.Text = Convert.ToString("Payout: $" + result);
            }
            catch
            {
                label_Output.Text = "Invalid Input";
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                double bet = Convert.ToInt32(textBox1.Text);
                double result = Math.Floor((bet * 10) - (.6666 * bet));
                label_Output.Text = Convert.ToString("Payout: $" + result);
            }
            catch
            {
                label_Output.Text = "Invalid Input";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                double bet = Convert.ToInt32(textBox1.Text);
                double result = Math.Floor((bet / 3) * 15 - (.66666 * bet));
                label_Output.Text = Convert.ToString("Payout: $" + result);
            }
            catch
            {
                label_Output.Text = "Invalid Input";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int bet = Convert.ToInt32(textBox1.Text);
                double result = Math.Floor(bet * 14.5);
                label_Output.Text = Convert.ToString("Payout: $" + result);
            }
            catch
            {
                label_Output.Text = "Invalid Input";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double bet = Convert.ToInt32(textBox1.Text);
                double result = Math.Floor((bet / 6) * 7);
                label_Output.Text = Convert.ToString("Payout: $" + result);
            }
            catch
            {
                label_Output.Text = "Invalid Input";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double bet = Convert.ToInt32(textBox1.Text);
                double result = Math.Floor((bet / 5) * 7);
                label_Output.Text = Convert.ToString("Payout: $" + result);
            }
            catch
            {
                label_Output.Text = "Invalid Input";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double bet = Convert.ToInt32(textBox1.Text);
                double result = Math.Floor((bet / 5) * 9);
                label_Output.Text = Convert.ToString("Payout: $" + result);
            }
            catch
            {
                label_Output.Text = "Invalid Input";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                double bet = Convert.ToInt32(textBox1.Text);
                double result = Math.Floor((bet * 2));
                label_Output.Text = Convert.ToString("Payout: $" + result);
            }
            catch
            {
                label_Output.Text = "Invalid Input";
            }
        }
    }
}
