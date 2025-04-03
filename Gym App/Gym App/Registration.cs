using MaterialSkin.Controls;
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
using System.Net;
using System.Net.Mail;

namespace Gym_App
{
    public partial class Registration : MaterialForm
    {
        string connectionString = ""; // add your connection string here. Removed for privacy reasons.

        public Registration()
        {
            InitializeComponent();
        }

        private void regis_Click(object sender, EventArgs e)
        {
            string fullName = fullnm.Text;
            string username = usernm.Text;
            string password = pwd.Text;
            string email = email1.Text;
            string phoneNo = phno.Text;
            string gender = gndr.SelectedItem?.ToString(); // Check if selectedItem is null

            // List to keep track of empty fields
            List<string> emptyFields = new List<string>();

            // Validate each field
            if (string.IsNullOrWhiteSpace(fullName))
            {
                emptyFields.Add("Full Name");
            }
            if (string.IsNullOrWhiteSpace(username))
            {
                emptyFields.Add("Username");
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                emptyFields.Add("Password");
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                emptyFields.Add("Email");
            }
            if (string.IsNullOrWhiteSpace(phoneNo))
            {
                emptyFields.Add("Phone Number");
            }
            if (gender == null)
            {
                emptyFields.Add("Gender");
            }

            // If any field is blank, show error message
            if (emptyFields.Any())
            {
                string errorMessage = $"Please fill in the following fields: {string.Join(", ", emptyFields)}";
                MessageBox.Show(errorMessage);
                return;
            }

            // Validate name without numbers
            if (ContainsNumbers(fullName))
            {
                MessageBox.Show("Name should not contain numbers.");
                return;
            }

            // Validate phone number
            if (!IsNumeric(phoneNo) || phoneNo.Length != 10 || ContainsLetters(phoneNo))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number without letters.");
                return;
            }

            // Validate email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // Check if the username already exists in the database
            if (IsUsernameExists(username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // connection open

                    // insert data into the Members table
                    string sqlInsert = "INSERT INTO Members (FullName, Username, Password, Email, PhoneNo, Gender) " +
                                       "VALUES (@FullName, @Username, @Password, @Email, @PhoneNo, @Gender)";

                    using (SqlCommand cmd = new SqlCommand(sqlInsert, connection))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@PhoneNo", int.Parse(phoneNo));
                        cmd.Parameters.AddWithValue("@Gender", gender);

                        // Execute the command
                        cmd.ExecuteNonQuery();

                        // Send registration success email
                        SendRegistrationEmail(email);

                        MessageBox.Show("Registration successful!");

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void SendRegistrationEmail(string recipientEmail)
        {
            string senderEmail = "ddddyj23@gmail.com";
            string appPassword = "enbs culo fqzu arfy"; // Use the app password generated from your Google Account
            string subject = "Registration Successful";
            string body = "Thank you for registering with our gym. Your registration was successful.";

            MailMessage mail = new MailMessage(senderEmail, recipientEmail, subject, body);
            SmtpClient client = new SmtpClient("smtp.gmail.com");

            client.Port = 587;
            client.Credentials = new NetworkCredential(senderEmail, appPassword); // Use the app password here
            client.EnableSsl = true;

            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
            }
        }

        private void back1_Click(object sender, EventArgs e)
        {
            this.Close(); // closes the registration form
        }

        private bool IsNumeric(string value)
        {
            return int.TryParse(value, out _);
        }

        private bool IsValidEmail(string email)
        {
            return email.Contains("@") && email.Contains(".com");
        }

        private bool ContainsNumbers(string value)
        {
            return value.Any(char.IsDigit);
        }

        private bool ContainsLetters(string value)
        {
            return value.Any(char.IsLetter);
        }

        private bool IsUsernameExists(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlCheckUsername = "SELECT COUNT(*) FROM Members WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(sqlCheckUsername, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
