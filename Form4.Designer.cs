
namespace System_Overdrive
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogOutBT = new System.Windows.Forms.Button();
            this.UserProfileBT = new System.Windows.Forms.Button();
            this.TravelTipsBT = new System.Windows.Forms.Button();
            this.LocalGuidesBT = new System.Windows.Forms.Button();
            this.BookingBT = new System.Windows.Forms.Button();
            this.HomeBT = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.HikeGuideTXT = new System.Windows.Forms.ComboBox();
            this.LastNameTXT = new System.Windows.Forms.TextBox();
            this.FirstNameTXT = new System.Windows.Forms.TextBox();
            this.GenderTXT = new System.Windows.Forms.ComboBox();
            this.DateNowTXT = new System.Windows.Forms.DateTimePicker();
            this.AgeTXT = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogOutBT
            // 
            this.LogOutBT.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBT.Location = new System.Drawing.Point(17, 481);
            this.LogOutBT.Name = "LogOutBT";
            this.LogOutBT.Size = new System.Drawing.Size(142, 45);
            this.LogOutBT.TabIndex = 23;
            this.LogOutBT.Text = "LogOut";
            this.LogOutBT.UseVisualStyleBackColor = true;
            this.LogOutBT.Click += new System.EventHandler(this.LogOutBT_Click);
            // 
            // UserProfileBT
            // 
            this.UserProfileBT.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserProfileBT.Location = new System.Drawing.Point(17, 150);
            this.UserProfileBT.Name = "UserProfileBT";
            this.UserProfileBT.Size = new System.Drawing.Size(142, 40);
            this.UserProfileBT.TabIndex = 22;
            this.UserProfileBT.Text = "User Profile";
            this.UserProfileBT.UseVisualStyleBackColor = true;
            this.UserProfileBT.Click += new System.EventHandler(this.UserProfileBT_Click);
            // 
            // TravelTipsBT
            // 
            this.TravelTipsBT.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TravelTipsBT.Location = new System.Drawing.Point(17, 325);
            this.TravelTipsBT.Name = "TravelTipsBT";
            this.TravelTipsBT.Size = new System.Drawing.Size(142, 40);
            this.TravelTipsBT.TabIndex = 21;
            this.TravelTipsBT.Text = "History";
            this.TravelTipsBT.UseVisualStyleBackColor = true;
            this.TravelTipsBT.Click += new System.EventHandler(this.TravelTipsBT_Click);
            // 
            // LocalGuidesBT
            // 
            this.LocalGuidesBT.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalGuidesBT.Location = new System.Drawing.Point(17, 266);
            this.LocalGuidesBT.Name = "LocalGuidesBT";
            this.LocalGuidesBT.Size = new System.Drawing.Size(142, 40);
            this.LocalGuidesBT.TabIndex = 20;
            this.LocalGuidesBT.Text = "Local Guides";
            this.LocalGuidesBT.UseVisualStyleBackColor = true;
            this.LocalGuidesBT.Click += new System.EventHandler(this.LocalGuidesBT_Click);
            // 
            // BookingBT
            // 
            this.BookingBT.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingBT.Location = new System.Drawing.Point(17, 207);
            this.BookingBT.Name = "BookingBT";
            this.BookingBT.Size = new System.Drawing.Size(142, 40);
            this.BookingBT.TabIndex = 19;
            this.BookingBT.Text = "Booking";
            this.BookingBT.UseVisualStyleBackColor = true;
            // 
            // HomeBT
            // 
            this.HomeBT.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBT.Location = new System.Drawing.Point(17, 93);
            this.HomeBT.Name = "HomeBT";
            this.HomeBT.Size = new System.Drawing.Size(142, 40);
            this.HomeBT.TabIndex = 17;
            this.HomeBT.Text = "Home";
            this.HomeBT.UseVisualStyleBackColor = true;
            this.HomeBT.Click += new System.EventHandler(this.HomeBT_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::System_Overdrive.Properties.Resources.panel;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(670, 481);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 45);
            this.button6.TabIndex = 66;
            this.button6.Text = "Proceed Payment";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // HikeGuideTXT
            // 
            this.HikeGuideTXT.FormattingEnabled = true;
            this.HikeGuideTXT.Items.AddRange(new object[] {
            "Hiker Stad",
            "Hiker Maet",
            "Hiker Cara",
            "Hiker Job",
            "Hiker Kwan",
            "Hiker Tim"});
            this.HikeGuideTXT.Location = new System.Drawing.Point(257, 411);
            this.HikeGuideTXT.Name = "HikeGuideTXT";
            this.HikeGuideTXT.Size = new System.Drawing.Size(225, 24);
            this.HikeGuideTXT.TabIndex = 65;
            // 
            // LastNameTXT
            // 
            this.LastNameTXT.Location = new System.Drawing.Point(577, 229);
            this.LastNameTXT.Name = "LastNameTXT";
            this.LastNameTXT.Size = new System.Drawing.Size(225, 22);
            this.LastNameTXT.TabIndex = 60;
            // 
            // FirstNameTXT
            // 
            this.FirstNameTXT.Location = new System.Drawing.Point(257, 228);
            this.FirstNameTXT.Name = "FirstNameTXT";
            this.FirstNameTXT.Size = new System.Drawing.Size(225, 22);
            this.FirstNameTXT.TabIndex = 58;
            // 
            // GenderTXT
            // 
            this.GenderTXT.FormattingEnabled = true;
            this.GenderTXT.Items.AddRange(new object[] {
            "Male ",
            "Female",
            "Prefer Not To Say"});
            this.GenderTXT.Location = new System.Drawing.Point(577, 320);
            this.GenderTXT.Name = "GenderTXT";
            this.GenderTXT.Size = new System.Drawing.Size(225, 24);
            this.GenderTXT.TabIndex = 56;
            // 
            // DateNowTXT
            // 
            this.DateNowTXT.Location = new System.Drawing.Point(575, 413);
            this.DateNowTXT.Name = "DateNowTXT";
            this.DateNowTXT.Size = new System.Drawing.Size(225, 22);
            this.DateNowTXT.TabIndex = 54;
            // 
            // AgeTXT
            // 
            this.AgeTXT.Location = new System.Drawing.Point(257, 322);
            this.AgeTXT.Name = "AgeTXT";
            this.AgeTXT.Size = new System.Drawing.Size(225, 22);
            this.AgeTXT.TabIndex = 68;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::System_Overdrive.Properties.Resources.navbar1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 551);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::System_Overdrive.Properties.Resources.Booking;
            this.ClientSize = new System.Drawing.Size(866, 548);
            this.Controls.Add(this.AgeTXT);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.HikeGuideTXT);
            this.Controls.Add(this.LastNameTXT);
            this.Controls.Add(this.FirstNameTXT);
            this.Controls.Add(this.GenderTXT);
            this.Controls.Add(this.DateNowTXT);
            this.Controls.Add(this.LogOutBT);
            this.Controls.Add(this.UserProfileBT);
            this.Controls.Add(this.TravelTipsBT);
            this.Controls.Add(this.LocalGuidesBT);
            this.Controls.Add(this.BookingBT);
            this.Controls.Add(this.HomeBT);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Booking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LogOutBT;
        private System.Windows.Forms.Button UserProfileBT;
        private System.Windows.Forms.Button TravelTipsBT;
        private System.Windows.Forms.Button LocalGuidesBT;
        private System.Windows.Forms.Button BookingBT;
        private System.Windows.Forms.Button HomeBT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox HikeGuideTXT;
        private System.Windows.Forms.TextBox LastNameTXT;
        private System.Windows.Forms.TextBox FirstNameTXT;
        private System.Windows.Forms.ComboBox GenderTXT;
        private System.Windows.Forms.DateTimePicker DateNowTXT;
        private System.Windows.Forms.TextBox AgeTXT;
    }
}