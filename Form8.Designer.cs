
namespace System_Overdrive
{
    partial class Form8
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogOutBT = new System.Windows.Forms.Button();
            this.UserProfileBT = new System.Windows.Forms.Button();
            this.TravelTipsBT = new System.Windows.Forms.Button();
            this.LocalGuidesBT = new System.Windows.Forms.Button();
            this.BookingBT = new System.Windows.Forms.Button();
            this.HomeBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::System_Overdrive.Properties.Resources.navbar1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 551);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LogOutBT
            // 
            this.LogOutBT.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBT.Location = new System.Drawing.Point(17, 481);
            this.LogOutBT.Name = "LogOutBT";
            this.LogOutBT.Size = new System.Drawing.Size(142, 45);
            this.LogOutBT.TabIndex = 13;
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
            this.UserProfileBT.TabIndex = 12;
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
            this.TravelTipsBT.TabIndex = 11;
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
            this.LocalGuidesBT.TabIndex = 10;
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
            this.BookingBT.TabIndex = 9;
            this.BookingBT.Text = "Booking";
            this.BookingBT.UseVisualStyleBackColor = true;
            this.BookingBT.Click += new System.EventHandler(this.BookingBT_Click);
            // 
            // HomeBT
            // 
            this.HomeBT.BackColor = System.Drawing.Color.White;
            this.HomeBT.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBT.Location = new System.Drawing.Point(17, 93);
            this.HomeBT.Name = "HomeBT";
            this.HomeBT.Size = new System.Drawing.Size(142, 40);
            this.HomeBT.TabIndex = 8;
            this.HomeBT.Text = "Home";
            this.HomeBT.UseVisualStyleBackColor = false;
            this.HomeBT.Click += new System.EventHandler(this.HomeBT_Click);
            // 
            // Form8
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::System_Overdrive.Properties.Resources._10;
            this.ClientSize = new System.Drawing.Size(866, 548);
            this.Controls.Add(this.LogOutBT);
            this.Controls.Add(this.UserProfileBT);
            this.Controls.Add(this.TravelTipsBT);
            this.Controls.Add(this.LocalGuidesBT);
            this.Controls.Add(this.BookingBT);
            this.Controls.Add(this.HomeBT);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form8";
            this.Text = "Hiker Guide Profile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LogOutBT;
        private System.Windows.Forms.Button UserProfileBT;
        private System.Windows.Forms.Button TravelTipsBT;
        private System.Windows.Forms.Button LocalGuidesBT;
        private System.Windows.Forms.Button BookingBT;
        private System.Windows.Forms.Button HomeBT;
    }
}