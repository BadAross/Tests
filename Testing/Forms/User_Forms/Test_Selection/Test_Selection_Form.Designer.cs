namespace Testing.Forms
{
    partial class Test_Selection_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test_Selection_Form));
            this.Admin_Name_Label = new System.Windows.Forms.Label();
            this.Tester_Name_ComboBox = new System.Windows.Forms.ComboBox();
            this.Start_Test_Batton = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Name_Test_ComboBox = new System.Windows.Forms.ComboBox();
            this.Select_Tests_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Admin_Name_Label
            // 
            this.Admin_Name_Label.AutoSize = true;
            this.Admin_Name_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Admin_Name_Label.Location = new System.Drawing.Point(12, 9);
            this.Admin_Name_Label.Name = "Admin_Name_Label";
            this.Admin_Name_Label.Size = new System.Drawing.Size(220, 25);
            this.Admin_Name_Label.TabIndex = 1;
            this.Admin_Name_Label.Text = "Выберите специалиста:";
            // 
            // Tester_Name_ComboBox
            // 
            this.Tester_Name_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Tester_Name_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tester_Name_ComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Tester_Name_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Tester_Name_ComboBox.FormattingEnabled = true;
            this.Tester_Name_ComboBox.Location = new System.Drawing.Point(17, 37);
            this.Tester_Name_ComboBox.Name = "Tester_Name_ComboBox";
            this.Tester_Name_ComboBox.Size = new System.Drawing.Size(531, 33);
            this.Tester_Name_ComboBox.TabIndex = 2;
            this.Tester_Name_ComboBox.SelectedIndexChanged += new System.EventHandler(this.AdminName_ComboBox_SelectedIndexChanged);
            // 
            // Start_Test_Batton
            // 
            this.Start_Test_Batton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Start_Test_Batton.FlatAppearance.BorderSize = 2;
            this.Start_Test_Batton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Test_Batton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Start_Test_Batton.Location = new System.Drawing.Point(17, 143);
            this.Start_Test_Batton.Name = "Start_Test_Batton";
            this.Start_Test_Batton.Size = new System.Drawing.Size(245, 38);
            this.Start_Test_Batton.TabIndex = 5;
            this.Start_Test_Batton.Text = "Начать тест";
            this.Start_Test_Batton.UseVisualStyleBackColor = false;
            this.Start_Test_Batton.Click += new System.EventHandler(this.Start_Batton_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Back_Button.FlatAppearance.BorderSize = 2;
            this.Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Back_Button.Location = new System.Drawing.Point(303, 143);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(245, 38);
            this.Back_Button.TabIndex = 6;
            this.Back_Button.Text = "Назад";
            this.Back_Button.UseVisualStyleBackColor = false;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Name_Test_ComboBox
            // 
            this.Name_Test_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Name_Test_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Name_Test_ComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Name_Test_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Name_Test_ComboBox.FormattingEnabled = true;
            this.Name_Test_ComboBox.Location = new System.Drawing.Point(17, 101);
            this.Name_Test_ComboBox.Name = "Name_Test_ComboBox";
            this.Name_Test_ComboBox.Size = new System.Drawing.Size(531, 33);
            this.Name_Test_ComboBox.TabIndex = 8;
            // 
            // Select_Tests_Label
            // 
            this.Select_Tests_Label.AutoSize = true;
            this.Select_Tests_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Select_Tests_Label.Location = new System.Drawing.Point(12, 73);
            this.Select_Tests_Label.Name = "Select_Tests_Label";
            this.Select_Tests_Label.Size = new System.Drawing.Size(143, 25);
            this.Select_Tests_Label.TabIndex = 7;
            this.Select_Tests_Label.Text = "Выберите тест:";
            // 
            // Test_Selection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(563, 193);
            this.Controls.Add(this.Name_Test_ComboBox);
            this.Controls.Add(this.Select_Tests_Label);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Start_Test_Batton);
            this.Controls.Add(this.Tester_Name_ComboBox);
            this.Controls.Add(this.Admin_Name_Label);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Test_Selection_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор теста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Admin_Name_Label;
        private System.Windows.Forms.ComboBox Tester_Name_ComboBox;
        private System.Windows.Forms.Button Start_Test_Batton;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.ComboBox Name_Test_ComboBox;
        private System.Windows.Forms.Label Select_Tests_Label;
    }
}