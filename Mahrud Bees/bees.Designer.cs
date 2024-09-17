using System;
using System.Data;
using System.Windows.Forms;

namespace Mahrud_Bees
{
    partial class bees
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
            this.lblbees = new System.Windows.Forms.Label();
            this.btnsignout = new System.Windows.Forms.Button();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaddbees = new System.Windows.Forms.Button();
            this.datagridbees = new System.Windows.Forms.DataGridView();
            this.txtbeesid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridbees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhomepage
            // 
            this.btnhomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhomepage.Location = new System.Drawing.Point(12, 398);
            this.btnhomepage.Name = "btnhomepage";
            this.btnhomepage.Size = new System.Drawing.Size(200, 40);
            this.btnhomepage.TabIndex = 16;
            this.btnhomepage.Text = "Homepage";
            this.btnhomepage.UseVisualStyleBackColor = true;
            this.btnhomepage.Click += new System.EventHandler(this.btnhomepage_Click);
            // 
            // lblbees
            // 
            this.lblbees.AutoSize = true;
            this.lblbees.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbees.Location = new System.Drawing.Point(139, 27);
            this.lblbees.Name = "lblbees";
            this.lblbees.Size = new System.Drawing.Size(73, 29);
            this.lblbees.TabIndex = 15;
            this.lblbees.Text = "Bees";
            // 
            // btnsignout
            // 
            this.btnsignout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignout.Location = new System.Drawing.Point(588, 398);
            this.btnsignout.Name = "btnsignout";
            this.btnsignout.Size = new System.Drawing.Size(200, 40);
            this.btnsignout.TabIndex = 14;
            this.btnsignout.Text = "Sign Out";
            this.btnsignout.UseVisualStyleBackColor = true;
            this.btnsignout.Click += new System.EventHandler(this.btnsignout_Click);
            // 
            // txtcolor
            // 
            this.txtcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcolor.Location = new System.Drawing.Point(144, 256);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(181, 34);
            this.txtcolor.TabIndex = 22;
            this.txtcolor.TextChanged += new System.EventHandler(this.txtcolor_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Color";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(144, 216);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(181, 34);
            this.txtage.TabIndex = 20;
            this.txtage.TextChanged += new System.EventHandler(this.txtage_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Age:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txttype
            // 
            this.txttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttype.Location = new System.Drawing.Point(144, 176);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(181, 34);
            this.txttype.TabIndex = 18;
            this.txttype.TextChanged += new System.EventHandler(this.txttype_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Type:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Add New Bees";
            // 
            // btnaddbees
            // 
            this.btnaddbees.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddbees.Location = new System.Drawing.Point(217, 299);
            this.btnaddbees.Name = "btnaddbees";
            this.btnaddbees.Size = new System.Drawing.Size(108, 40);
            this.btnaddbees.TabIndex = 24;
            this.btnaddbees.Text = "Add";
            this.btnaddbees.UseVisualStyleBackColor = true;
            this.btnaddbees.Click += new System.EventHandler(this.btnaddbees_Click);
            // 
            // datagridbees
            // 
            this.datagridbees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridbees.Location = new System.Drawing.Point(377, 136);
            this.datagridbees.Name = "datagridbees";
            this.datagridbees.RowHeadersWidth = 51;
            this.datagridbees.RowTemplate.Height = 24;
            this.datagridbees.Size = new System.Drawing.Size(393, 203);
            this.datagridbees.TabIndex = 25;
            this.datagridbees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridbees_CellContentClick);
            // 
            // txtbeesid
            // 
            this.txtbeesid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbeesid.Location = new System.Drawing.Point(144, 136);
            this.txtbeesid.Name = "txtbeesid";
            this.txtbeesid.Size = new System.Drawing.Size(181, 34);
            this.txtbeesid.TabIndex = 27;
            this.txtbeesid.TextChanged += new System.EventHandler(this.txtbeesid_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "ID";
            // 
            // bees
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
            this.Controls.Add(this.lblbees);
            this.Controls.Add(this.btnsignout);
            this.Name = "bees";
            this.Text = "bees";
            this.Load += new System.EventHandler(this.bees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridbees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtcolor_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txttype_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void datagridbees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void bees_Load(object sender, EventArgs e)
        {
            // Example: Set the title of the form when it loads
            this.Text = "Bees Application";

            // Example: Load data into a DataGridView
            LoadDataIntoDataGridView();

            // Other initialization tasks as needed...
        }

        private void LoadDataIntoDataGridView()
        {
            // Example method to load data into DataGridView
            // Replace with your actual data loading logic
            DataTable dt = GetDataFromDatabase(); // Example method to fetch data from database
            datagridbees.DataSource = dt;
        }

        private DataTable GetDataFromDatabase()
        {
            // Example method to fetch data from database
            // Replace with your actual data retrieval logic
            DataTable dt = new DataTable();
            // Populate DataTable with data from database
            // For demonstration, let's create a dummy DataTable
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add(1, "Bee1");
            dt.Rows.Add(2, "Bee2");
            dt.Rows.Add(3, "Bee3");
            return dt;
        }


        #endregion

        private System.Windows.Forms.Button btnhomepage;
        private System.Windows.Forms.Label lblbees;
        private System.Windows.Forms.Button btnsignout;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaddbees;
        private System.Windows.Forms.DataGridView datagridbees;
        private System.Windows.Forms.TextBox txtbeesid;
        private System.Windows.Forms.Label label5;
    }
}