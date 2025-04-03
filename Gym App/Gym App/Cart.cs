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
    public partial class Cart : Form
    {
        private const string ConnectionString = ""; // add your connection string here. Removed for privacy reasons.

        public Cart()
        {
            InitializeComponent();
            LoadCartItems();
        }

        private void LoadCartItems()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT * FROM CartTable", connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void total_Click(object sender, EventArgs e)
        {
            decimal totalPrice = GetTotalCartPrice();

            // Display the total price 
            MessageBox.Show($"Total : Rs {totalPrice:N}");
        }

        private decimal GetTotalCartPrice()
        {
            // calculate the total price
            string sqlSelect = "SELECT SUM(Price) FROM CartTable;";

            // connection to the SQL Server
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    
                    connection.Open();

                   
                    using (SqlCommand command = new SqlCommand(sqlSelect, connection))
                    {
                        object result = command.ExecuteScalar();

                        
                        if (result != DBNull.Value)
                        {
                            return Convert.ToDecimal(result);
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return 0; 
                }
            }
        }

        private void ext3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment_Portal PaymentForm = new Payment_Portal();
            PaymentForm.FormClosed += (s, args) => this.Show();
            PaymentForm.Show();
        }
    }
}

