using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace System_Overdrive
{
    public partial class Form9 : Form
    {
        private DataGridView dataGridView1;
        public event EventHandler UpdatePerformed;
        private string connectionString = "server=localhost; database=hiking_system; user=root; password=;";

        private string SelectedBookingID { get; set; }

        public Form9(DataGridView dataGridView)
        {
            InitializeComponent();
            dataGridView1 = dataGridView;
        }

        private void LoadExistingData()
        {
            if (dataGridView1 != null && dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                SelectedBookingID = dataGridView1.Rows[rowIndex].Cells["id"].Value.ToString(); // ✅ Correct column name

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    // ✅ Change "BookingID" to "id"
                    string selectQuery = "SELECT * FROM booking WHERE id = @bookingID";

                    using (MySqlCommand selectCmd = new MySqlCommand(selectQuery, con))
                    {
                        selectCmd.Parameters.AddWithValue("@bookingID", SelectedBookingID);

                        using (MySqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // ✅ Match field names exactly as in MySQL
                                FirstnameTXT.Text = reader["firstname"].ToString();
                                LastnameTXT.Text = reader["lastname"].ToString();
                                AgeTXT.Text = reader["age"].ToString();
                                GenderTXT.Text = reader["gender"].ToString();
                                HikeGuideTXT.Text = reader["hikeguide"].ToString();
                            }
                        }
                    }
                }
            }
        }

        private void ConfirmBT_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null && dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        con.Open();

                        // ✅ Corrected column names and condition
                        string updateQuery = "UPDATE booking SET firstname = @firstName, lastname = @lastName, age = @age, gender = @gender, hikeguide = @hikeGuide WHERE id = @bookingID";

                        using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@firstName", FirstnameTXT.Text);
                            updateCmd.Parameters.AddWithValue("@lastName", LastnameTXT.Text);

                            // ✅ Convert Age to an integer
                            int ageValue;
                            if (!int.TryParse(AgeTXT.Text, out ageValue))
                            {
                                MessageBox.Show("Please enter a valid number for Age.");
                                return;
                            }
                            updateCmd.Parameters.AddWithValue("@age", ageValue);

                            updateCmd.Parameters.AddWithValue("@gender", GenderTXT.Text);
                            updateCmd.Parameters.AddWithValue("@hikeGuide", HikeGuideTXT.Text);
                            updateCmd.Parameters.AddWithValue("@bookingID", SelectedBookingID);

                            int rowsAffected = updateCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Update Success!");
                                UpdatePerformed?.Invoke(this, EventArgs.Empty); // ✅ Trigger DataGridView update
                            }
                            else
                            {
                                MessageBox.Show("No records updated. Make sure the record exists.");
                            }
                        }
                    }

                    this.Close();
                    Form6 form6 = new Form6();
                    form6.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating record: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }


        private void Form9_Load_1(object sender, EventArgs e)
        {
            LoadExistingData();
        }
    }
}
