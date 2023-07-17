namespace Testing.Forms.Tester_Form
{
    partial class New_Test_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Test_Form));
            this.New_Question_Button = new System.Windows.Forms.Button();
            this.Change_Button = new System.Windows.Forms.Button();
            this.Question_Number_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Previous_Question_Button = new System.Windows.Forms.Button();
            this.Next_Question_Batton = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Add_Question_Button = new System.Windows.Forms.Button();
            this.Delete_Question_Button = new System.Windows.Forms.Button();
            this.Fourth_Answer_RadioButton = new System.Windows.Forms.RadioButton();
            this.Third_Answer_RadioButton = new System.Windows.Forms.RadioButton();
            this.Second_Answer_RadioButton = new System.Windows.Forms.RadioButton();
            this.First_Answer_RadioButton = new System.Windows.Forms.RadioButton();
            this.Fourth_Answer_TextBox = new System.Windows.Forms.TextBox();
            this.Fourth_Answer_Label = new System.Windows.Forms.Label();
            this.Third_Answer_TextBox = new System.Windows.Forms.TextBox();
            this.Third_Answer_Label = new System.Windows.Forms.Label();
            this.Second_Answer_TextBox = new System.Windows.Forms.TextBox();
            this.Second_Answer_Label = new System.Windows.Forms.Label();
            this.First_Answer_TextBox = new System.Windows.Forms.TextBox();
            this.First_Answer_Label = new System.Windows.Forms.Label();
            this.Question_Text_TextBox = new System.Windows.Forms.TextBox();
            this.Question_Text_Label = new System.Windows.Forms.Label();
            this.Min_Label = new System.Windows.Forms.Label();
            this.Time_Complete_TextBox = new System.Windows.Forms.TextBox();
            this.Time_Complete_Label = new System.Windows.Forms.Label();
            this.Cancellation_Button = new System.Windows.Forms.Button();
            this.Name_Test_TextBox = new System.Windows.Forms.TextBox();
            this.Name_Test_Label = new System.Windows.Forms.Label();
            this.Info_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // New_Question_Button
            // 
            this.New_Question_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.New_Question_Button.BackgroundImage = global::Testing.Properties.Resources.New_Entry_Image;
            this.New_Question_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.New_Question_Button.FlatAppearance.BorderSize = 0;
            this.New_Question_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_Question_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.New_Question_Button.Location = new System.Drawing.Point(132, 685);
            this.New_Question_Button.Name = "New_Question_Button";
            this.New_Question_Button.Size = new System.Drawing.Size(80, 80);
            this.New_Question_Button.TabIndex = 68;
            this.Info_ToolTip.SetToolTip(this.New_Question_Button, "Новый вопрос");
            this.New_Question_Button.UseVisualStyleBackColor = false;
            this.New_Question_Button.Click += new System.EventHandler(this.New_Question_Button_Click);
            // 
            // Change_Button
            // 
            this.Change_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Change_Button.BackgroundImage = global::Testing.Properties.Resources.Editing_Entry_Image;
            this.Change_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Change_Button.FlatAppearance.BorderSize = 0;
            this.Change_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Change_Button.Location = new System.Drawing.Point(304, 685);
            this.Change_Button.Name = "Change_Button";
            this.Change_Button.Size = new System.Drawing.Size(80, 80);
            this.Change_Button.TabIndex = 67;
            this.Info_ToolTip.SetToolTip(this.Change_Button, "Изменить вопрос");
            this.Change_Button.UseVisualStyleBackColor = false;
            this.Change_Button.Click += new System.EventHandler(this.Change_Button_Click);
            // 
            // Question_Number_Label
            // 
            this.Question_Number_Label.AutoSize = true;
            this.Question_Number_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question_Number_Label.Location = new System.Drawing.Point(513, 100);
            this.Question_Number_Label.Name = "Question_Number_Label";
            this.Question_Number_Label.Size = new System.Drawing.Size(42, 25);
            this.Question_Number_Label.TabIndex = 66;
            this.Question_Number_Label.Text = "0/0";
            this.Info_ToolTip.SetToolTip(this.Question_Number_Label, "Номер отображаемого вопроса/ общее количество вопросов");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(426, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 65;
            this.label1.Text = "Вопрос:";
            // 
            // Previous_Question_Button
            // 
            this.Previous_Question_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Previous_Question_Button.BackgroundImage = global::Testing.Properties.Resources.Previos_Entry_Image;
            this.Previous_Question_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Previous_Question_Button.FlatAppearance.BorderSize = 0;
            this.Previous_Question_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previous_Question_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Previous_Question_Button.Location = new System.Drawing.Point(12, 685);
            this.Previous_Question_Button.Name = "Previous_Question_Button";
            this.Previous_Question_Button.Size = new System.Drawing.Size(80, 80);
            this.Previous_Question_Button.TabIndex = 64;
            this.Previous_Question_Button.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Info_ToolTip.SetToolTip(this.Previous_Question_Button, "Предыдущий вопрос");
            this.Previous_Question_Button.UseVisualStyleBackColor = false;
            this.Previous_Question_Button.Click += new System.EventHandler(this.Previous_Question_Button_Click);
            // 
            // Next_Question_Batton
            // 
            this.Next_Question_Batton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Next_Question_Batton.BackgroundImage = global::Testing.Properties.Resources.Next_Entry_Image;
            this.Next_Question_Batton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Next_Question_Batton.FlatAppearance.BorderSize = 0;
            this.Next_Question_Batton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_Question_Batton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Next_Question_Batton.Location = new System.Drawing.Point(708, 685);
            this.Next_Question_Batton.Name = "Next_Question_Batton";
            this.Next_Question_Batton.Size = new System.Drawing.Size(80, 80);
            this.Next_Question_Batton.TabIndex = 63;
            this.Info_ToolTip.SetToolTip(this.Next_Question_Batton, "Следущий вопрос");
            this.Next_Question_Batton.UseVisualStyleBackColor = false;
            this.Next_Question_Batton.Click += new System.EventHandler(this.Next_Question_Batton_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Save_Button.BackgroundImage = global::Testing.Properties.Resources.Confirm_Image;
            this.Save_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Save_Button.FlatAppearance.BorderSize = 0;
            this.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Save_Button.Location = new System.Drawing.Point(504, 685);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(80, 80);
            this.Save_Button.TabIndex = 62;
            this.Info_ToolTip.SetToolTip(this.Save_Button, "Принять все изменения");
            this.Save_Button.UseVisualStyleBackColor = false;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Add_Question_Button
            // 
            this.Add_Question_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Add_Question_Button.BackgroundImage = global::Testing.Properties.Resources.Add_Entry_Image;
            this.Add_Question_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Add_Question_Button.FlatAppearance.BorderSize = 0;
            this.Add_Question_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Question_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Add_Question_Button.Location = new System.Drawing.Point(218, 685);
            this.Add_Question_Button.Name = "Add_Question_Button";
            this.Add_Question_Button.Size = new System.Drawing.Size(80, 80);
            this.Add_Question_Button.TabIndex = 61;
            this.Info_ToolTip.SetToolTip(this.Add_Question_Button, "Добавить вопрос");
            this.Add_Question_Button.UseVisualStyleBackColor = false;
            this.Add_Question_Button.Click += new System.EventHandler(this.Add_Question_Button_Click);
            // 
            // Delete_Question_Button
            // 
            this.Delete_Question_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Delete_Question_Button.BackgroundImage = global::Testing.Properties.Resources.Delete_Image;
            this.Delete_Question_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Delete_Question_Button.FlatAppearance.BorderSize = 0;
            this.Delete_Question_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Question_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Delete_Question_Button.Location = new System.Drawing.Point(390, 685);
            this.Delete_Question_Button.Name = "Delete_Question_Button";
            this.Delete_Question_Button.Size = new System.Drawing.Size(80, 80);
            this.Delete_Question_Button.TabIndex = 60;
            this.Info_ToolTip.SetToolTip(this.Delete_Question_Button, "Удалить вопрос");
            this.Delete_Question_Button.UseVisualStyleBackColor = false;
            this.Delete_Question_Button.Click += new System.EventHandler(this.Delete_Question_Button_Click);
            // 
            // Fourth_Answer_RadioButton
            // 
            this.Fourth_Answer_RadioButton.AutoSize = true;
            this.Fourth_Answer_RadioButton.Location = new System.Drawing.Point(759, 630);
            this.Fourth_Answer_RadioButton.Name = "Fourth_Answer_RadioButton";
            this.Fourth_Answer_RadioButton.Size = new System.Drawing.Size(14, 13);
            this.Fourth_Answer_RadioButton.TabIndex = 59;
            this.Fourth_Answer_RadioButton.TabStop = true;
            this.Info_ToolTip.SetToolTip(this.Fourth_Answer_RadioButton, "Сделать четвертый вариант верным");
            this.Fourth_Answer_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Third_Answer_RadioButton
            // 
            this.Third_Answer_RadioButton.AutoSize = true;
            this.Third_Answer_RadioButton.Location = new System.Drawing.Point(759, 540);
            this.Third_Answer_RadioButton.Name = "Third_Answer_RadioButton";
            this.Third_Answer_RadioButton.Size = new System.Drawing.Size(14, 13);
            this.Third_Answer_RadioButton.TabIndex = 58;
            this.Third_Answer_RadioButton.TabStop = true;
            this.Info_ToolTip.SetToolTip(this.Third_Answer_RadioButton, "Сделать третий вариант верным");
            this.Third_Answer_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Second_Answer_RadioButton
            // 
            this.Second_Answer_RadioButton.AutoSize = true;
            this.Second_Answer_RadioButton.Location = new System.Drawing.Point(759, 453);
            this.Second_Answer_RadioButton.Name = "Second_Answer_RadioButton";
            this.Second_Answer_RadioButton.Size = new System.Drawing.Size(14, 13);
            this.Second_Answer_RadioButton.TabIndex = 57;
            this.Second_Answer_RadioButton.TabStop = true;
            this.Info_ToolTip.SetToolTip(this.Second_Answer_RadioButton, "Сделать второй вариант верным");
            this.Second_Answer_RadioButton.UseVisualStyleBackColor = true;
            // 
            // First_Answer_RadioButton
            // 
            this.First_Answer_RadioButton.AutoSize = true;
            this.First_Answer_RadioButton.Location = new System.Drawing.Point(759, 362);
            this.First_Answer_RadioButton.Name = "First_Answer_RadioButton";
            this.First_Answer_RadioButton.Size = new System.Drawing.Size(14, 13);
            this.First_Answer_RadioButton.TabIndex = 56;
            this.First_Answer_RadioButton.TabStop = true;
            this.Info_ToolTip.SetToolTip(this.First_Answer_RadioButton, "Сделать первый вариант верным");
            this.First_Answer_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Fourth_Answer_TextBox
            // 
            this.Fourth_Answer_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Fourth_Answer_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fourth_Answer_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Fourth_Answer_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Fourth_Answer_TextBox.Location = new System.Drawing.Point(39, 594);
            this.Fourth_Answer_TextBox.Multiline = true;
            this.Fourth_Answer_TextBox.Name = "Fourth_Answer_TextBox";
            this.Fourth_Answer_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Fourth_Answer_TextBox.Size = new System.Drawing.Size(714, 85);
            this.Fourth_Answer_TextBox.TabIndex = 55;
            this.Info_ToolTip.SetToolTip(this.Fourth_Answer_TextBox, "Введите четвертый вариант ответа");
            // 
            // Fourth_Answer_Label
            // 
            this.Fourth_Answer_Label.AutoSize = true;
            this.Fourth_Answer_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fourth_Answer_Label.Location = new System.Drawing.Point(4, 618);
            this.Fourth_Answer_Label.Name = "Fourth_Answer_Label";
            this.Fourth_Answer_Label.Size = new System.Drawing.Size(29, 25);
            this.Fourth_Answer_Label.TabIndex = 54;
            this.Fourth_Answer_Label.Text = "4)";
            // 
            // Third_Answer_TextBox
            // 
            this.Third_Answer_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Third_Answer_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Third_Answer_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Third_Answer_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Third_Answer_TextBox.Location = new System.Drawing.Point(39, 503);
            this.Third_Answer_TextBox.Multiline = true;
            this.Third_Answer_TextBox.Name = "Third_Answer_TextBox";
            this.Third_Answer_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Third_Answer_TextBox.Size = new System.Drawing.Size(714, 85);
            this.Third_Answer_TextBox.TabIndex = 53;
            this.Info_ToolTip.SetToolTip(this.Third_Answer_TextBox, "Введите третий вариант ответа");
            // 
            // Third_Answer_Label
            // 
            this.Third_Answer_Label.AutoSize = true;
            this.Third_Answer_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Third_Answer_Label.Location = new System.Drawing.Point(4, 528);
            this.Third_Answer_Label.Name = "Third_Answer_Label";
            this.Third_Answer_Label.Size = new System.Drawing.Size(29, 25);
            this.Third_Answer_Label.TabIndex = 52;
            this.Third_Answer_Label.Text = "3)";
            // 
            // Second_Answer_TextBox
            // 
            this.Second_Answer_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Second_Answer_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Second_Answer_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Second_Answer_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Second_Answer_TextBox.Location = new System.Drawing.Point(39, 412);
            this.Second_Answer_TextBox.Multiline = true;
            this.Second_Answer_TextBox.Name = "Second_Answer_TextBox";
            this.Second_Answer_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Second_Answer_TextBox.Size = new System.Drawing.Size(714, 85);
            this.Second_Answer_TextBox.TabIndex = 51;
            this.Info_ToolTip.SetToolTip(this.Second_Answer_TextBox, "Введите второй вариант ответа");
            // 
            // Second_Answer_Label
            // 
            this.Second_Answer_Label.AutoSize = true;
            this.Second_Answer_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Second_Answer_Label.Location = new System.Drawing.Point(4, 444);
            this.Second_Answer_Label.Name = "Second_Answer_Label";
            this.Second_Answer_Label.Size = new System.Drawing.Size(29, 25);
            this.Second_Answer_Label.TabIndex = 50;
            this.Second_Answer_Label.Text = "2)";
            // 
            // First_Answer_TextBox
            // 
            this.First_Answer_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.First_Answer_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.First_Answer_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.First_Answer_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.First_Answer_TextBox.Location = new System.Drawing.Point(39, 321);
            this.First_Answer_TextBox.Multiline = true;
            this.First_Answer_TextBox.Name = "First_Answer_TextBox";
            this.First_Answer_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.First_Answer_TextBox.Size = new System.Drawing.Size(714, 85);
            this.First_Answer_TextBox.TabIndex = 49;
            this.Info_ToolTip.SetToolTip(this.First_Answer_TextBox, "Введите первый вариант ответа");
            // 
            // First_Answer_Label
            // 
            this.First_Answer_Label.AutoSize = true;
            this.First_Answer_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.First_Answer_Label.Location = new System.Drawing.Point(7, 353);
            this.First_Answer_Label.Name = "First_Answer_Label";
            this.First_Answer_Label.Size = new System.Drawing.Size(26, 25);
            this.First_Answer_Label.TabIndex = 48;
            this.First_Answer_Label.Text = "1)";
            // 
            // Question_Text_TextBox
            // 
            this.Question_Text_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Question_Text_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Question_Text_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Question_Text_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Question_Text_TextBox.Location = new System.Drawing.Point(94, 136);
            this.Question_Text_TextBox.Multiline = true;
            this.Question_Text_TextBox.Name = "Question_Text_TextBox";
            this.Question_Text_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Question_Text_TextBox.Size = new System.Drawing.Size(689, 179);
            this.Question_Text_TextBox.TabIndex = 47;
            this.Info_ToolTip.SetToolTip(this.Question_Text_TextBox, "Введите текст вопроса");
            // 
            // Question_Text_Label
            // 
            this.Question_Text_Label.AutoSize = true;
            this.Question_Text_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question_Text_Label.Location = new System.Drawing.Point(7, 139);
            this.Question_Text_Label.Name = "Question_Text_Label";
            this.Question_Text_Label.Size = new System.Drawing.Size(81, 25);
            this.Question_Text_Label.TabIndex = 46;
            this.Question_Text_Label.Text = "Вопрос:";
            // 
            // Min_Label
            // 
            this.Min_Label.AutoSize = true;
            this.Min_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Min_Label.Location = new System.Drawing.Point(302, 100);
            this.Min_Label.Name = "Min_Label";
            this.Min_Label.Size = new System.Drawing.Size(53, 25);
            this.Min_Label.TabIndex = 45;
            this.Min_Label.Text = "мин.";
            // 
            // Time_Complete_TextBox
            // 
            this.Time_Complete_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Time_Complete_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Time_Complete_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Time_Complete_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Time_Complete_TextBox.Location = new System.Drawing.Point(213, 97);
            this.Time_Complete_TextBox.Name = "Time_Complete_TextBox";
            this.Time_Complete_TextBox.Size = new System.Drawing.Size(83, 33);
            this.Time_Complete_TextBox.TabIndex = 44;
            this.Time_Complete_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Info_ToolTip.SetToolTip(this.Time_Complete_TextBox, "Укажите время на прохождение в минутах, если время не ограничено введите 0");
            // 
            // Time_Complete_Label
            // 
            this.Time_Complete_Label.AutoSize = true;
            this.Time_Complete_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time_Complete_Label.Location = new System.Drawing.Point(7, 100);
            this.Time_Complete_Label.Name = "Time_Complete_Label";
            this.Time_Complete_Label.Size = new System.Drawing.Size(200, 25);
            this.Time_Complete_Label.TabIndex = 43;
            this.Time_Complete_Label.Text = "Время прохождения:";
            // 
            // Cancellation_Button
            // 
            this.Cancellation_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Cancellation_Button.BackgroundImage = global::Testing.Properties.Resources.Back_Image;
            this.Cancellation_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cancellation_Button.FlatAppearance.BorderSize = 0;
            this.Cancellation_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancellation_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Cancellation_Button.Location = new System.Drawing.Point(590, 685);
            this.Cancellation_Button.Name = "Cancellation_Button";
            this.Cancellation_Button.Size = new System.Drawing.Size(80, 80);
            this.Cancellation_Button.TabIndex = 42;
            this.Info_ToolTip.SetToolTip(this.Cancellation_Button, "Вернуться без сохранения изменений");
            this.Cancellation_Button.UseVisualStyleBackColor = false;
            this.Cancellation_Button.Click += new System.EventHandler(this.Cancellation_Button_Click);
            // 
            // Name_Test_TextBox
            // 
            this.Name_Test_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Name_Test_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_Test_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Name_Test_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Name_Test_TextBox.Location = new System.Drawing.Point(166, 6);
            this.Name_Test_TextBox.Multiline = true;
            this.Name_Test_TextBox.Name = "Name_Test_TextBox";
            this.Name_Test_TextBox.Size = new System.Drawing.Size(617, 85);
            this.Name_Test_TextBox.TabIndex = 41;
            this.Info_ToolTip.SetToolTip(this.Name_Test_TextBox, "Введите название теста");
            // 
            // Name_Test_Label
            // 
            this.Name_Test_Label.AutoSize = true;
            this.Name_Test_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_Test_Label.Location = new System.Drawing.Point(7, 9);
            this.Name_Test_Label.Name = "Name_Test_Label";
            this.Name_Test_Label.Size = new System.Drawing.Size(153, 25);
            this.Name_Test_Label.TabIndex = 40;
            this.Name_Test_Label.Text = "Название теста:";
            // 
            // New_Test_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 780);
            this.Controls.Add(this.New_Question_Button);
            this.Controls.Add(this.Change_Button);
            this.Controls.Add(this.Question_Number_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Previous_Question_Button);
            this.Controls.Add(this.Next_Question_Batton);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Add_Question_Button);
            this.Controls.Add(this.Delete_Question_Button);
            this.Controls.Add(this.Fourth_Answer_RadioButton);
            this.Controls.Add(this.Third_Answer_RadioButton);
            this.Controls.Add(this.Second_Answer_RadioButton);
            this.Controls.Add(this.First_Answer_RadioButton);
            this.Controls.Add(this.Fourth_Answer_TextBox);
            this.Controls.Add(this.Fourth_Answer_Label);
            this.Controls.Add(this.Third_Answer_TextBox);
            this.Controls.Add(this.Third_Answer_Label);
            this.Controls.Add(this.Second_Answer_TextBox);
            this.Controls.Add(this.Second_Answer_Label);
            this.Controls.Add(this.First_Answer_TextBox);
            this.Controls.Add(this.First_Answer_Label);
            this.Controls.Add(this.Question_Text_TextBox);
            this.Controls.Add(this.Question_Text_Label);
            this.Controls.Add(this.Min_Label);
            this.Controls.Add(this.Time_Complete_TextBox);
            this.Controls.Add(this.Time_Complete_Label);
            this.Controls.Add(this.Cancellation_Button);
            this.Controls.Add(this.Name_Test_TextBox);
            this.Controls.Add(this.Name_Test_Label);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "New_Test_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать новый тест";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button New_Question_Button;
        private System.Windows.Forms.Button Change_Button;
        private System.Windows.Forms.Label Question_Number_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Previous_Question_Button;
        private System.Windows.Forms.Button Next_Question_Batton;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Add_Question_Button;
        private System.Windows.Forms.Button Delete_Question_Button;
        private System.Windows.Forms.RadioButton Fourth_Answer_RadioButton;
        private System.Windows.Forms.RadioButton Third_Answer_RadioButton;
        private System.Windows.Forms.RadioButton Second_Answer_RadioButton;
        private System.Windows.Forms.RadioButton First_Answer_RadioButton;
        private System.Windows.Forms.TextBox Fourth_Answer_TextBox;
        private System.Windows.Forms.Label Fourth_Answer_Label;
        private System.Windows.Forms.TextBox Third_Answer_TextBox;
        private System.Windows.Forms.Label Third_Answer_Label;
        private System.Windows.Forms.TextBox Second_Answer_TextBox;
        private System.Windows.Forms.Label Second_Answer_Label;
        private System.Windows.Forms.TextBox First_Answer_TextBox;
        private System.Windows.Forms.Label First_Answer_Label;
        private System.Windows.Forms.TextBox Question_Text_TextBox;
        private System.Windows.Forms.Label Question_Text_Label;
        private System.Windows.Forms.Label Min_Label;
        private System.Windows.Forms.TextBox Time_Complete_TextBox;
        private System.Windows.Forms.Label Time_Complete_Label;
        private System.Windows.Forms.Button Cancellation_Button;
        private System.Windows.Forms.TextBox Name_Test_TextBox;
        private System.Windows.Forms.Label Name_Test_Label;
        private System.Windows.Forms.ToolTip Info_ToolTip;
    }
}