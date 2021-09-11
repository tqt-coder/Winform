
namespace SoNguyenTo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.btn_list = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_li_result = new System.Windows.Forms.RichTextBox();
            this.txt_sum = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_list);
            this.panel1.Controls.Add(this.txt_n);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(87, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 155);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aquamarine;
            this.panel2.Controls.Add(this.txt_sum);
            this.panel2.Controls.Add(this.txt_li_result);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(87, 235);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 249);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(63, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(83, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách các số nguyên tố";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Location = new System.Drawing.Point(566, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng cộng";
            // 
            // txt_n
            // 
            this.txt_n.Location = new System.Drawing.Point(36, 84);
            this.txt_n.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(176, 28);
            this.txt_n.TabIndex = 3;
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(264, 84);
            this.btn_list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(183, 36);
            this.btn_list.TabIndex = 4;
            this.btn_list.Text = "Liệt kê";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(514, 84);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(183, 36);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Bỏ qua";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(731, 84);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(183, 36);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_li_result
            // 
            this.txt_li_result.Location = new System.Drawing.Point(53, 25);
            this.txt_li_result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_li_result.Name = "txt_li_result";
            this.txt_li_result.Size = new System.Drawing.Size(436, 131);
            this.txt_li_result.TabIndex = 3;
            this.txt_li_result.Text = "";
            // 
            // txt_sum
            // 
            this.txt_sum.Location = new System.Drawing.Point(690, 168);
            this.txt_sum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.Size = new System.Drawing.Size(176, 28);
            this.txt_sum.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1114, 552);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Liệt kê danh sách số nguyên tố";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txt_li_result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sum;
    }
}

