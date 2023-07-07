namespace Testing
{
    partial class Avtorization_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avtorization_Form));
            this.Login_Label = new System.Windows.Forms.Label();
            this.Login_TextBox = new System.Windows.Forms.TextBox();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.Pawwsord_Label = new System.Windows.Forms.Label();
            this.Enter_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.Show_Password_Button = new System.Windows.Forms.Button();
            this.Registration_Button = new System.Windows.Forms.Button();
            this.Info_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Login_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Login_Label.Location = new System.Drawing.Point(12, 9);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(71, 25);
            this.Login_Label.TabIndex = 0;
            this.Login_Label.Text = "Логин:";
            // 
            // Login_TextBox
            // 
            this.Login_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Login_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Login_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Login_TextBox.Location = new System.Drawing.Point(12, 37);
            this.Login_TextBox.Name = "Login_TextBox";
            this.Login_TextBox.Size = new System.Drawing.Size(410, 33);
            this.Login_TextBox.TabIndex = 1;
            this.Info_ToolTip.SetToolTip(this.Login_TextBox, "Введите логин");
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Password_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Password_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Password_TextBox.Location = new System.Drawing.Point(12, 101);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(370, 33);
            this.Password_TextBox.TabIndex = 3;
            this.Info_ToolTip.SetToolTip(this.Password_TextBox, "Введите пароль");
            // 
            // Pawwsord_Label
            // 
            this.Pawwsord_Label.AutoSize = true;
            this.Pawwsord_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Pawwsord_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Pawwsord_Label.Location = new System.Drawing.Point(12, 73);
            this.Pawwsord_Label.Name = "Pawwsord_Label";
            this.Pawwsord_Label.Size = new System.Drawing.Size(84, 25);
            this.Pawwsord_Label.TabIndex = 2;
            this.Pawwsord_Label.Text = "Пароль:";
            // 
            // Enter_Button
            // 
            this.Enter_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Enter_Button.FlatAppearance.BorderSize = 2;
            this.Enter_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Enter_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Enter_Button.Location = new System.Drawing.Point(12, 140);
            this.Enter_Button.Name = "Enter_Button";
            this.Enter_Button.Size = new System.Drawing.Size(192, 38);
            this.Enter_Button.TabIndex = 4;
            this.Enter_Button.Text = "Вход";
            this.Info_ToolTip.SetToolTip(this.Enter_Button, "Войти в аккаунт");
            this.Enter_Button.UseVisualStyleBackColor = false;
            this.Enter_Button.Click += new System.EventHandler(this.Enter_Batton_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.FlatAppearance.BorderSize = 2;
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Close_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Close_Button.Location = new System.Drawing.Point(12, 184);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(410, 38);
            this.Close_Button.TabIndex = 5;
            this.Close_Button.Text = "Зактрыть";
            this.Info_ToolTip.SetToolTip(this.Close_Button, "Выход");
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Show_Password_Button
            // 
            this.Show_Password_Button.BackgroundImage = global::Testing.Properties.Resources.Show_Password_Image;
            this.Show_Password_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Show_Password_Button.FlatAppearance.BorderSize = 0;
            this.Show_Password_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show_Password_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Show_Password_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Show_Password_Button.Location = new System.Drawing.Point(387, 101);
            this.Show_Password_Button.Name = "Show_Password_Button";
            this.Show_Password_Button.Size = new System.Drawing.Size(35, 33);
            this.Show_Password_Button.TabIndex = 7;
            this.Info_ToolTip.SetToolTip(this.Show_Password_Button, "Показать\\скрыть пароль");
            this.Show_Password_Button.UseVisualStyleBackColor = true;
            this.Show_Password_Button.Click += new System.EventHandler(this.ShowPassword_Button_Click);
            // 
            // Registration_Button
            // 
            this.Registration_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Registration_Button.FlatAppearance.BorderSize = 2;
            this.Registration_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registration_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Registration_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Registration_Button.Location = new System.Drawing.Point(230, 140);
            this.Registration_Button.Name = "Registration_Button";
            this.Registration_Button.Size = new System.Drawing.Size(192, 38);
            this.Registration_Button.TabIndex = 8;
            this.Registration_Button.Text = "Регистрация";
            this.Info_ToolTip.SetToolTip(this.Registration_Button, "зарегестрировать новый аккаунт");
            this.Registration_Button.UseVisualStyleBackColor = false;
            this.Registration_Button.Click += new System.EventHandler(this.Registration_Button_Click);
            // 
            // Avtorization_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(438, 235);
            this.Controls.Add(this.Registration_Button);
            this.Controls.Add(this.Show_Password_Button);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.Enter_Button);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Pawwsord_Label);
            this.Controls.Add(this.Login_TextBox);
            this.Controls.Add(this.Login_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Avtorization_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.TextBox Login_TextBox;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Label Pawwsord_Label;
        private System.Windows.Forms.Button Enter_Button;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button Show_Password_Button;
        private System.Windows.Forms.Button Registration_Button;
        private System.Windows.Forms.ToolTip Info_ToolTip;
    }
}

