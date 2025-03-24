using System;
using System.Windows.Forms;

namespace System_Overdrive
{
    public partial class Form0 : Form
    {
        private Timer timer;
        private int progressValue = 0;

        public Form0()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 10; // Set the interval in milliseconds
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressValue += 1;
            progressBar1.Value = progressValue;

            if (progressValue >= progressBar1.Maximum)
            {
                timer.Stop();
                MessageBox.Show("Process completed!");

                // Proceed to Form1
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }

        private void Form0_Load(object sender, EventArgs e)
        {
            // Start the timer when the form loads
            timer.Start();
        }


    }
}
