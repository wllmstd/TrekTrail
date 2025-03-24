using System;
using System.Data;
using MySql.Data.MySqlClient; // Use MySQL instead of OleDb
using System.Windows.Forms;
using System_Overdrive;

namespace System_Overdrive
{
    public partial class Form6 : Form
    {
        // Declare class-level variables
        private MySqlConnection con;
        private MySqlCommand cmd;

        private string connectionString; // Move the connectionString variable here

        public Form6()
        {
            InitializeComponent();
            // Initialize the connectionString variable
            connectionString = "server=localhost; database=hiking_system; uid=root; pwd=;";

        }


        private void HomeBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void UserProfileBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void BookingBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void LocalGuidesBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void TravelTipsBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void LogOutBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form6_Load_1(object sender, EventArgs e)
        {
            // Call a method to populate the DataGridView with the query results
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    DataTable dt = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM booking", con)) // Update table name
                    {
                        con.Open();
                        adapter.Fill(dt);
                    }

                    dataGridView1.DataSource = dt;
                    dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }
        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                string bookingIDToDelete = dataGridView1.Rows[rowIndex].Cells["id"].Value.ToString(); // ✅ Use `id` (from booking table)

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    // ✅ FIX: Use correct column `BookingID` in `payment` table
                    string paymentQuery = "SELECT id FROM payment WHERE BookingID = @bookingID";
                    using (MySqlCommand paymentCmd = new MySqlCommand(paymentQuery, con))
                    {
                        paymentCmd.Parameters.AddWithValue("@bookingID", bookingIDToDelete);
                        object paymentID = paymentCmd.ExecuteScalar();

                        if (paymentID != null && paymentID != DBNull.Value)
                        {
                            string deletePaymentQuery = "DELETE FROM payment WHERE id = @paymentID";
                            using (MySqlCommand deletePaymentCmd = new MySqlCommand(deletePaymentQuery, con))
                            {
                                deletePaymentCmd.Parameters.AddWithValue("@paymentID", paymentID);
                                deletePaymentCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // ✅ FIX: Correct `id` column for `booking` table
                    string deleteBookingQuery = "DELETE FROM booking WHERE id = @bookingID";
                    using (MySqlCommand deleteBookingCmd = new MySqlCommand(deleteBookingQuery, con))
                    {
                        deleteBookingCmd.Parameters.AddWithValue("@bookingID", bookingIDToDelete);
                        int rowsAffected = deleteBookingCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Delete Success!");
                            LoadData(); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No records deleted. Make sure the record exists.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }



        private void UpdateBT_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                this.Hide();
                Form9 form9 = new Form9(dataGridView1);
                form9.UpdatePerformed += Form9_UpdatePerformed;
                form9.Show();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void Form9_UpdatePerformed(object sender, EventArgs e)
        {
            LoadData(); // Refresh DataGridView after update
        }
    }


}



