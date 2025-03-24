using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace System_Overdrive
{
    public partial class Form7 : Form
    {

        public Form7()
        {
            InitializeComponent();
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

        private void NapulakRB_CheckedChanged(object sender, EventArgs e)
        {
            NapulakRB.ForeColor = System.Drawing.Color.Green;
            LobocRB.ForeColor = System.Drawing.Color.Black;
            PanAyRB.ForeColor = System.Drawing.Color.Black;
            MadjaasRB.ForeColor = System.Drawing.Color.Black;

            HikingPackageCB.Items.Clear();
            HikingPackageCB.Items.Add("Napulak Bronze Package");
            HikingPackageCB.Items.Add("Napulak Silver Package");
            HikingPackageCB.Items.Add("Napulak Gold Package");
        }

        private void LobocRB_CheckedChanged(object sender, EventArgs e)
        {
            NapulakRB.ForeColor = System.Drawing.Color.Black;
            LobocRB.ForeColor = System.Drawing.Color.Green;
            PanAyRB.ForeColor = System.Drawing.Color.Black;
            MadjaasRB.ForeColor = System.Drawing.Color.Black;

            HikingPackageCB.Items.Clear();
            HikingPackageCB.Items.Add("Loboc Bronze Package");
            HikingPackageCB.Items.Add("Loboc Silver Package");
            HikingPackageCB.Items.Add("Loboc Gold Package");
        }

        private void PanAyRB_CheckedChanged(object sender, EventArgs e)
        {
            NapulakRB.ForeColor = System.Drawing.Color.Black;
            LobocRB.ForeColor = System.Drawing.Color.Black;
            PanAyRB.ForeColor = System.Drawing.Color.Green;
            MadjaasRB.ForeColor = System.Drawing.Color.Black;

            HikingPackageCB.Items.Clear();
            HikingPackageCB.Items.Add("Pan-Ay Bronze Package");
            HikingPackageCB.Items.Add("Pan-Ay Silver Package");
            HikingPackageCB.Items.Add("Pan-Ay Gold Package");
        }

        private void MadjaasRB_CheckedChanged(object sender, EventArgs e)
        {
            NapulakRB.ForeColor = System.Drawing.Color.Black;
            LobocRB.ForeColor = System.Drawing.Color.Black;
            PanAyRB.ForeColor = System.Drawing.Color.Black;
            MadjaasRB.ForeColor = System.Drawing.Color.Green;

            HikingPackageCB.Items.Clear();
            HikingPackageCB.Items.Add("Madjaas Bronze Package");
            HikingPackageCB.Items.Add("Madjaas Silver Package");
            HikingPackageCB.Items.Add("Madjaas Gold Package");
        }

        private void HikingPackageCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPackage = HikingPackageCB.SelectedItem.ToString();

            switch (selectedPackage)
            {
                case "Napulak Bronze Package":
                    PriceTXT.Text = "1099.00";
                    break;

                case "Napulak Silver Package":
                    PriceTXT.Text = "1399.00";
                    break;

                case "Napulak Gold Package":
                    PriceTXT.Text = "1699.00";
                    break;

                case "Loboc Bronze Package":
                    PriceTXT.Text = "799.00";
                    break;

                case "Loboc Silver Package":
                    PriceTXT.Text = "999.00";
                    break;

                case "Loboc Gold Package":
                    PriceTXT.Text = "1299.00";
                    break;

                case "Pan-Ay Bronze Package":
                    PriceTXT.Text = "599.00";
                    break;

                case "Pan-Ay Silver Package":
                    PriceTXT.Text = "799.00";
                    break;

                case "Pan-Ay Gold Package":
                    PriceTXT.Text = "999.00";
                    break;

                case "Madjaas Bronze Package":
                    PriceTXT.Text = "1499.00";
                    break;

                case "Madjaas Silver Package":
                    PriceTXT.Text = "1799.00";
                    break;

                case "Madjaas Gold Package":
                    PriceTXT.Text = "1999.00";
                    break;

                default:
                    PriceTXT.Text = "0";
                    break;
            }
        }

        private void PayNowBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the last inserted Booking ID (Modify as needed for your logic)
                int bookingID = GetLastBookingID();

                if (bookingID == -1)
                {
                    MessageBox.Show("No active booking found. Please book first.");
                    return;
                }

                string query = "INSERT INTO Payment (BookingID, Mountain, HikingPackage, TotalPrice, PaymentMethod, Address) VALUES (@BID, @MT, @HP, @TP, @PM, @AD)";

                string selectedMountain = GetSelectedMountain();

                using (MySqlConnection con = new MySqlConnection("server=localhost; database=hiking_system; uid=root; pwd=;"))
                {
                    con.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@BID", bookingID);
                        cmd.Parameters.AddWithValue("@MT", selectedMountain);
                        cmd.Parameters.AddWithValue("@HP", HikingPackageCB.Text);

                        if (double.TryParse(PriceTXT.Text, out double totalPrice))
                        {
                            cmd.Parameters.AddWithValue("@TP", totalPrice);
                        }

                        cmd.Parameters.AddWithValue("@PM", PaymentMethodCB.Text);
                        cmd.Parameters.AddWithValue("@AD", AddressTXT.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payment Successful! Thank You.");
                        }
                        else
                        {
                            MessageBox.Show("Payment failed. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting payment: " + ex.Message);
            }
        }

        // Function to get the last inserted Booking ID
        private int GetLastBookingID()
        {
            int bookingID = -1;

            string query = "SELECT id FROM Booking ORDER BY id DESC LIMIT 1";

            using (MySqlConnection con = new MySqlConnection("server=localhost; database=hiking_system; uid=root; pwd=;"))
            {
                con.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        bookingID = Convert.ToInt32(result);
                    }
                }
            }

            return bookingID;
        }


        // Function to get the selected mountain from radio buttons
        private string GetSelectedMountain()
        {
            if (NapulakRB.Checked)
                return "Napulak";
            else if (LobocRB.Checked)
                return "Loboc";
            else if (PanAyRB.Checked)
                return "Pan-Ay";
            else if (MadjaasRB.Checked)
                return "Madjaas";
            else
                return string.Empty; // No radio button selected
        }
    }
}
