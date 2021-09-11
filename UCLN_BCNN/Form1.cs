using System;
using System.Windows.Forms;

namespace UCLN_BCNN
{
    public partial class Form1 : Form
    {
        private double a;
        private double b;
        private bool flagBtn = false;
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
            while (x != y)
            {
                if (x > y)
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

            if (double.TryParse(this.txt_a.Text, out a) && double.TryParse(this.txt_b.Text, out b) && a > 0 && b > 0)
            {
                if (!flagBtn)
                {
                    flagBtn = true;
                    this.txt_result.Enabled = true;
                    if (this.rb_bc.Checked)
                    {
                        BC();
                    }
                    else
                        if (this.rb_uc.Checked)
                    {
                        UC();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn nhập chưa đúng");
            }
        }
        private void UC()
        {
            
            double x = a;
            double y = b;
            double uc = timUCLN(x, y);
            this.txt_result.Text = uc.ToString();
        }
        private void BC()
        {
            double x = a;
            double y = b;
            double uc2 = timUCLN(x, y);
            if (uc2 != 0)
            {
                double bc = (a * b) / uc2;
                this.txt_result.Text = bc.ToString();
            }
            else
            {
                this.txt_result.Text = "Không tìm được kết quả";
            }
        }
        private void reset()
        {
            this.txt_a.ResetText();
            this.txt_b.ResetText();
            this.rb_bc.Checked = false;
            this.rb_uc.Checked = false;
            this.txt_result.ResetText(); // sử dụng checked changed nên khi reset trước radio button thì sẽ bị thay đổi giá trị một lần nữa
            this.txt_result.Enabled = false;
            flagBtn = false;
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

        private void rb_uc_CheckedChanged(object sender, EventArgs e)
        {
            this.txt_result.ResetText();
            if (flagBtn)
            {
                UC();
            }
           
        }

        private void rb_bc_CheckedChanged(object sender, EventArgs e)
        {
            this.txt_result.ResetText();

            if (flagBtn)
            {
                BC();
            }
        }
    }
}
