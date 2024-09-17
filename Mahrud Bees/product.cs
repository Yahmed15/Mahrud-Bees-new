using System;
using System.Windows.Forms;

namespace Mahrud_Bees
{
    public partial class product : Form
    {
        private DBAccess dbAccess;

        public product()
        {
            InitializeComponent();
            dbAccess = new DBAccess();
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

        private void label1_Click(object sender, EventArgs e)
        {
            // Label click event - handle if needed
            // For example:
            MessageBox.Show("Label 1 clicked!");
        }

        private void btnaddbees_Click(object sender, EventArgs e)
        {
            // Handle add bees button click - implement if needed
        }

        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            // Get the values from the textboxes
            string productName = txtproductname.Text;
            decimal productPrice;
            int supplierId;

            // Validate the input
            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Please enter a product name.");
                return;
            }

            if (!decimal.TryParse(txtproductprice.Text, out productPrice))
            {
                MessageBox.Show("Please enter a valid product price.");
                return;
            }

            if (!int.TryParse(txtsupplierid.Text, out supplierId))
            {
                MessageBox.Show("Please enter a valid supplier ID.");
                return;
            }

            // Insert product into the database
            try
            {
                int rowsAffected = dbAccess.InsertProduct(productName, productPrice, supplierId);

                // Check if the insert was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product added successfully!");
                }
                else
                {
                    MessageBox.Show("An error occurred while adding the product.");
                }
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void datagridproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event if needed
        }
    }
}
