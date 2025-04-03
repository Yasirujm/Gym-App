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

namespace Gym_App
{
    public partial class FAQs : MaterialForm
    {
        
        private const string connectionString = ""; // add your connection string here. Removed for privacy reasons.

        public FAQs()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string userInput = faqtxt.Text;

            // Validate if the user input is not empty
            if (string.IsNullOrEmpty(userInput))
            {
                MessageBox.Show("Please enter a question before submitting.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert the user input
                    string insertQuery = "INSERT INTO faqs (Questions) VALUES (@Question)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Question", userInput);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Question submitted successfully!");
                            faqtxt.Clear(); // Clear the TextBox 
                        }
                        
                    }
                }
            }
            catch (Exception /*ex*/)
            {
                //no need failure 
            }
        }

        private void bck2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
