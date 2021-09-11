using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoNguyenTo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            formLoad();
        }
        protected void formLoad()
        {
            reset();
            this.panel2.Enabled = false;
        }
        private bool laSoNguyenTo(int n)
        {
            int dem = 0;
            for( int i = 1; i <= n; i++)
            {
                if( n % i == 0)
                {
                    dem++;
                }
            }
            if (dem == 2)
                return true;
            return false;
        }
        protected void listNumber()
        {
            int n;
            if (int.TryParse(this.txt_n.Text, out n))
            {
                this.panel2.Enabled = true;
                
                string s = "";
                int sum = 0;
                for(int i = 1; i<n; i++)
                {
                    if (laSoNguyenTo(i))
                    {
                        s = s + i.ToString() + ", ";
                        sum = sum + i;
                    }
                }
               
                int l = s.Length;
                if(l >= 1)
                {
                    string s2 = s.Substring(0, l - 2);
                    this.txt_li_result.Text = s2;
                    this.txt_sum.Text = sum.ToString();
                }
                else
                {
                    this.txt_li_result.Text = "Không tìm thấy";
                }
            }
            else
            {
                MessageBox.Show("Bạn nhập chưa đúng");
                
            }
        }
        private void btn_list_Click(object sender, EventArgs e)
        {
            listNumber();
        }
        private void reset()
        {
            this.txt_n.ResetText();
            this.txt_li_result.ResetText();
            this.txt_sum.ResetText();
            this.txt_n.Focus();
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
