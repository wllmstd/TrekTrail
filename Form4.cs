using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;


namespace System_Overdrive
{
    public partial class Form4 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;

        public Form4()
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

        private void button6_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO booking (firstname, lastname, age, datenow, gender, hikeguide) VALUES (@FN, @LN, @AG, @DN, @GD, @HG)";

            con = new MySqlConnection("server=localhost;database=hiking_system;uid=root;pwd=;");
            cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@FN", FirstNameTXT.Text);
            cmd.Parameters.AddWithValue("@LN", LastNameTXT.Text);

            int age;
            if (int.TryParse(AgeTXT.Text, out age))
            {
                cmd.Parameters.AddWithValue("@AG", age);
            }
            else
            {
                MessageBox.Show("Invalid Age!");
                return;
            }

            DateTime dateNow;
            if (DateTime.TryParse(DateNowTXT.Text, out dateNow))
            {
                cmd.Parameters.AddWithValue("@DN", dateNow);
            }
            else
            {
                MessageBox.Show("Invalid Date!");
                return;
            }

            cmd.Parameters.AddWithValue("@GD", GenderTXT.Text);
            cmd.Parameters.AddWithValue("@HG", HikeGuideTXT.Text);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Booking Successful!");

                this.Hide();
                Form7 form7 = new Form7();
                form7.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
