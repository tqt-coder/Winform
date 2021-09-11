using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhuongTrinhBacHai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            load();

        }
        protected void load()
        {
            reset();
            this.panel2.Enabled = false;
        }
        protected void Handler()
        {
            double a;
            double b;
            double c;
            if (double.TryParse(this.txt_a.Text, out a) && double.TryParse(this.txt_b.Text, out b)
                && double.TryParse(this.txt_c.Text, out c))
            {
                this.panel2.Enabled = true;
                double D = b * b - 4 * a * c;
                if (D < 0)
                {
                    this.txt_x1.Text = "Phương trình vô nghiệm";
                    this.txt_x2.Enabled = false;
                    this.lb_x2.Enabled = false;
                }
                else
                    if (D == 0)
                {
                    this.txt_x1.Text = ((-b) / (2 * a)).ToString();
                    this.txt_x2.Enabled = false;
                    this.lb_x2.Enabled = false;
                }
                else
                {
                    this.txt_x1.Enabled = true;
                    this.txt_x2.Enabled = true;
                    this.txt_x1.Text = ((-b - Math.Sqrt(D)) / (2 * a)).ToString();
                    this.txt_x2.Text = ((-b + Math.Sqrt(D)) / (2 * a)).ToString();

                }
            }
            else
            {
                MessageBox.Show("Bạn nhập sai");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Handler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            load();
        }
        protected void reset()
        {
            this.txt_a.ResetText();
            this.txt_b.ResetText();
            this.txt_c.ResetText();
            this.txt_x1.ResetText();
            this.txt_x2.ResetText();
            this.txt_a.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
