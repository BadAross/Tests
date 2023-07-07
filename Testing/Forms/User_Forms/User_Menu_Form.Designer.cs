namespace Testing.Forms
{
    partial class User_Menu_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Menu_Form));
            this.Name_User_Label = new System.Windows.Forms.Label();
            this.Start_Batton = new System.Windows.Forms.Button();
            this.Statistic_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_User_Label
            // 
            this.Name_User_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Name_User_Label.Location = new System.Drawing.Point(17, 9);
            this.Name_User_Label.Name = "Name_User_Label";
            this.Name_User_Label.Size = new System.Drawing.Size(333, 73);
            this.Name_User_Label.TabIndex = 0;
            this.Name_User_Label.Text = "Здравствуйте, Иванов Иван Иванович!";
            this.Name_User_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start_Batton
            // 
            this.Start_Batton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Start_Batton.FlatAppearance.BorderSize = 2;
            this.Start_Batton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Batton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Start_Batton.Location = new System.Drawing.Point(17, 85);
            this.Start_Batton.Name = "Start_Batton";
            this.Start_Batton.Size = new System.Drawing.Size(333, 38);
            this.Start_Batton.TabIndex = 5;
            this.Start_Batton.Text = "Пройти тест";
            this.Start_Batton.UseVisualStyleBackColor = false;
            this.Start_Batton.Click += new System.EventHandler(this.Start_Batton_Click);
            // 
            // Statistic_Button
            // 
            this.Statistic_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Statistic_Button.FlatAppearance.BorderSize = 2;
            this.Statistic_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Statistic_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Statistic_Button.Location = new System.Drawing.Point(17, 129);
            this.Statistic_Button.Name = "Statistic_Button";
            this.Statistic_Button.Size = new System.Drawing.Size(333, 38);
            this.Statistic_Button.TabIndex = 6;
            this.Statistic_Button.Text = "Статистика";
            this.Statistic_Button.UseVisualStyleBackColor = false;
            this.Statistic_Button.Click += new System.EventHandler(this.Statistic_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Exit_Button.BackgroundImage = global::Testing.Properties.Resources.Back_Image;
            this.Exit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Exit_Button.Location = new System.Drawing.Point(17, 190);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(333, 38);
            this.Exit_Button.TabIndex = 7;
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // User_Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(362, 243);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Statistic_Button);
            this.Controls.Add(this.Start_Batton);
            this.Controls.Add(this.Name_User_Label);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User_Menu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню пользователя";
            this.Load += new System.EventHandler(this.User_Menu_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Start_Batton;
        private System.Windows.Forms.Button Statistic_Button;
        private System.Windows.Forms.Button Exit_Button;
        public System.Windows.Forms.Label Name_User_Label;
    }
}