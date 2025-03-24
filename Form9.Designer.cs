
namespace System_Overdrive
{
    partial class Form9
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
            this.FirstnameTXT = new System.Windows.Forms.TextBox();
            this.AgeTXT = new System.Windows.Forms.TextBox();
            this.LastnameTXT = new System.Windows.Forms.TextBox();
            this.ConfirmBT = new System.Windows.Forms.Button();
            this.GenderTXT = new System.Windows.Forms.ComboBox();
            this.HikeGuideTXT = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FirstnameTXT
            // 
            this.FirstnameTXT.Location = new System.Drawing.Point(70, 131);
            this.FirstnameTXT.Name = "FirstnameTXT";
            this.FirstnameTXT.Size = new System.Drawing.Size(188, 22);
            this.FirstnameTXT.TabIndex = 0;
            // 
            // AgeTXT
            // 
            this.AgeTXT.Location = new System.Drawing.Point(70, 192);
            this.AgeTXT.Name = "AgeTXT";
            this.AgeTXT.Size = new System.Drawing.Size(188, 22);
            this.AgeTXT.TabIndex = 1;
            // 
            // LastnameTXT
            // 
            this.LastnameTXT.Location = new System.Drawing.Point(312, 131);
            this.LastnameTXT.Name = "LastnameTXT";
            this.LastnameTXT.Size = new System.Drawing.Size(188, 22);
            this.LastnameTXT.TabIndex = 2;
            // 
            // ConfirmBT
            // 
            this.ConfirmBT.BackgroundImage = global::System_Overdrive.Properties.Resources.panel1;
            this.ConfirmBT.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBT.ForeColor = System.Drawing.Color.White;
            this.ConfirmBT.Location = new System.Drawing.Point(406, 314);
            this.ConfirmBT.Name = "ConfirmBT";
            this.ConfirmBT.Size = new System.Drawing.Size(108, 39);
            this.ConfirmBT.TabIndex = 5;
            this.ConfirmBT.Text = "Confirm";
            this.ConfirmBT.UseVisualStyleBackColor = true;
            this.ConfirmBT.Click += new System.EventHandler(this.ConfirmBT_Click);
            // 
            // GenderTXT
            // 
            this.GenderTXT.FormattingEnabled = true;
            this.GenderTXT.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer Not To Say"});
            this.GenderTXT.Location = new System.Drawing.Point(312, 191);
            this.GenderTXT.Name = "GenderTXT";
            this.GenderTXT.Size = new System.Drawing.Size(188, 24);
            this.GenderTXT.TabIndex = 6;
            // 
            // HikeGuideTXT
            // 
            this.HikeGuideTXT.FormattingEnabled = true;
            this.HikeGuideTXT.Items.AddRange(new object[] {
            "Hiker Maet",
            "Hiker Stad",
            "Hiker Kwan",
            "Hiker Cara",
            "Hiker Job",
            "Hiker Tim"});
            this.HikeGuideTXT.Location = new System.Drawing.Point(187, 261);
            this.HikeGuideTXT.Name = "HikeGuideTXT";
            this.HikeGuideTXT.Size = new System.Drawing.Size(188, 24);
            this.HikeGuideTXT.TabIndex = 7;
            // 
            // Form9
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::System_Overdrive.Properties.Resources.Update2;
            this.ClientSize = new System.Drawing.Size(591, 385);
            this.Controls.Add(this.HikeGuideTXT);
            this.Controls.Add(this.GenderTXT);
            this.Controls.Add(this.ConfirmBT);
            this.Controls.Add(this.LastnameTXT);
            this.Controls.Add(this.AgeTXT);
            this.Controls.Add(this.FirstnameTXT);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstnameTXT;
        private System.Windows.Forms.TextBox AgeTXT;
        private System.Windows.Forms.TextBox LastnameTXT;
        private System.Windows.Forms.Button ConfirmBT;
        private System.Windows.Forms.ComboBox GenderTXT;
        private System.Windows.Forms.ComboBox HikeGuideTXT;
    }
}