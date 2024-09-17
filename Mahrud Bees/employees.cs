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
    public partial class employees : Form
    {
        public employees()
        {
            InitializeComponent();
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

        private void btnhomepage_Click(object sender, EventArgs e)
        {
            // Show the homepage form
            this.Hide();
            homepage home = new homepage();
            home.Show();
        }
    }
}
