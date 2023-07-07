namespace Testing.Forms.Tester_Form
{
    partial class Tester_Menu_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tester_Menu_Form));
            this.My_Tests_Button = new System.Windows.Forms.Button();
            this.Name_Tester_Label = new System.Windows.Forms.Label();
            this.Result_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.Info_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // My_Tests_Button
            // 
            this.My_Tests_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.My_Tests_Button.FlatAppearance.BorderSize = 2;
            this.My_Tests_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.My_Tests_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.My_Tests_Button.Location = new System.Drawing.Point(17, 85);
            this.My_Tests_Button.Name = "My_Tests_Button";
            this.My_Tests_Button.Size = new System.Drawing.Size(333, 38);
            this.My_Tests_Button.TabIndex = 6;
            this.My_Tests_Button.Text = "Мои тесты";
            this.Info_ToolTip.SetToolTip(this.My_Tests_Button, "Редактировать тесты");
            this.My_Tests_Button.UseVisualStyleBackColor = false;
            this.My_Tests_Button.Click += new System.EventHandler(this.My_Tests_Batton_Click);
            // 
            // Name_Tester_Label
            // 
            this.Name_Tester_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Name_Tester_Label.Location = new System.Drawing.Point(12, 9);
            this.Name_Tester_Label.Name = "Name_Tester_Label";
            this.Name_Tester_Label.Size = new System.Drawing.Size(333, 73);
            this.Name_Tester_Label.TabIndex = 7;
            this.Name_Tester_Label.Text = "Здравствуйте, Иванов Иван Иванович!";
            this.Name_Tester_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Result_Button
            // 
            this.Result_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Result_Button.FlatAppearance.BorderSize = 2;
            this.Result_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Result_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Result_Button.Location = new System.Drawing.Point(17, 129);
            this.Result_Button.Name = "Result_Button";
            this.Result_Button.Size = new System.Drawing.Size(333, 38);
            this.Result_Button.TabIndex = 8;
            this.Result_Button.Text = "Результаты прохождения";
            this.Info_ToolTip.SetToolTip(this.Result_Button, "Посмотреть результаты прохождения");
            this.Result_Button.UseVisualStyleBackColor = false;
            this.Result_Button.Click += new System.EventHandler(this.Result_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Close_Button.BackgroundImage = global::Testing.Properties.Resources.Back_Image;
            this.Close_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Close_Button.FlatAppearance.BorderSize = 0;
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Close_Button.Location = new System.Drawing.Point(17, 201);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(333, 38);
            this.Close_Button.TabIndex = 9;
            this.Info_ToolTip.SetToolTip(this.Close_Button, "Выйти из аккаунта");
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Tester_Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(368, 253);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.Result_Button);
            this.Controls.Add(this.Name_Tester_Label);
            this.Controls.Add(this.My_Tests_Button);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tester_Menu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Tester_Menu_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button My_Tests_Button;
        public System.Windows.Forms.Label Name_Tester_Label;
        private System.Windows.Forms.Button Result_Button;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.ToolTip Info_ToolTip;
    }
}