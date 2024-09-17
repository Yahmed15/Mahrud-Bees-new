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
    public partial class orders : Form
    {
        DBAccess objDBAccess = new DBAccess();

        public orders()
        {
            InitializeComponent();
            LoadOrdersData();
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

        private void btnaddorder_Click(object sender, EventArgs e)
        {
            int customerId;
            string item = txtitem.Text;
            int quantity;

            // Validate input

            if (!int.TryParse(txtcustomerid.Text, out customerId))
            {
                MessageBox.Show("Please enter a valid Customer ID.");
                return;
            }

            if (string.IsNullOrEmpty(item))
            {
                MessageBox.Show("Please enter the item.");
                return;
            }

            if (!int.TryParse(txtquantity.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            // Insert order into database
            int row = objDBAccess.InsertOrder(customerId, item, quantity);

            if (row == 1)
            {
                MessageBox.Show("Order added successfully.");
                // Optionally, clear the text boxes or perform other actions
                txtcustomerid.Clear();
                txtitem.Clear();
                txtquantity.Clear();

                // Reload data into datagrid
                LoadOrdersData();
            }
            else
            {
                MessageBox.Show("Error occurred while adding the order. Please try again.");
            }
        }

        private void LoadOrdersData()
        {
            DataTable dtOrders = objDBAccess.GetOrdersData();
            if (dtOrders != null)
            {
                datagridorders.DataSource = dtOrders;
            }
            else
            {
                MessageBox.Show("Error loading orders data.");
            }
        }

        private void datagridorders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtcustomerid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
