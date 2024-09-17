using System;
using System.Data;
using System.Windows.Forms;

namespace Mahrud_Bees
{
    public partial class supplier : Form
    {
        private DBAccess dbAccess;

        public supplier()
        {
            InitializeComponent();
            dbAccess = new DBAccess();
        }

        private void btnhomepage_Click(object sender, EventArgs e)
        {
            // Show the homepage form
            this.Hide();
            homepage home = new homepage();
            home.Show();
        }

        private void btnsignout_Click(object sender, EventArgs e)
        {
            // Show the signin page form
            signin signinForm = new signin();
            signinForm.Show();
            this.Hide();
        }

        private void btndeletesupplier_Click(object sender, EventArgs e)
        {
            // Ensure a supplier is selected in the DataGridView
            if (datagridsupplier.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier to delete.");
                return;
            }

            // Get the Supplier_ID from the selected row
            int supplierId = Convert.ToInt32(datagridsupplier.SelectedRows[0].Cells["Supplier_ID"].Value);

            // Prompt user for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Attempt to delete the supplier from the database
                    int rowsAffected = dbAccess.DeleteSupplier(supplierId);

                    // Check if deletion was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Supplier deleted successfully!");
                        // Refresh the DataGridView to reflect changes
                        RefreshDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete supplier.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void RefreshDataGridView()
        {
            try
            {
                // Reload suppliers data into the DataGridView
                DataTable dtSuppliers = dbAccess.GetSuppliersData();
                datagridsupplier.DataSource = dtSuppliers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message);
            }
        }

        private void supplier_Load(object sender, EventArgs e)
        {
            // Load suppliers data into the DataGridView when form loads
            RefreshDataGridView();
        }

        private void datagridsupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsupplierid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            // Check if the supplier ID is entered
            if (string.IsNullOrWhiteSpace(txtsupplierid.Text))
            {
                MessageBox.Show("Please enter a supplier ID to delete.");
                return;
            }

            // Get the Supplier_ID from the textbox
            if (!int.TryParse(txtsupplierid.Text, out int supplierId))
            {
                MessageBox.Show("Please enter a valid supplier ID.");
                return;
            }

            // Prompt user for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Attempt to delete the supplier from the database
                    int rowsAffected = dbAccess.DeleteSupplier(supplierId);

                    // Check if deletion was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Supplier deleted successfully!");
                        // Refresh the DataGridView to reflect changes
                        RefreshDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete supplier. Supplier ID may not exist.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
