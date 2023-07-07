namespace Testing.Forms.Admin
{
    partial class Admin_Menu_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Menu_Form));
            this.Uzers_Button = new System.Windows.Forms.Button();
            this.Results_Button = new System.Windows.Forms.Button();
            this.Tests_Button = new System.Windows.Forms.Button();
            this.Testers_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Uzers_Button
            // 
            this.Uzers_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(44)))));
            this.Uzers_Button.FlatAppearance.BorderSize = 2;
            this.Uzers_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Uzers_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Uzers_Button.Location = new System.Drawing.Point(12, 12);
            this.Uzers_Button.Name = "Uzers_Button";
            this.Uzers_Button.Size = new System.Drawing.Size(332, 38);
            this.Uzers_Button.TabIndex = 7;
            this.Uzers_Button.Text = "Пользователи";
            this.Uzers_Button.UseVisualStyleBackColor = false;
            this.Uzers_Button.Click += new System.EventHandler(this.Uzers_Button_Click);
            // 
            // Results_Button
            // 
            this.Results_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(44)))));
            this.Results_Button.FlatAppearance.BorderSize = 2;
            this.Results_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Results_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Results_Button.Location = new System.Drawing.Point(12, 144);
            this.Results_Button.Name = "Results_Button";
            this.Results_Button.Size = new System.Drawing.Size(332, 38);
            this.Results_Button.TabIndex = 9;
            this.Results_Button.Text = "Результаты тестирования";
            this.Results_Button.UseVisualStyleBackColor = false;
            this.Results_Button.Click += new System.EventHandler(this.Results_Button_Click);
            // 
            // Tests_Button
            // 
            this.Tests_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(44)))));
            this.Tests_Button.FlatAppearance.BorderSize = 2;
            this.Tests_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tests_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Tests_Button.Location = new System.Drawing.Point(12, 100);
            this.Tests_Button.Name = "Tests_Button";
            this.Tests_Button.Size = new System.Drawing.Size(332, 38);
            this.Tests_Button.TabIndex = 10;
            this.Tests_Button.Text = "Тесты";
            this.Tests_Button.UseVisualStyleBackColor = false;
            this.Tests_Button.Click += new System.EventHandler(this.Tests_Button_Click);
            // 
            // Testers_Button
            // 
            this.Testers_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(44)))));
            this.Testers_Button.FlatAppearance.BorderSize = 2;
            this.Testers_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Testers_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Testers_Button.Location = new System.Drawing.Point(12, 56);
            this.Testers_Button.Name = "Testers_Button";
            this.Testers_Button.Size = new System.Drawing.Size(332, 38);
            this.Testers_Button.TabIndex = 11;
            this.Testers_Button.Text = "Тестеры";
            this.Testers_Button.UseVisualStyleBackColor = false;
            this.Testers_Button.Click += new System.EventHandler(this.Testers_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(44)))));
            this.Exit_Button.BackgroundImage = global::Testing.Properties.Resources.Back_Image;
            this.Exit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Exit_Button.Location = new System.Drawing.Point(12, 217);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(332, 38);
            this.Exit_Button.TabIndex = 12;
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Admin_Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(356, 274);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Testers_Button);
            this.Controls.Add(this.Tests_Button);
            this.Controls.Add(this.Results_Button);
            this.Controls.Add(this.Uzers_Button);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_Menu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Uzers_Button;
        private System.Windows.Forms.Button Results_Button;
        private System.Windows.Forms.Button Tests_Button;
        private System.Windows.Forms.Button Testers_Button;
        private System.Windows.Forms.Button Exit_Button;
    }
}