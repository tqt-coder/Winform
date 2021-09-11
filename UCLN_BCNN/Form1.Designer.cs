
namespace UCLN_BCNN
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
            this.txt_b = new System.Windows.Forms.MaskedTextBox();
            this.txt_a = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rb_bc = new System.Windows.Forms.RadioButton();
            this.rb_uc = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.txt_b);
            this.panel1.Controls.Add(this.txt_a);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(23, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 147);
            this.panel1.TabIndex = 0;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(177, 94);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(225, 27);
            this.txt_b.TabIndex = 4;
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(177, 37);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(225, 27);
            this.txt_a.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(113, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(112, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "B:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Pink;
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.txt_result);
            this.panel2.Location = new System.Drawing.Point(54, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 192);
            this.panel2.TabIndex = 2;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Lime;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(659, 117);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(129, 38);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Orange;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(327, 117);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(151, 38);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Bỏ qua";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_search.Location = new System.Drawing.Point(35, 117);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(153, 38);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(292, 44);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(295, 27);
            this.txt_result.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orchid;
            this.panel3.Controls.Add(this.rb_bc);
            this.panel3.Controls.Add(this.rb_uc);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(632, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(312, 146);
            this.panel3.TabIndex = 3;
            // 
            // rb_bc
            // 
            this.rb_bc.AutoSize = true;
            this.rb_bc.Location = new System.Drawing.Point(61, 97);
            this.rb_bc.Name = "rb_bc";
            this.rb_bc.Size = new System.Drawing.Size(89, 24);
            this.rb_bc.TabIndex = 2;
            this.rb_bc.TabStop = true;
            this.rb_bc.Text = "BSCNN";
            this.rb_bc.UseVisualStyleBackColor = true;
            // 
            // rb_uc
            // 
            this.rb_uc.AutoSize = true;
            this.rb_uc.Location = new System.Drawing.Point(61, 35);
            this.rb_uc.Name = "rb_uc";
            this.rb_uc.Size = new System.Drawing.Size(87, 24);
            this.rb_uc.TabIndex = 1;
            this.rb_uc.TabStop = true;
            this.rb_uc.Text = "USCLN";
            this.rb_uc.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(13, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn tìm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "TÌm USCLN và BSCNN  của A và B";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txt_b;
        private System.Windows.Forms.MaskedTextBox txt_a;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.MaskedTextBox txt_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rb_bc;
        private System.Windows.Forms.RadioButton rb_uc;
        private System.Windows.Forms.Label label2;
    }
}

