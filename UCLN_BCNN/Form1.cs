using System;
using System.Windows.Forms;

namespace UCLN_BCNN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            reset();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            handler();
        }
        private double timUCLN(double x, double y)
        {
            while( x != y)
            {
                if( x > y)
                {
                    x = x - y;
                }
                else
                {
                    y = y - x;
                }
            }
            return x;
        }
        protected void handler()
        {
            if (this.txt_a.Text != "" && this.txt_b.Text != "")
            {
                double a = double.Parse(this.txt_a.Text);
                double b = double.Parse(this.txt_b.Text);
                double x = a;
                double y = b;

                if (this.rb_uc.Checked)
                {
                    double uc = timUCLN(x, y);
                    this.txt_result.Text = uc.ToString();
                }
                else
                    if (this.rb_bc.Checked)
                    {
                        double uc2 = timUCLN(x, y);
                        double bc = (a * b) / uc2;
                        this.txt_result.Text = bc.ToString();
                    }

            }
        }
        private void reset()
        {
            this.txt_a.ResetText();
            this.txt_b.ResetText();
            this.txt_result.ResetText();
            this.rb_bc.Checked = false;
            this.rb_uc.Checked = false;
            this.txt_a.Focus();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
