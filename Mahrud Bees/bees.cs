using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mahrud_Bees
{
    public partial class bees : Form
    {
        private DBAccess objDBAccess = new DBAccess();

        public bees()
        {
            InitializeComponent();
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

        private void btnaddbees_Click(object sender, EventArgs e)
        {
            string Type = txttype.Text;
            string Age = txtage.Text;
            string Color = txtcolor.Text;
            string BeesId = txtbeesid.Text;

            // Check if any of the fields are empty
            if (string.IsNullOrWhiteSpace(Type) || string.IsNullOrWhiteSpace(Age) || string.IsNullOrWhiteSpace(Color) || string.IsNullOrWhiteSpace(BeesId))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Execute SQL command to insert data into the database
            SqlCommand insertCommand = new SqlCommand("INSERT INTO Bees (Type, Age, Color, BeesId) VALUES (@type, @age, @color, @beesId)");
            insertCommand.Parameters.AddWithValue("@type", Type);
            insertCommand.Parameters.AddWithValue("@age", Age);
            insertCommand.Parameters.AddWithValue("@color", Color);
            insertCommand.Parameters.AddWithValue("@beesId", BeesId);

            int rowsAffected = objDBAccess.ExecuteNonQuery(insertCommand);

            if (rowsAffected == 1)
            {
                MessageBox.Show("Bees added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Optionally, clear the textboxes after successful insertion
                txttype.Clear();
                txtage.Clear();
                txtcolor.Clear();
                txtbeesid.Clear();
            }
            else
            {
                MessageBox.Show("Failed to add bees. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Macro-like functionality: Validate Bees ID input to ensure it's numeric
        private void txtbeesid_TextChanged(object sender, EventArgs e)
        {
            // Check if the input is not numeric
            if (!int.TryParse(txtbeesid.Text, out _))
            {
                MessageBox.Show("Please enter only numeric values for Bees ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbeesid.Clear();  // Clear the field if input is invalid
            }
        }
    }
}
