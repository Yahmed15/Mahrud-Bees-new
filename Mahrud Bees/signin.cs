using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mahrud_Bees
{
    public partial class signin : Form
    {
        private DBAccess objDBAccess = new DBAccess();

        public signin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtname.Text;
            string userpassword = txtpassword.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your Username.");
                return;
            }

            if (string.IsNullOrEmpty(userpassword))
            {
                MessageBox.Show("Please enter your Password.");
                return;
            }

            // Check if the username and password match in the database
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Name = @username AND Password = @userpassword");
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@userpassword", userpassword);

            try
            {
                object result = objDBAccess.ExecuteScalar(command);

                // Convert the result to an integer
                int count = Convert.ToInt32(result);

                if (count == 1)
                {
                    MessageBox.Show("Login Successful.");

                    // Show the homepage form
                    this.Hide();
                    homepage home = new homepage();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                // Handle the exception as needed
            }
        }

        private void btnsignuppage_Click(object sender, EventArgs e)
        {
            // Show the signup page form
            Signup signupForm = new Signup();
            signupForm.Show();
            // Optionally, you can hide the current form (signin form)
            // this.Hide();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            // You can implement validation or other logic if needed
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            // You can implement validation or other logic if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Handle label click event if needed
        }

        private void signin_Load(object sender, EventArgs e)
        {
            // You can perform any initialization here if needed
        }
    }
}
