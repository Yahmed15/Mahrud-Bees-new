namespace Mahrud_Bees
{
    partial class signin
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
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsignin = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblnoaccount = new System.Windows.Forms.Label();
            this.btnsignuppage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(351, 163);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(290, 34);
            this.txtpassword.TabIndex = 11;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password:";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(351, 108);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(290, 34);
            this.txtname.TabIndex = 9;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblsignin
            // 
            this.lblsignin.AutoSize = true;
            this.lblsignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignin.Location = new System.Drawing.Point(344, 38);
            this.lblsignin.Name = "lblsignin";
            this.lblsignin.Size = new System.Drawing.Size(124, 38);
            this.lblsignin.TabIndex = 7;
            this.lblsignin.Text = "Sign In";
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(498, 236);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(142, 43);
            this.btnlogin.TabIndex = 12;
            this.btnlogin.Text = "Sign In";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblnoaccount
            // 
            this.lblnoaccount.AutoSize = true;
            this.lblnoaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoaccount.Location = new System.Drawing.Point(210, 350);
            this.lblnoaccount.Name = "lblnoaccount";
            this.lblnoaccount.Size = new System.Drawing.Size(266, 29);
            this.lblnoaccount.TabIndex = 13;
            this.lblnoaccount.Text = "Don\'t have an account";
            // 
            // btnsignuppage
            // 
            this.btnsignuppage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignuppage.Location = new System.Drawing.Point(499, 344);
            this.btnsignuppage.Name = "btnsignuppage";
            this.btnsignuppage.Size = new System.Drawing.Size(142, 43);
            this.btnsignuppage.TabIndex = 14;
            this.btnsignuppage.Text = "Sign Up";
            this.btnsignuppage.UseVisualStyleBackColor = true;
            this.btnsignuppage.Click += new System.EventHandler(this.btnsignuppage_Click);
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsignuppage);
            this.Controls.Add(this.lblnoaccount);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblsignin);
            this.Name = "signin";
            this.Text = "signin";
            this.Load += new System.EventHandler(this.signin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsignin;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblnoaccount;
        private System.Windows.Forms.Button btnsignuppage;
    }
}