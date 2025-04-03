using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_App
{
    public partial class Login : Form
    {
        private const string ConnectionString = ""; // add your connection string here. Removed for privacy reasons.
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ext1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void log_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text;
            string password = password_txt.Text;
            if (AuthenticateUser(username, password, ConnectionString))
            {
                this.Hide();
                Dashboard dashboardForm = new Dashboard();//show dashboard
                dashboardForm.FormClosed += (s, args) => this.Show();
                dashboardForm.Show();

            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private bool AuthenticateUser(string username, string password, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // check if the username and password are correct
                    string sqlQuery = "SELECT COUNT(*) FROM Members WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false; // Return false on error
                }
            }

        }

        private void rgstr_Click(object sender, EventArgs e)
        {
            this.Hide();//to hide login form
            Registration registrationForm = new Registration();
            registrationForm.FormClosed += (s, args) => { this.Show(); };// to bring back login form
            registrationForm.Show();
        }
    }
}