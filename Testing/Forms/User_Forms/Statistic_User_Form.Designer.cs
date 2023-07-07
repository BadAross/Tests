namespace Testing.Forms
{
    partial class Statistic_User_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistic_User_Form));
            this.save_Progress_GroupBox = new System.Windows.Forms.GroupBox();
            this.Save_Progress_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Filter_GroupBox = new System.Windows.Forms.GroupBox();
            this.Hide_Filter_Button = new System.Windows.Forms.Button();
            this.Search_GroupBox = new System.Windows.Forms.GroupBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.Filtering_GroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Filtering_Full_Name_Tester_CheckBox = new System.Windows.Forms.CheckBox();
            this.Filtering_Full_Name_Tester_ComboBox = new System.Windows.Forms.ComboBox();
            this.Sorting_GroupBox = new System.Windows.Forms.GroupBox();
            this.Sorting_ComboBox = new System.Windows.Forms.ComboBox();
            this.Upload_In_Excel_Button = new System.Windows.Forms.Button();
            this.Resetting_Filter_Button = new System.Windows.Forms.Button();
            this.Filtering_Open_button = new System.Windows.Forms.Button();
            this.Close_Form_Button = new System.Windows.Forms.Button();
            this.Test_Result_DataGridView = new System.Windows.Forms.DataGridView();
            this.First_Entry_Button = new System.Windows.Forms.Button();
            this.Last_Entry_Button = new System.Windows.Forms.Button();
            this.Next_Entry_Button = new System.Windows.Forms.Button();
            this.Previos_Entry_Button = new System.Windows.Forms.Button();
            this.Info_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.save_Progress_GroupBox.SuspendLayout();
            this.Filter_GroupBox.SuspendLayout();
            this.Search_GroupBox.SuspendLayout();
            this.Filtering_GroupBox.SuspendLayout();
            this.Sorting_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Test_Result_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // save_Progress_GroupBox
            // 
            this.save_Progress_GroupBox.Controls.Add(this.Save_Progress_ProgressBar);
            this.save_Progress_GroupBox.Controls.Add(this.label1);
            this.save_Progress_GroupBox.Location = new System.Drawing.Point(688, 17);
            this.save_Progress_GroupBox.Name = "save_Progress_GroupBox";
            this.save_Progress_GroupBox.Size = new System.Drawing.Size(483, 93);
            this.save_Progress_GroupBox.TabIndex = 88;
            this.save_Progress_GroupBox.TabStop = false;
            this.save_Progress_GroupBox.Visible = false;
            // 
            // Save_Progress_ProgressBar
            // 
            this.Save_Progress_ProgressBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Save_Progress_ProgressBar.ForeColor = System.Drawing.Color.Lime;
            this.Save_Progress_ProgressBar.Location = new System.Drawing.Point(6, 51);
            this.Save_Progress_ProgressBar.Name = "Save_Progress_ProgressBar";
            this.Save_Progress_ProgressBar.Size = new System.Drawing.Size(471, 36);
            this.Save_Progress_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Save_Progress_ProgressBar.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 75;
            this.label1.Text = "Идет сохранение, подождите...";
            // 
            // Filter_GroupBox
            // 
            this.Filter_GroupBox.Controls.Add(this.Hide_Filter_Button);
            this.Filter_GroupBox.Controls.Add(this.Search_GroupBox);
            this.Filter_GroupBox.Controls.Add(this.Filtering_GroupBox);
            this.Filter_GroupBox.Controls.Add(this.Sorting_GroupBox);
            this.Filter_GroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Filter_GroupBox.Location = new System.Drawing.Point(8, 6);
            this.Filter_GroupBox.Name = "Filter_GroupBox";
            this.Filter_GroupBox.Size = new System.Drawing.Size(674, 386);
            this.Filter_GroupBox.TabIndex = 86;
            this.Filter_GroupBox.TabStop = false;
            this.Filter_GroupBox.Visible = false;
            // 
            // Hide_Filter_Button
            // 
            this.Hide_Filter_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Hide_Filter_Button.BackgroundImage = global::Testing.Properties.Resources.Back_Image;
            this.Hide_Filter_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Hide_Filter_Button.FlatAppearance.BorderSize = 0;
            this.Hide_Filter_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hide_Filter_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Hide_Filter_Button.Location = new System.Drawing.Point(6, 329);
            this.Hide_Filter_Button.Name = "Hide_Filter_Button";
            this.Hide_Filter_Button.Size = new System.Drawing.Size(656, 38);
            this.Hide_Filter_Button.TabIndex = 71;
            this.Info_ToolTip.SetToolTip(this.Hide_Filter_Button, "Свернуть фильтры");
            this.Hide_Filter_Button.UseVisualStyleBackColor = false;
            this.Hide_Filter_Button.Click += new System.EventHandler(this.Hide_Filter_Button_Click);
            // 
            // Search_GroupBox
            // 
            this.Search_GroupBox.Controls.Add(this.Search_Button);
            this.Search_GroupBox.Controls.Add(this.Search_TextBox);
            this.Search_GroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Search_GroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Search_GroupBox.Location = new System.Drawing.Point(6, 19);
            this.Search_GroupBox.Name = "Search_GroupBox";
            this.Search_GroupBox.Size = new System.Drawing.Size(656, 85);
            this.Search_GroupBox.TabIndex = 73;
            this.Search_GroupBox.TabStop = false;
            this.Search_GroupBox.Text = "Поиск";
            // 
            // Search_Button
            // 
            this.Search_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Search_Button.BackgroundImage = global::Testing.Properties.Resources.Search_Image;
            this.Search_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Search_Button.FlatAppearance.BorderSize = 0;
            this.Search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Search_Button.Location = new System.Drawing.Point(617, 32);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(33, 33);
            this.Search_Button.TabIndex = 89;
            this.Info_ToolTip.SetToolTip(this.Search_Button, "Поиск");
            this.Search_Button.UseVisualStyleBackColor = false;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Search_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Search_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Search_TextBox.Location = new System.Drawing.Point(23, 32);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(588, 33);
            this.Search_TextBox.TabIndex = 45;
            this.Info_ToolTip.SetToolTip(this.Search_TextBox, "Введите искомую информацию");
            // 
            // Filtering_GroupBox
            // 
            this.Filtering_GroupBox.Controls.Add(this.label2);
            this.Filtering_GroupBox.Controls.Add(this.Filtering_Full_Name_Tester_CheckBox);
            this.Filtering_GroupBox.Controls.Add(this.Filtering_Full_Name_Tester_ComboBox);
            this.Filtering_GroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Filtering_GroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Filtering_GroupBox.Location = new System.Drawing.Point(6, 110);
            this.Filtering_GroupBox.Name = "Filtering_GroupBox";
            this.Filtering_GroupBox.Size = new System.Drawing.Size(656, 110);
            this.Filtering_GroupBox.TabIndex = 71;
            this.Filtering_GroupBox.TabStop = false;
            this.Filtering_GroupBox.Text = "Фильтрация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 80;
            this.label2.Text = "ФИО тестера:";
            // 
            // Filtering_Full_Name_Tester_CheckBox
            // 
            this.Filtering_Full_Name_Tester_CheckBox.AutoSize = true;
            this.Filtering_Full_Name_Tester_CheckBox.Location = new System.Drawing.Point(630, 67);
            this.Filtering_Full_Name_Tester_CheckBox.Name = "Filtering_Full_Name_Tester_CheckBox";
            this.Filtering_Full_Name_Tester_CheckBox.Size = new System.Drawing.Size(15, 14);
            this.Filtering_Full_Name_Tester_CheckBox.TabIndex = 79;
            this.Info_ToolTip.SetToolTip(this.Filtering_Full_Name_Tester_CheckBox, "Фильтровать о ФИО тестера");
            this.Filtering_Full_Name_Tester_CheckBox.UseVisualStyleBackColor = true;
            this.Filtering_Full_Name_Tester_CheckBox.CheckedChanged += new System.EventHandler(this.Filtering_Full_Name_Tester_CheckBox_CheckedChanged);
            // 
            // Filtering_Full_Name_Tester_ComboBox
            // 
            this.Filtering_Full_Name_Tester_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Filtering_Full_Name_Tester_ComboBox.DropDownHeight = 150;
            this.Filtering_Full_Name_Tester_ComboBox.DropDownWidth = 200;
            this.Filtering_Full_Name_Tester_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filtering_Full_Name_Tester_ComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Filtering_Full_Name_Tester_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Filtering_Full_Name_Tester_ComboBox.FormattingEnabled = true;
            this.Filtering_Full_Name_Tester_ComboBox.IntegralHeight = false;
            this.Filtering_Full_Name_Tester_ComboBox.Location = new System.Drawing.Point(23, 58);
            this.Filtering_Full_Name_Tester_ComboBox.MaxDropDownItems = 4;
            this.Filtering_Full_Name_Tester_ComboBox.Name = "Filtering_Full_Name_Tester_ComboBox";
            this.Filtering_Full_Name_Tester_ComboBox.Size = new System.Drawing.Size(601, 33);
            this.Filtering_Full_Name_Tester_ComboBox.TabIndex = 78;
            this.Info_ToolTip.SetToolTip(this.Filtering_Full_Name_Tester_ComboBox, "Выберите ФИО тестера");
            this.Filtering_Full_Name_Tester_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Filtering_Full_Name_Tester_ComboBox_SelectedIndexChanged);
            // 
            // Sorting_GroupBox
            // 
            this.Sorting_GroupBox.Controls.Add(this.Sorting_ComboBox);
            this.Sorting_GroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Sorting_GroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Sorting_GroupBox.Location = new System.Drawing.Point(6, 226);
            this.Sorting_GroupBox.Name = "Sorting_GroupBox";
            this.Sorting_GroupBox.Size = new System.Drawing.Size(656, 97);
            this.Sorting_GroupBox.TabIndex = 72;
            this.Sorting_GroupBox.TabStop = false;
            this.Sorting_GroupBox.Text = "Сортировка";
            // 
            // Sorting_ComboBox
            // 
            this.Sorting_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Sorting_ComboBox.DropDownHeight = 150;
            this.Sorting_ComboBox.DropDownWidth = 200;
            this.Sorting_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sorting_ComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Sorting_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Sorting_ComboBox.FormattingEnabled = true;
            this.Sorting_ComboBox.IntegralHeight = false;
            this.Sorting_ComboBox.Items.AddRange(new object[] {
            "Без сортировки",
            "Название теста по убыванию",
            "Название теста по возрастанию",
            "Процент прохождения по убывания",
            "Процент прохождения по возрастанию",
            "Дата начала теста по убыванию",
            "Дата начала теста по возрастанию",
            "Время прохождения по убыванию",
            "Время прохождения по возрастанию"});
            this.Sorting_ComboBox.Location = new System.Drawing.Point(23, 43);
            this.Sorting_ComboBox.MaxDropDownItems = 4;
            this.Sorting_ComboBox.Name = "Sorting_ComboBox";
            this.Sorting_ComboBox.Size = new System.Drawing.Size(616, 33);
            this.Sorting_ComboBox.TabIndex = 78;
            this.Sorting_ComboBox.Text = "Без сортировки";
            this.Info_ToolTip.SetToolTip(this.Sorting_ComboBox, "Выберите тип сортировки");
            this.Sorting_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Sorting_ComboBox_SelectedIndexChanged);
            // 
            // Upload_In_Excel_Button
            // 
            this.Upload_In_Excel_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Upload_In_Excel_Button.BackgroundImage = global::Testing.Properties.Resources.Export_Excel_Image;
            this.Upload_In_Excel_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Upload_In_Excel_Button.FlatAppearance.BorderSize = 0;
            this.Upload_In_Excel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Upload_In_Excel_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Upload_In_Excel_Button.Location = new System.Drawing.Point(956, 988);
            this.Upload_In_Excel_Button.Name = "Upload_In_Excel_Button";
            this.Upload_In_Excel_Button.Size = new System.Drawing.Size(80, 80);
            this.Upload_In_Excel_Button.TabIndex = 71;
            this.Upload_In_Excel_Button.UseVisualStyleBackColor = false;
            this.Upload_In_Excel_Button.Click += new System.EventHandler(this.Upload_In_Excel_Button_Click);
            // 
            // Resetting_Filter_Button
            // 
            this.Resetting_Filter_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Resetting_Filter_Button.BackgroundImage = global::Testing.Properties.Resources.Not_Filtering_Image;
            this.Resetting_Filter_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Resetting_Filter_Button.FlatAppearance.BorderSize = 0;
            this.Resetting_Filter_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resetting_Filter_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Resetting_Filter_Button.Location = new System.Drawing.Point(870, 988);
            this.Resetting_Filter_Button.Name = "Resetting_Filter_Button";
            this.Resetting_Filter_Button.Size = new System.Drawing.Size(80, 80);
            this.Resetting_Filter_Button.TabIndex = 70;
            this.Resetting_Filter_Button.UseVisualStyleBackColor = false;
            this.Resetting_Filter_Button.Click += new System.EventHandler(this.Resetting_Filter_Button_Click);
            // 
            // Filtering_Open_button
            // 
            this.Filtering_Open_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Filtering_Open_button.BackgroundImage = global::Testing.Properties.Resources.Filter_Image;
            this.Filtering_Open_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Filtering_Open_button.FlatAppearance.BorderSize = 0;
            this.Filtering_Open_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filtering_Open_button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Filtering_Open_button.Location = new System.Drawing.Point(784, 988);
            this.Filtering_Open_button.Name = "Filtering_Open_button";
            this.Filtering_Open_button.Size = new System.Drawing.Size(80, 80);
            this.Filtering_Open_button.TabIndex = 68;
            this.Filtering_Open_button.UseVisualStyleBackColor = false;
            this.Filtering_Open_button.Click += new System.EventHandler(this.Filtering_Open_button_Click);
            // 
            // Close_Form_Button
            // 
            this.Close_Form_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Close_Form_Button.BackgroundImage = global::Testing.Properties.Resources.Back_Image;
            this.Close_Form_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Close_Form_Button.FlatAppearance.BorderSize = 0;
            this.Close_Form_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Form_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Close_Form_Button.Location = new System.Drawing.Point(1042, 988);
            this.Close_Form_Button.Name = "Close_Form_Button";
            this.Close_Form_Button.Size = new System.Drawing.Size(80, 80);
            this.Close_Form_Button.TabIndex = 65;
            this.Close_Form_Button.UseVisualStyleBackColor = false;
            this.Close_Form_Button.Click += new System.EventHandler(this.Close_Form_Button_Click);
            // 
            // Test_Result_DataGridView
            // 
            this.Test_Result_DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Test_Result_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Test_Result_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Test_Result_DataGridView.Location = new System.Drawing.Point(6, 6);
            this.Test_Result_DataGridView.Name = "Test_Result_DataGridView";
            this.Test_Result_DataGridView.Size = new System.Drawing.Size(1896, 976);
            this.Test_Result_DataGridView.TabIndex = 84;
            // 
            // First_Entry_Button
            // 
            this.First_Entry_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.First_Entry_Button.BackgroundImage = global::Testing.Properties.Resources.First_Entry_Image;
            this.First_Entry_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.First_Entry_Button.FlatAppearance.BorderSize = 0;
            this.First_Entry_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.First_Entry_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.First_Entry_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.First_Entry_Button.Location = new System.Drawing.Point(126, 988);
            this.First_Entry_Button.Name = "First_Entry_Button";
            this.First_Entry_Button.Size = new System.Drawing.Size(108, 80);
            this.First_Entry_Button.TabIndex = 111;
            this.First_Entry_Button.UseVisualStyleBackColor = false;
            this.First_Entry_Button.Click += new System.EventHandler(this.First_Entry_Button_Click);
            // 
            // Last_Entry_Button
            // 
            this.Last_Entry_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Last_Entry_Button.BackgroundImage = global::Testing.Properties.Resources.Last_Entry_Image;
            this.Last_Entry_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Last_Entry_Button.FlatAppearance.BorderSize = 0;
            this.Last_Entry_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Last_Entry_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Last_Entry_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Last_Entry_Button.Location = new System.Drawing.Point(1686, 988);
            this.Last_Entry_Button.Name = "Last_Entry_Button";
            this.Last_Entry_Button.Size = new System.Drawing.Size(108, 80);
            this.Last_Entry_Button.TabIndex = 110;
            this.Last_Entry_Button.UseVisualStyleBackColor = false;
            this.Last_Entry_Button.Click += new System.EventHandler(this.Last_Entry_Button_Click);
            // 
            // Next_Entry_Button
            // 
            this.Next_Entry_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Next_Entry_Button.BackgroundImage = global::Testing.Properties.Resources.Next_Entry_Image;
            this.Next_Entry_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Next_Entry_Button.FlatAppearance.BorderSize = 0;
            this.Next_Entry_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_Entry_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Next_Entry_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Next_Entry_Button.Location = new System.Drawing.Point(1800, 988);
            this.Next_Entry_Button.Name = "Next_Entry_Button";
            this.Next_Entry_Button.Size = new System.Drawing.Size(108, 80);
            this.Next_Entry_Button.TabIndex = 109;
            this.Next_Entry_Button.UseVisualStyleBackColor = false;
            this.Next_Entry_Button.Click += new System.EventHandler(this.Next_Entry_Button_Click);
            // 
            // Previos_Entry_Button
            // 
            this.Previos_Entry_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Previos_Entry_Button.BackgroundImage = global::Testing.Properties.Resources.Previos_Entry_Image;
            this.Previos_Entry_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Previos_Entry_Button.FlatAppearance.BorderSize = 0;
            this.Previos_Entry_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previos_Entry_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Previos_Entry_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Previos_Entry_Button.Location = new System.Drawing.Point(12, 988);
            this.Previos_Entry_Button.Name = "Previos_Entry_Button";
            this.Previos_Entry_Button.Size = new System.Drawing.Size(108, 80);
            this.Previos_Entry_Button.TabIndex = 108;
            this.Previos_Entry_Button.UseVisualStyleBackColor = false;
            this.Previos_Entry_Button.Click += new System.EventHandler(this.Previos_Entry_Button_Click);
            // 
            // Statistic_User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.First_Entry_Button);
            this.Controls.Add(this.Last_Entry_Button);
            this.Controls.Add(this.Next_Entry_Button);
            this.Controls.Add(this.Previos_Entry_Button);
            this.Controls.Add(this.Upload_In_Excel_Button);
            this.Controls.Add(this.save_Progress_GroupBox);
            this.Controls.Add(this.Resetting_Filter_Button);
            this.Controls.Add(this.Filter_GroupBox);
            this.Controls.Add(this.Filtering_Open_button);
            this.Controls.Add(this.Close_Form_Button);
            this.Controls.Add(this.Test_Result_DataGridView);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Statistic_User_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            this.save_Progress_GroupBox.ResumeLayout(false);
            this.save_Progress_GroupBox.PerformLayout();
            this.Filter_GroupBox.ResumeLayout(false);
            this.Search_GroupBox.ResumeLayout(false);
            this.Search_GroupBox.PerformLayout();
            this.Filtering_GroupBox.ResumeLayout(false);
            this.Filtering_GroupBox.PerformLayout();
            this.Sorting_GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Test_Result_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox save_Progress_GroupBox;
        private System.Windows.Forms.ProgressBar Save_Progress_ProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Filter_GroupBox;
        private System.Windows.Forms.Button Hide_Filter_Button;
        private System.Windows.Forms.GroupBox Search_GroupBox;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.GroupBox Filtering_GroupBox;
        private System.Windows.Forms.GroupBox Sorting_GroupBox;
        private System.Windows.Forms.ComboBox Sorting_ComboBox;
        private System.Windows.Forms.Button Upload_In_Excel_Button;
        private System.Windows.Forms.Button Resetting_Filter_Button;
        private System.Windows.Forms.Button Filtering_Open_button;
        private System.Windows.Forms.Button Close_Form_Button;
        private System.Windows.Forms.DataGridView Test_Result_DataGridView;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Filtering_Full_Name_Tester_CheckBox;
        private System.Windows.Forms.ComboBox Filtering_Full_Name_Tester_ComboBox;
        private System.Windows.Forms.Button First_Entry_Button;
        private System.Windows.Forms.Button Last_Entry_Button;
        private System.Windows.Forms.Button Next_Entry_Button;
        private System.Windows.Forms.Button Previos_Entry_Button;
        private System.Windows.Forms.ToolTip Info_ToolTip;
    }
}