using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mahrud_Bees
{
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void homepage_Load(object sender, EventArgs e)
        {

        }

        private void btnsignout_Click(object sender, EventArgs e)
        {
            // Show the signin page form
            signin signinForm = new signin();
            signinForm.Show();
            this.Hide();
            // Optionally, you can hide the current form (signin form)
            // this.Hide();
        }

        private void btnqueen_Click(object sender, EventArgs e)
        {
            // Show the queens page form
            queens queensForm = new queens();
            queensForm.Show();
            this.Hide();
            // Optionally, you can hide the current form (signin form)
            // this.Hide();
        }

        private void btnbees_Click(object sender, EventArgs e)
        {
            // Show the bees page form
            bees beesForm = new bees();
            beesForm.Show();
            this.Hide();
            // Optionally, you can hide the current form (signin form)
            // this.Hide();
        }

        private void btnemployees_Click(object sender, EventArgs e)
        {
            // Show the employees page form
            employees employeesForm = new employees();
            employeesForm.Show();
            this.Hide();
            // Optionally, you can hide the current form (signin form)
            // this.Hide();
        }

        private void btnsupplier_Click(object sender, EventArgs e)
        {
            // Show the supplier page form
            supplier supplierForm = new supplier();
            supplierForm.Show();
            this.Hide();
            // Optionally, you can hide the current form (signin form)
            // this.Hide();
        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            // Show the orders page form
            orders ordersForm = new orders();
            ordersForm.Show();
            this.Hide();
            // Optionally, you can hide the current form (signin form)
            // this.Hide();
        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            // Show the payment page form
            payment paymentForm = new payment();
            paymentForm.Show();
            this.Hide();
            // Optionally, you can hide the current form (signin form)
            // this.Hide();
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            // Show the product page form
            product productForm = new product();
            productForm.Show();
            this.Hide();
            // Optionally, you can hide the current form (signin form)
            // this.Hide();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            // Show the customer page form
            customer customerForm = new customer();
            customerForm.Show();
            this.Hide();
            // Optionally, you can hide the current form (signin form)
            // this.Hide();
        }
    }
}
