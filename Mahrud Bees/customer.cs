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
    public partial class customer : Form
    {
        DBAccess objDBAccess = new DBAccess();

        public customer()
        {
            InitializeComponent();
            LoadCustomerData(); // Load customer data when the form is initialized
        }

        private void btnsignout_Click(object sender, EventArgs e)
        {
            // Show the signin page form
            signin signinForm = new signin();
            signinForm.Show();
            this.Hide();
        }

        private void btnhomepage_Click(object sender, EventArgs e)
        {
            // Show the homepage form
            this.Hide();
            homepage home = new homepage();
            home.Show();
        }

        private void btnaddcustomer_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Please enter the customer's first name.");
            }
            else if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please enter the customer's last name.");
            }
            else if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter the customer's email.");
            }
            else if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please enter the customer's phone number.");
            }
            else
            {
                int row = objDBAccess.InsertCustomer(firstName, lastName, email, phone);

                if (row == 1)
                {
                    MessageBox.Show("Customer added successfully.");
                    // Optionally, clear the text boxes or perform other actions
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtEmail.Clear();
                    txtPhone.Clear();

                    // Reload the customer data
                    LoadCustomerData();
                }
                else
                {
                    MessageBox.Show("Error occurred while adding the customer. Please try again.");
                }
            }
        }

        private void LoadCustomerData()
        {
            // Retrieve data from the database
            DataTable dtCustomers = objDBAccess.GetCustomerData();

            // Bind the data to the DataGridView
            dataGridcustomer.DataSource = dtCustomers;
        }

        private void dataGridcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click events if necessary
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
