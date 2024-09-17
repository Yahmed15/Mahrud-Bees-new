using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mahrud_Bees
{
    public partial class Signup : Form
    {
        DBAccess objDBAccess = new DBAccess();
        string connectionString = "Data Source=DESKTOP-OGOHV4F\\SQLEXPRESS01;Initial Catalog=Bees;Integrated Security=True"; 

        public Signup()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Implement your logic here if needed
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Implement your logic here if needed
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Implement your logic here if needed
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            string username = txtname.Text;
            string useremail = txtemail.Text;
            string userpassword = txtpassword.Text;

            if (username.Equals(""))
            {
                MessageBox.Show("Please enter your Name.");
            }
            else if (useremail.Equals(""))
            {
                MessageBox.Show("Please enter your Email.");
            }
            else if (userpassword.Equals(""))
            {
                MessageBox.Show("Please enter your Password.");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Users(Name, Email, Password) VALUES (@username, @useremail, @userpassword)";

                    using (SqlCommand insertCommand = new SqlCommand(query, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@username", username);
                        insertCommand.Parameters.AddWithValue("@useremail", useremail);
                        insertCommand.Parameters.AddWithValue("@userpassword", userpassword);

                        try
                        {
                            connection.Open();
                            int result = insertCommand.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Account Created Successfully.");

                                // Show the homepage form
                                this.Hide();
                                homepage home = new homepage();
                                home.Show();
                            }
                            else
                            {
                                MessageBox.Show("Error Occurred. Try Again.");
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("SQL Error: " + ex.Message);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void btnsigninpage_Click(object sender, EventArgs e)
        {
            // Show the signin page form
            signin signinForm = new signin();
            signinForm.Show();
            this.Hide();
            // Optionally, you can hide the current form (signin form)
            // this.Hide();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
    }
}
