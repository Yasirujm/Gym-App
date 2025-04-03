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
    public partial class Shop : MaterialForm
    {
        private const string connectionString = ""; // add your connection string here. Removed for privacy reasons.

        public Shop()
        {
            InitializeComponent();


        }

        private void vcart_Click(object sender, EventArgs e)
        {
            Cart CartForm = new Cart();
            CartForm.FormClosed += (s, args) => { this.Show(); }; // to bring back the Shop form
            CartForm.Show();
        }

        private void buy_Click(object sender, EventArgs e)
        {
            // insert a new row into CartTable
            string sqlInsert = "INSERT INTO CartTable (ItemID, ItemName, Quantity, Price) VALUES ('1', 'Weights', '1', '390');";

            // Establish a connection to the SQL Server
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create a command object
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        // Execute the command
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Item added to the cart successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buy2_Click(object sender, EventArgs e)
        {
            string sqlInsert = "INSERT INTO CartTable (ItemID, ItemName, Quantity, Price) VALUES ('2', 'Dumbell Bar', '1', '1500');";

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Item added to the cart successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buy3_Click(object sender, EventArgs e)
        {
            string sqlInsert = "INSERT INTO CartTable (ItemID, ItemName, Quantity, Price) VALUES ('3', 'Bench Press', '1', '34000');";

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Item added to the cart successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buy4_Click(object sender, EventArgs e)
        {
            string sqlInsert = "INSERT INTO CartTable (ItemID, ItemName, Quantity, Price) VALUES ('4', 'Gym Ball', '1', '2800');";

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Item added to the cart successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buy5_Click(object sender, EventArgs e)
        {
            string sqlInsert = "INSERT INTO CartTable (ItemID, ItemName, Quantity, Price) VALUES ('5', 'Barbell Bar', '1', '4500');";

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                       
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Item added to the cart successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void clearc_Click(object sender, EventArgs e)
        {
            // delete all rows from CartTable
            string sqlDelete = "DELETE FROM CartTable;";

            // Establish a connection to the SQL Server
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();

                    
                    using (SqlCommand command = new SqlCommand(sqlDelete, connection))
                    {
                        
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cart cleared successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void back1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
