using System;

namespace Mahrud_Bees
{
    partial class Signup
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsignup = new System.Windows.Forms.Button();
            this.btnsigninpage = new System.Windows.Forms.Button();
            this.lblnoaccount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(351, 92);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(290, 34);
            this.txtname.TabIndex = 2;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(351, 147);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(290, 34);
            this.txtemail.TabIndex = 4;
            this.txtemail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(351, 200);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(290, 34);
            this.txtpassword.TabIndex = 6;
            this.txtpassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // btnsignup
            // 
            this.btnsignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignup.Location = new System.Drawing.Point(506, 261);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(135, 42);
            this.btnsignup.TabIndex = 7;
            this.btnsignup.Text = "Sign Up";
            this.btnsignup.UseVisualStyleBackColor = true;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // btnsigninpage
            // 
            this.btnsigninpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsigninpage.Location = new System.Drawing.Point(518, 351);
            this.btnsigninpage.Name = "btnsigninpage";
            this.btnsigninpage.Size = new System.Drawing.Size(142, 43);
            this.btnsigninpage.TabIndex = 16;
            this.btnsigninpage.Text = "Sign In";
            this.btnsigninpage.UseVisualStyleBackColor = true;
            this.btnsigninpage.Click += new System.EventHandler(this.btnsigninpage_Click);
            // 
            // lblnoaccount
            // 
            this.lblnoaccount.AutoSize = true;
            this.lblnoaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoaccount.Location = new System.Drawing.Point(193, 357);
            this.lblnoaccount.Name = "lblnoaccount";
            this.lblnoaccount.Size = new System.Drawing.Size(295, 29);
            this.lblnoaccount.TabIndex = 15;
            this.lblnoaccount.Text = "Already have an account";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsigninpage);
            this.Controls.Add(this.lblnoaccount);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Signup";
            this.Text = "signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.Button btnsigninpage;
        private System.Windows.Forms.Label lblnoaccount;
    }
}

