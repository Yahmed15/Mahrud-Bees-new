namespace Mahrud_Bees
{
    partial class orders
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
            this.btnhomepage = new System.Windows.Forms.Button();
            this.lblorders = new System.Windows.Forms.Label();
            this.btnsignout = new System.Windows.Forms.Button();
            this.datagridorders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnaddorder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridorders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhomepage
            // 
            this.btnhomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhomepage.Location = new System.Drawing.Point(107, 388);
            this.btnhomepage.Name = "btnhomepage";
            this.btnhomepage.Size = new System.Drawing.Size(200, 40);
            this.btnhomepage.TabIndex = 16;
            this.btnhomepage.Text = "Homepage";
            this.btnhomepage.UseVisualStyleBackColor = true;
            this.btnhomepage.Click += new System.EventHandler(this.btnhomepage_Click);
            // 
            // lblorders
            // 
            this.lblorders.AutoSize = true;
            this.lblorders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorders.Location = new System.Drawing.Point(153, 32);
            this.lblorders.Name = "lblorders";
            this.lblorders.Size = new System.Drawing.Size(94, 29);
            this.lblorders.TabIndex = 15;
            this.lblorders.Text = "Orders";
            // 
            // btnsignout
            // 
            this.btnsignout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignout.Location = new System.Drawing.Point(494, 388);
            this.btnsignout.Name = "btnsignout";
            this.btnsignout.Size = new System.Drawing.Size(200, 40);
            this.btnsignout.TabIndex = 14;
            this.btnsignout.Text = "Sign Out";
            this.btnsignout.UseVisualStyleBackColor = true;
            this.btnsignout.Click += new System.EventHandler(this.btnsignout_Click);
            // 
            // datagridorders
            // 
            this.datagridorders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridorders.Location = new System.Drawing.Point(451, 152);
            this.datagridorders.Name = "datagridorders";
            this.datagridorders.RowHeadersWidth = 51;
            this.datagridorders.RowTemplate.Height = 24;
            this.datagridorders.Size = new System.Drawing.Size(333, 203);
            this.datagridorders.TabIndex = 36;
            this.datagridorders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridorders_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Add New Order";
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(194, 232);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(181, 34);
            this.txtquantity.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "Quantity:";
            // 
            // txtitem
            // 
            this.txtitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitem.Location = new System.Drawing.Point(194, 192);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(181, 34);
            this.txtitem.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Item:";
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomerid.Location = new System.Drawing.Point(194, 152);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.Size = new System.Drawing.Size(181, 34);
            this.txtcustomerid.TabIndex = 29;
            this.txtcustomerid.TextChanged += new System.EventHandler(this.txtcustomerid_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Customer ID:";
            // 
            // btnaddorder
            // 
            this.btnaddorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddorder.Location = new System.Drawing.Point(266, 316);
            this.btnaddorder.Name = "btnaddorder";
            this.btnaddorder.Size = new System.Drawing.Size(109, 39);
            this.btnaddorder.TabIndex = 39;
            this.btnaddorder.Text = "Add";
            this.btnaddorder.UseVisualStyleBackColor = true;
            this.btnaddorder.Click += new System.EventHandler(this.btnaddorder_Click);
            // 
            // orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnaddorder);
            this.Controls.Add(this.datagridorders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtitem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcustomerid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnhomepage);
            this.Controls.Add(this.lblorders);
            this.Controls.Add(this.btnsignout);
            this.Name = "orders";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.datagridorders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhomepage;
        private System.Windows.Forms.Label lblorders;
        private System.Windows.Forms.Button btnsignout;
        private System.Windows.Forms.DataGridView datagridorders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcustomerid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnaddorder;
    }
}
