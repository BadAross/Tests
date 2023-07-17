namespace Testing.Forms
{
    partial class Passing_Test_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passing_Test_Form));
            this.Name_Test_Label = new System.Windows.Forms.Label();
            this.Question_Text_Label = new System.Windows.Forms.Label();
            this.First_Answer_Option_RadioButton = new System.Windows.Forms.RadioButton();
            this.Next_Question_Batton = new System.Windows.Forms.Button();
            this.Previous_Question_Button = new System.Windows.Forms.Button();
            this.Time_Test_Label = new System.Windows.Forms.Label();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Question_Number_Label = new System.Windows.Forms.Label();
            this.Time_Test_Timer = new System.Windows.Forms.Timer(this.components);
            this.Second_Answer_Option_RadioButton = new System.Windows.Forms.RadioButton();
            this.Third_Answer_Option_RadioButton = new System.Windows.Forms.RadioButton();
            this.Fourth_Answer_Option_RadioButton = new System.Windows.Forms.RadioButton();
            this.Info_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Name_Test_Label
            // 
            this.Name_Test_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Name_Test_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_Test_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Name_Test_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.Name_Test_Label.Location = new System.Drawing.Point(12, 9);
            this.Name_Test_Label.Name = "Name_Test_Label";
            this.Name_Test_Label.Size = new System.Drawing.Size(1701, 67);
            this.Name_Test_Label.TabIndex = 0;
            this.Name_Test_Label.Text = "Название теста";
            this.Info_ToolTip.SetToolTip(this.Name_Test_Label, "Название теста");
            // 
            // Question_Text_Label
            // 
            this.Question_Text_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Question_Text_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Question_Text_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Question_Text_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Question_Text_Label.Location = new System.Drawing.Point(12, 85);
            this.Question_Text_Label.Name = "Question_Text_Label";
            this.Question_Text_Label.Size = new System.Drawing.Size(1896, 462);
            this.Question_Text_Label.TabIndex = 1;
            this.Question_Text_Label.Text = "Вопрос";
            this.Info_ToolTip.SetToolTip(this.Question_Text_Label, "Текст вопроса");
            // 
            // First_Answer_Option_RadioButton
            // 
            this.First_Answer_Option_RadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.First_Answer_Option_RadioButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.First_Answer_Option_RadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.First_Answer_Option_RadioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.First_Answer_Option_RadioButton.Location = new System.Drawing.Point(12, 550);
            this.First_Answer_Option_RadioButton.Name = "First_Answer_Option_RadioButton";
            this.First_Answer_Option_RadioButton.Size = new System.Drawing.Size(946, 213);
            this.First_Answer_Option_RadioButton.TabIndex = 11;
            this.First_Answer_Option_RadioButton.Text = "Ответ1";
            this.Info_ToolTip.SetToolTip(this.First_Answer_Option_RadioButton, "Первый вариант ответа");
            this.First_Answer_Option_RadioButton.UseVisualStyleBackColor = false;
            // 
            // Next_Question_Batton
            // 
            this.Next_Question_Batton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Next_Question_Batton.BackgroundImage = global::Testing.Properties.Resources.Next_Entry_Image;
            this.Next_Question_Batton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Next_Question_Batton.FlatAppearance.BorderSize = 0;
            this.Next_Question_Batton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_Question_Batton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Next_Question_Batton.Location = new System.Drawing.Point(1828, 988);
            this.Next_Question_Batton.Name = "Next_Question_Batton";
            this.Next_Question_Batton.Size = new System.Drawing.Size(80, 80);
            this.Next_Question_Batton.TabIndex = 12;
            this.Info_ToolTip.SetToolTip(this.Next_Question_Batton, "Следующий вопрос");
            this.Next_Question_Batton.UseVisualStyleBackColor = false;
            this.Next_Question_Batton.Click += new System.EventHandler(this.Next_Question_Batton_Click);
            // 
            // Previous_Question_Button
            // 
            this.Previous_Question_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Previous_Question_Button.BackgroundImage = global::Testing.Properties.Resources.Previos_Entry_Image;
            this.Previous_Question_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Previous_Question_Button.FlatAppearance.BorderSize = 0;
            this.Previous_Question_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previous_Question_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Previous_Question_Button.Location = new System.Drawing.Point(1719, 988);
            this.Previous_Question_Button.Name = "Previous_Question_Button";
            this.Previous_Question_Button.Size = new System.Drawing.Size(80, 80);
            this.Previous_Question_Button.TabIndex = 13;
            this.Info_ToolTip.SetToolTip(this.Previous_Question_Button, "Предыдущий вопрос");
            this.Previous_Question_Button.UseVisualStyleBackColor = false;
            this.Previous_Question_Button.Click += new System.EventHandler(this.Previous_Question_Button_Click);
            // 
            // Time_Test_Label
            // 
            this.Time_Test_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Time_Test_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Time_Test_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Time_Test_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.Time_Test_Label.Location = new System.Drawing.Point(1719, 9);
            this.Time_Test_Label.Name = "Time_Test_Label";
            this.Time_Test_Label.Size = new System.Drawing.Size(189, 67);
            this.Time_Test_Label.TabIndex = 14;
            this.Time_Test_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Info_ToolTip.SetToolTip(this.Time_Test_Label, "Время прохождения");
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Exit_Button.BackgroundImage = global::Testing.Properties.Resources.Back_Image;
            this.Exit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Exit_Button.Location = new System.Drawing.Point(12, 988);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(80, 80);
            this.Exit_Button.TabIndex = 15;
            this.Info_ToolTip.SetToolTip(this.Exit_Button, "Отменить прохождение теста");
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Question_Number_Label
            // 
            this.Question_Number_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Question_Number_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Question_Number_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.Question_Number_Label.Location = new System.Drawing.Point(866, 998);
            this.Question_Number_Label.Name = "Question_Number_Label";
            this.Question_Number_Label.Size = new System.Drawing.Size(189, 52);
            this.Question_Number_Label.TabIndex = 16;
            this.Question_Number_Label.Text = "999/999";
            this.Question_Number_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Info_ToolTip.SetToolTip(this.Question_Number_Label, "Количество вопросов теста");
            // 
            // Time_Test_Timer
            // 
            this.Time_Test_Timer.Enabled = true;
            this.Time_Test_Timer.Interval = 1000;
            this.Time_Test_Timer.Tick += new System.EventHandler(this.Time_Test_Tick);
            // 
            // Second_Answer_Option_RadioButton
            // 
            this.Second_Answer_Option_RadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Second_Answer_Option_RadioButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Second_Answer_Option_RadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Second_Answer_Option_RadioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Second_Answer_Option_RadioButton.Location = new System.Drawing.Point(964, 550);
            this.Second_Answer_Option_RadioButton.Name = "Second_Answer_Option_RadioButton";
            this.Second_Answer_Option_RadioButton.Size = new System.Drawing.Size(944, 213);
            this.Second_Answer_Option_RadioButton.TabIndex = 17;
            this.Second_Answer_Option_RadioButton.Text = "Ответ1";
            this.Info_ToolTip.SetToolTip(this.Second_Answer_Option_RadioButton, "Второй вариант ответа");
            this.Second_Answer_Option_RadioButton.UseVisualStyleBackColor = false;
            // 
            // Third_Answer_Option_RadioButton
            // 
            this.Third_Answer_Option_RadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Third_Answer_Option_RadioButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Third_Answer_Option_RadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Third_Answer_Option_RadioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Third_Answer_Option_RadioButton.Location = new System.Drawing.Point(12, 769);
            this.Third_Answer_Option_RadioButton.Name = "Third_Answer_Option_RadioButton";
            this.Third_Answer_Option_RadioButton.Size = new System.Drawing.Size(946, 213);
            this.Third_Answer_Option_RadioButton.TabIndex = 18;
            this.Third_Answer_Option_RadioButton.Text = "Ответ1";
            this.Info_ToolTip.SetToolTip(this.Third_Answer_Option_RadioButton, "Третий вариант ответа");
            this.Third_Answer_Option_RadioButton.UseVisualStyleBackColor = false;
            // 
            // Fourth_Answer_Option_RadioButton
            // 
            this.Fourth_Answer_Option_RadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Fourth_Answer_Option_RadioButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Fourth_Answer_Option_RadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Fourth_Answer_Option_RadioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Fourth_Answer_Option_RadioButton.Location = new System.Drawing.Point(964, 769);
            this.Fourth_Answer_Option_RadioButton.Name = "Fourth_Answer_Option_RadioButton";
            this.Fourth_Answer_Option_RadioButton.Size = new System.Drawing.Size(944, 213);
            this.Fourth_Answer_Option_RadioButton.TabIndex = 19;
            this.Fourth_Answer_Option_RadioButton.Text = "Ответ1";
            this.Info_ToolTip.SetToolTip(this.Fourth_Answer_Option_RadioButton, "Четвертый вариант ответа");
            this.Fourth_Answer_Option_RadioButton.UseVisualStyleBackColor = false;
            // 
            // Passing_Test_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.Fourth_Answer_Option_RadioButton);
            this.Controls.Add(this.Third_Answer_Option_RadioButton);
            this.Controls.Add(this.Second_Answer_Option_RadioButton);
            this.Controls.Add(this.Question_Number_Label);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Time_Test_Label);
            this.Controls.Add(this.Previous_Question_Button);
            this.Controls.Add(this.Next_Question_Batton);
            this.Controls.Add(this.First_Answer_Option_RadioButton);
            this.Controls.Add(this.Question_Text_Label);
            this.Controls.Add(this.Name_Test_Label);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Passing_Test_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестирование";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Question_Text_Label;
        private System.Windows.Forms.RadioButton First_Answer_Option_RadioButton;
        private System.Windows.Forms.Button Next_Question_Batton;
        private System.Windows.Forms.Button Previous_Question_Button;
        private System.Windows.Forms.Label Time_Test_Label;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Label Question_Number_Label;
        private System.Windows.Forms.Timer Time_Test_Timer;
        private System.Windows.Forms.RadioButton Second_Answer_Option_RadioButton;
        private System.Windows.Forms.RadioButton Third_Answer_Option_RadioButton;
        private System.Windows.Forms.RadioButton Fourth_Answer_Option_RadioButton;
        private System.Windows.Forms.Label Name_Test_Label;
        private System.Windows.Forms.ToolTip Info_ToolTip;
    }
}