namespace Testing.Forms.General
{
    partial class Registration_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_Form));
            this.Generat_Password_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.Registration_Button = new System.Windows.Forms.Button();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.Pawwsord_Label = new System.Windows.Forms.Label();
            this.Login_TextBox = new System.Windows.Forms.TextBox();
            this.Login_Label = new System.Windows.Forms.Label();
            this.Full_Name_TextBox = new System.Windows.Forms.TextBox();
            this.Full_Name_Label = new System.Windows.Forms.Label();
            this.Tester_RadioButton = new System.Windows.Forms.RadioButton();
            this.User_RadioButton = new System.Windows.Forms.RadioButton();
            this.Group_ComboBox = new System.Windows.Forms.ComboBox();
            this.Group_Label = new System.Windows.Forms.Label();
            this.Info_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Generat_Password_Button
            // 
            this.Generat_Password_Button.BackgroundImage = global::Testing.Properties.Resources.Generate_Password_Image;
            this.Generat_Password_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Generat_Password_Button.FlatAppearance.BorderSize = 0;
            this.Generat_Password_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generat_Password_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Generat_Password_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Generat_Password_Button.Location = new System.Drawing.Point(387, 165);
            this.Generat_Password_Button.Name = "Generat_Password_Button";
            this.Generat_Password_Button.Size = new System.Drawing.Size(35, 33);
            this.Generat_Password_Button.TabIndex = 14;
            this.Info_ToolTip.SetToolTip(this.Generat_Password_Button, "Сгенерировать пароль");
            this.Generat_Password_Button.UseVisualStyleBackColor = true;
            this.Generat_Password_Button.Click += new System.EventHandler(this.Generat_Password_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.FlatAppearance.BorderSize = 2;
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Close_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Close_Button.Location = new System.Drawing.Point(230, 306);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(192, 38);
            this.Close_Button.TabIndex = 13;
            this.Close_Button.Text = "Отмена";
            this.Info_ToolTip.SetToolTip(this.Close_Button, "Отменить регистрация");
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Registration_Button
            // 
            this.Registration_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Registration_Button.FlatAppearance.BorderSize = 2;
            this.Registration_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registration_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Registration_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Registration_Button.Location = new System.Drawing.Point(12, 306);
            this.Registration_Button.Name = "Registration_Button";
            this.Registration_Button.Size = new System.Drawing.Size(192, 38);
            this.Registration_Button.TabIndex = 12;
            this.Registration_Button.Text = "Регистрация";
            this.Info_ToolTip.SetToolTip(this.Registration_Button, "Зарегистрировать новый аккаунт");
            this.Registration_Button.UseVisualStyleBackColor = false;
            this.Registration_Button.Click += new System.EventHandler(this.Registration_Button_Click);
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Password_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Password_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Password_TextBox.Location = new System.Drawing.Point(12, 165);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(370, 33);
            this.Password_TextBox.TabIndex = 11;
            this.Info_ToolTip.SetToolTip(this.Password_TextBox, "Введите пароль");
            // 
            // Pawwsord_Label
            // 
            this.Pawwsord_Label.AutoSize = true;
            this.Pawwsord_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Pawwsord_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Pawwsord_Label.Location = new System.Drawing.Point(12, 137);
            this.Pawwsord_Label.Name = "Pawwsord_Label";
            this.Pawwsord_Label.Size = new System.Drawing.Size(84, 25);
            this.Pawwsord_Label.TabIndex = 10;
            this.Pawwsord_Label.Text = "Пароль:";
            // 
            // Login_TextBox
            // 
            this.Login_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Login_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Login_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Login_TextBox.Location = new System.Drawing.Point(12, 101);
            this.Login_TextBox.Name = "Login_TextBox";
            this.Login_TextBox.Size = new System.Drawing.Size(410, 33);
            this.Login_TextBox.TabIndex = 9;
            this.Info_ToolTip.SetToolTip(this.Login_TextBox, "Введите логин");
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Login_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Login_Label.Location = new System.Drawing.Point(12, 73);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(71, 25);
            this.Login_Label.TabIndex = 8;
            this.Login_Label.Text = "Логин:";
            // 
            // Full_Name_TextBox
            // 
            this.Full_Name_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Full_Name_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Full_Name_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Full_Name_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Full_Name_TextBox.Location = new System.Drawing.Point(12, 37);
            this.Full_Name_TextBox.Name = "Full_Name_TextBox";
            this.Full_Name_TextBox.Size = new System.Drawing.Size(410, 33);
            this.Full_Name_TextBox.TabIndex = 16;
            this.Info_ToolTip.SetToolTip(this.Full_Name_TextBox, "Введите свои ФИО");
            // 
            // Full_Name_Label
            // 
            this.Full_Name_Label.AutoSize = true;
            this.Full_Name_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Full_Name_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Full_Name_Label.Location = new System.Drawing.Point(12, 9);
            this.Full_Name_Label.Name = "Full_Name_Label";
            this.Full_Name_Label.Size = new System.Drawing.Size(61, 25);
            this.Full_Name_Label.TabIndex = 15;
            this.Full_Name_Label.Text = "ФИО:";
            // 
            // Tester_RadioButton
            // 
            this.Tester_RadioButton.AutoSize = true;
            this.Tester_RadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Tester_RadioButton.Location = new System.Drawing.Point(249, 271);
            this.Tester_RadioButton.Name = "Tester_RadioButton";
            this.Tester_RadioButton.Size = new System.Drawing.Size(86, 29);
            this.Tester_RadioButton.TabIndex = 17;
            this.Tester_RadioButton.TabStop = true;
            this.Tester_RadioButton.Text = "Тестер";
            this.Info_ToolTip.SetToolTip(this.Tester_RadioButton, "Тип аккаунта: Тестер");
            this.Tester_RadioButton.UseVisualStyleBackColor = true;
            this.Tester_RadioButton.CheckedChanged += new System.EventHandler(this.Tester_RadioButton_CheckedChanged);
            // 
            // User_RadioButton
            // 
            this.User_RadioButton.AutoSize = true;
            this.User_RadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.User_RadioButton.Location = new System.Drawing.Point(87, 271);
            this.User_RadioButton.Name = "User_RadioButton";
            this.User_RadioButton.Size = new System.Drawing.Size(156, 29);
            this.User_RadioButton.TabIndex = 18;
            this.User_RadioButton.TabStop = true;
            this.User_RadioButton.Text = "Пользователь";
            this.Info_ToolTip.SetToolTip(this.User_RadioButton, "Тип аккаунта: пользователь");
            this.User_RadioButton.UseVisualStyleBackColor = true;
            this.User_RadioButton.CheckedChanged += new System.EventHandler(this.User_RadioButton_CheckedChanged);
            // 
            // Group_ComboBox
            // 
            this.Group_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Group_ComboBox.DropDownHeight = 150;
            this.Group_ComboBox.DropDownWidth = 200;
            this.Group_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Group_ComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Group_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Group_ComboBox.FormattingEnabled = true;
            this.Group_ComboBox.IntegralHeight = false;
            this.Group_ComboBox.Location = new System.Drawing.Point(12, 229);
            this.Group_ComboBox.MaxDropDownItems = 4;
            this.Group_ComboBox.Name = "Group_ComboBox";
            this.Group_ComboBox.Size = new System.Drawing.Size(410, 33);
            this.Group_ComboBox.TabIndex = 79;
            this.Info_ToolTip.SetToolTip(this.Group_ComboBox, "Выберите группы");
            this.Group_ComboBox.Visible = false;
            // 
            // Group_Label
            // 
            this.Group_Label.AutoSize = true;
            this.Group_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Group_Label.Location = new System.Drawing.Point(12, 201);
            this.Group_Label.Name = "Group_Label";
            this.Group_Label.Size = new System.Drawing.Size(78, 25);
            this.Group_Label.TabIndex = 78;
            this.Group_Label.Text = "Группа:";
            this.Group_Label.Visible = false;
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(432, 362);
            this.Controls.Add(this.Group_ComboBox);
            this.Controls.Add(this.Group_Label);
            this.Controls.Add(this.User_RadioButton);
            this.Controls.Add(this.Tester_RadioButton);
            this.Controls.Add(this.Full_Name_TextBox);
            this.Controls.Add(this.Full_Name_Label);
            this.Controls.Add(this.Generat_Password_Button);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.Registration_Button);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Pawwsord_Label);
            this.Controls.Add(this.Login_TextBox);
            this.Controls.Add(this.Login_Label);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generat_Password_Button;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button Registration_Button;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Label Pawwsord_Label;
        private System.Windows.Forms.TextBox Login_TextBox;
        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.TextBox Full_Name_TextBox;
        private System.Windows.Forms.Label Full_Name_Label;
        private System.Windows.Forms.RadioButton Tester_RadioButton;
        private System.Windows.Forms.RadioButton User_RadioButton;
        private System.Windows.Forms.ComboBox Group_ComboBox;
        private System.Windows.Forms.Label Group_Label;
        private System.Windows.Forms.ToolTip Info_ToolTip;
    }
}