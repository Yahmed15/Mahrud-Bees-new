﻿namespace Mahrud_Bees
{
    partial class payment
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
            this.lblpayment = new System.Windows.Forms.Label();
            this.btnsignout = new System.Windows.Forms.Button();
            this.btnhomepage = new System.Windows.Forms.Button();
            this.txtbeesid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datagridbees = new System.Windows.Forms.DataGridView();
            this.btnaddbees = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridbees)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpayment
            // 
            this.lblpayment.AutoSize = true;
            this.lblpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayment.Location = new System.Drawing.Point(157, 29);
            this.lblpayment.Name = "lblpayment";
            this.lblpayment.Size = new System.Drawing.Size(126, 29);
            this.lblpayment.TabIndex = 0;
            this.lblpayment.Text = "Payments";
            // 
            // btnsignout
            // 
            this.btnsignout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignout.Location = new System.Drawing.Point(450, 398);
            this.btnsignout.Name = "btnsignout";
            this.btnsignout.Size = new System.Drawing.Size(200, 40);
            this.btnsignout.TabIndex = 11;
            this.btnsignout.Text = "Sign Out";
            this.btnsignout.UseVisualStyleBackColor = true;
            this.btnsignout.Click += new System.EventHandler(this.btnsignout_Click);
            // 
            // btnhomepage
            // 
            this.btnhomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhomepage.Location = new System.Drawing.Point(116, 398);
            this.btnhomepage.Name = "btnhomepage";
            this.btnhomepage.Size = new System.Drawing.Size(200, 40);
            this.btnhomepage.TabIndex = 17;
            this.btnhomepage.Text = "Homepage";
            this.btnhomepage.UseVisualStyleBackColor = true;
            this.btnhomepage.Click += new System.EventHandler(this.btnhomepage_Click);
            // 
            // txtbeesid
            // 
            this.txtbeesid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbeesid.Location = new System.Drawing.Point(162, 147);
            this.txtbeesid.Name = "txtbeesid";
            this.txtbeesid.Size = new System.Drawing.Size(181, 34);
            this.txtbeesid.TabIndex = 38;
            this.txtbeesid.TextChanged += new System.EventHandler(this.txtbeesid_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 29);
            this.label5.TabIndex = 37;
            this.label5.Text = "ID:";
            // 
            // datagridbees
            // 
            this.datagridbees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridbees.Location = new System.Drawing.Point(395, 147);
            this.datagridbees.Name = "datagridbees";
            this.datagridbees.RowHeadersWidth = 51;
            this.datagridbees.RowTemplate.Height = 24;
            this.datagridbees.Size = new System.Drawing.Size(393, 203);
            this.datagridbees.TabIndex = 36;
            // 
            // btnaddbees
            // 
            this.btnaddbees.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddbees.Location = new System.Drawing.Point(235, 310);
            this.btnaddbees.Name = "btnaddbees";
            this.btnaddbees.Size = new System.Drawing.Size(108, 40);
            this.btnaddbees.TabIndex = 35;
            this.btnaddbees.Text = "Add";
            this.btnaddbees.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Add New Payment";
            // 
            // txtcolor
            // 
            this.txtcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcolor.Location = new System.Drawing.Point(162, 267);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(181, 34);
            this.txtcolor.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "Amount:";
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(162, 227);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(181, 34);
            this.txtage.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Method:";
            // 
            // txttype
            // 
            this.txttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttype.Location = new System.Drawing.Point(162, 187);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(181, 34);
            this.txttype.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Order ID:";
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbeesid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datagridbees);
            this.Controls.Add(this.btnaddbees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnhomepage);
            this.Controls.Add(this.btnsignout);
            this.Controls.Add(this.lblpayment);
            this.Name = "payment";
            this.Text = "payment";
            ((System.ComponentModel.ISupportInitialize)(this.datagridbees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpayment;
        private System.Windows.Forms.Button btnsignout;
        private System.Windows.Forms.Button btnhomepage;
        private System.Windows.Forms.TextBox txtbeesid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView datagridbees;
        private System.Windows.Forms.Button btnaddbees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.Label label2;
    }
}