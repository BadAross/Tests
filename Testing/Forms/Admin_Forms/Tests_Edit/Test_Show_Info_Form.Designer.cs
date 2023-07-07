namespace Testing.Forms.Admin.Tests_Edit
{
    partial class Test_Show_Info_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test_Show_Info_Form));
            this.Number_Entry_Label = new System.Windows.Forms.Label();
            this.save_Progress_GroupBox = new System.Windows.Forms.GroupBox();
            this.Save_Progress_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Filter_GroupBox = new System.Windows.Forms.GroupBox();
            this.Hide_Filter_Button = new System.Windows.Forms.Button();
            this.Search_GroupBox = new System.Windows.Forms.GroupBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.Filtering_GroupBox = new System.Windows.Forms.GroupBox();
            this.Filtering_Full_Name_CheckBox = new System.Windows.Forms.CheckBox();
            this.Filtering_Full_Name_User_Label = new System.Windows.Forms.Label();
            this.Filtering_Full_Name_Tester_ComboBox = new System.Windows.Forms.ComboBox();
            this.Sorting_GroupBox = new System.Windows.Forms.GroupBox();
            this.Sorting_ComboBox = new System.Windows.Forms.ComboBox();
            this.Tests_DataGridView = new System.Windows.Forms.DataGridView();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Fiter_Reset_Button = new System.Windows.Forms.Button();
            this.Delete_Entry_Button = new System.Windows.Forms.Button();
            this.Export_Excel_Button = new System.Windows.Forms.Button();
            this.Filter_Show_Button = new System.Windows.Forms.Button();
            this.First_Entry_Button = new System.Windows.Forms.Button();
            this.Last_Entry_Button = new System.Windows.Forms.Button();
            this.Next_Entry_Button = new System.Windows.Forms.Button();
            this.Previos_Entry_Button = new System.Windows.Forms.Button();
            this.Update_DataGridView_Button = new System.Windows.Forms.Button();
            this.save_Progress_GroupBox.SuspendLayout();
            this.Filter_GroupBox.SuspendLayout();
            this.Search_GroupBox.SuspendLayout();
            this.Filtering_GroupBox.SuspendLayout();
            this.Sorting_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tests_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Number_Entry_Label
            // 
            this.Number_Entry_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number_Entry_Label.Location = new System.Drawing.Point(818, 960);
            this.Number_Entry_Label.Name = "Number_Entry_Label";
            this.Number_Entry_Label.Size = new System.Drawing.Size(280, 25);
            this.Number_Entry_Label.TabIndex = 131;
            this.Number_Entry_Label.Text = "1 из 10000";
            this.Number_Entry_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // save_Progress_GroupBox
            // 
            this.save_Progress_GroupBox.Controls.Add(this.Save_Progress_ProgressBar);
            this.save_Progress_GroupBox.Controls.Add(this.label1);
            this.save_Progress_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.save_Progress_GroupBox.Location = new System.Drawing.Point(721, 27);
            this.save_Progress_GroupBox.Name = "save_Progress_GroupBox";
            this.save_Progress_GroupBox.Size = new System.Drawing.Size(483, 93);
            this.save_Progress_GroupBox.TabIndex = 119;
            this.save_Progress_GroupBox.TabStop = false;
            this.save_Progress_GroupBox.Visible = false;
            // 
            // Save_Progress_ProgressBar
            // 
            this.Save_Progress_ProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Save_Progress_ProgressBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Save_Progress_ProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
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
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
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
            this.Filter_GroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filter_GroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 1F, System.Drawing.FontStyle.Bold);
            this.Filter_GroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(218)))), ((int)(((byte)(205)))));
            this.Filter_GroupBox.Location = new System.Drawing.Point(28, 27);
            this.Filter_GroupBox.Name = "Filter_GroupBox";
            this.Filter_GroupBox.Size = new System.Drawing.Size(674, 381);
            this.Filter_GroupBox.TabIndex = 118;
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
            this.Hide_Filter_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.Hide_Filter_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Hide_Filter_Button.Location = new System.Drawing.Point(6, 315);
            this.Hide_Filter_Button.Name = "Hide_Filter_Button";
            this.Hide_Filter_Button.Size = new System.Drawing.Size(656, 49);
            this.Hide_Filter_Button.TabIndex = 71;
            this.Hide_Filter_Button.UseVisualStyleBackColor = false;
            this.Hide_Filter_Button.Click += new System.EventHandler(this.Hide_Filter_Button_Click);
            // 
            // Search_GroupBox
            // 
            this.Search_GroupBox.Controls.Add(this.Search_Button);
            this.Search_GroupBox.Controls.Add(this.Search_TextBox);
            this.Search_GroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Search_GroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Search_GroupBox.Location = new System.Drawing.Point(6, 8);
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
            this.Search_Button.Location = new System.Drawing.Point(614, 32);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(32, 32);
            this.Search_Button.TabIndex = 74;
            this.Search_Button.UseVisualStyleBackColor = false;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Search_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.Search_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Search_TextBox.Location = new System.Drawing.Point(23, 32);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(585, 32);
            this.Search_TextBox.TabIndex = 45;
            // 
            // Filtering_GroupBox
            // 
            this.Filtering_GroupBox.Controls.Add(this.Filtering_Full_Name_CheckBox);
            this.Filtering_GroupBox.Controls.Add(this.Filtering_Full_Name_User_Label);
            this.Filtering_GroupBox.Controls.Add(this.Filtering_Full_Name_Tester_ComboBox);
            this.Filtering_GroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Filtering_GroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Filtering_GroupBox.Location = new System.Drawing.Point(6, 99);
            this.Filtering_GroupBox.Name = "Filtering_GroupBox";
            this.Filtering_GroupBox.Size = new System.Drawing.Size(656, 107);
            this.Filtering_GroupBox.TabIndex = 71;
            this.Filtering_GroupBox.TabStop = false;
            this.Filtering_GroupBox.Text = "Фильтрация";
            // 
            // Filtering_Full_Name_CheckBox
            // 
            this.Filtering_Full_Name_CheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Filtering_Full_Name_CheckBox.FlatAppearance.BorderSize = 0;
            this.Filtering_Full_Name_CheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold);
            this.Filtering_Full_Name_CheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Filtering_Full_Name_CheckBox.Location = new System.Drawing.Point(631, 64);
            this.Filtering_Full_Name_CheckBox.Name = "Filtering_Full_Name_CheckBox";
            this.Filtering_Full_Name_CheckBox.Size = new System.Drawing.Size(12, 11);
            this.Filtering_Full_Name_CheckBox.TabIndex = 76;
            this.Filtering_Full_Name_CheckBox.UseVisualStyleBackColor = false;
            this.Filtering_Full_Name_CheckBox.CheckedChanged += new System.EventHandler(this.Filtering_Full_Name_CheckBox_CheckedChanged);
            // 
            // Filtering_Full_Name_User_Label
            // 
            this.Filtering_Full_Name_User_Label.AutoSize = true;
            this.Filtering_Full_Name_User_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Filtering_Full_Name_User_Label.Location = new System.Drawing.Point(28, 29);
            this.Filtering_Full_Name_User_Label.Name = "Filtering_Full_Name_User_Label";
            this.Filtering_Full_Name_User_Label.Size = new System.Drawing.Size(61, 25);
            this.Filtering_Full_Name_User_Label.TabIndex = 74;
            this.Filtering_Full_Name_User_Label.Text = "ФИО:";
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
            this.Filtering_Full_Name_Tester_ComboBox.Location = new System.Drawing.Point(23, 57);
            this.Filtering_Full_Name_Tester_ComboBox.MaxDropDownItems = 4;
            this.Filtering_Full_Name_Tester_ComboBox.Name = "Filtering_Full_Name_Tester_ComboBox";
            this.Filtering_Full_Name_Tester_ComboBox.Size = new System.Drawing.Size(601, 33);
            this.Filtering_Full_Name_Tester_ComboBox.TabIndex = 3;
            this.Filtering_Full_Name_Tester_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Filtering_Full_Name_Tester_ComboBox_SelectedIndexChanged);
            // 
            // Sorting_GroupBox
            // 
            this.Sorting_GroupBox.Controls.Add(this.Sorting_ComboBox);
            this.Sorting_GroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Sorting_GroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Sorting_GroupBox.Location = new System.Drawing.Point(6, 212);
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
            "ФИО по убыванию",
            "ФИО по возрастанию"});
            this.Sorting_ComboBox.Location = new System.Drawing.Point(23, 43);
            this.Sorting_ComboBox.MaxDropDownItems = 4;
            this.Sorting_ComboBox.Name = "Sorting_ComboBox";
            this.Sorting_ComboBox.Size = new System.Drawing.Size(616, 33);
            this.Sorting_ComboBox.TabIndex = 78;
            this.Sorting_ComboBox.Text = "Без сортировки";
            this.Sorting_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Sorting_ComboBox_SelectedIndexChanged);
            // 
            // Tests_DataGridView
            // 
            this.Tests_DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Tests_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tests_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tests_DataGridView.Location = new System.Drawing.Point(12, 12);
            this.Tests_DataGridView.Name = "Tests_DataGridView";
            this.Tests_DataGridView.Size = new System.Drawing.Size(1896, 945);
            this.Tests_DataGridView.TabIndex = 117;
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Exit_Button.BackgroundImage = global::Testing.Properties.Resources.Back_Image;
            this.Exit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Exit_Button.Location = new System.Drawing.Point(1136, 988);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(80, 80);
            this.Exit_Button.TabIndex = 130;
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Fiter_Reset_Button
            // 
            this.Fiter_Reset_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Fiter_Reset_Button.BackgroundImage = global::Testing.Properties.Resources.Not_Filtering_Image;
            this.Fiter_Reset_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fiter_Reset_Button.FlatAppearance.BorderSize = 0;
            this.Fiter_Reset_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fiter_Reset_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Fiter_Reset_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Fiter_Reset_Button.Location = new System.Drawing.Point(878, 988);
            this.Fiter_Reset_Button.Name = "Fiter_Reset_Button";
            this.Fiter_Reset_Button.Size = new System.Drawing.Size(80, 80);
            this.Fiter_Reset_Button.TabIndex = 129;
            this.Fiter_Reset_Button.UseVisualStyleBackColor = false;
            this.Fiter_Reset_Button.Click += new System.EventHandler(this.Fiter_Reset_Button_Click);
            // 
            // Delete_Entry_Button
            // 
            this.Delete_Entry_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Delete_Entry_Button.BackgroundImage = global::Testing.Properties.Resources.Delete_Image;
            this.Delete_Entry_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Delete_Entry_Button.FlatAppearance.BorderSize = 0;
            this.Delete_Entry_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Entry_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Delete_Entry_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Delete_Entry_Button.Location = new System.Drawing.Point(706, 988);
            this.Delete_Entry_Button.Name = "Delete_Entry_Button";
            this.Delete_Entry_Button.Size = new System.Drawing.Size(80, 80);
            this.Delete_Entry_Button.TabIndex = 127;
            this.Delete_Entry_Button.UseVisualStyleBackColor = false;
            this.Delete_Entry_Button.Click += new System.EventHandler(this.Delete_Entry_Button_Click);
            // 
            // Export_Excel_Button
            // 
            this.Export_Excel_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Export_Excel_Button.BackgroundImage = global::Testing.Properties.Resources.Export_Excel_Image;
            this.Export_Excel_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Export_Excel_Button.FlatAppearance.BorderSize = 0;
            this.Export_Excel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export_Excel_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Export_Excel_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Export_Excel_Button.Location = new System.Drawing.Point(964, 988);
            this.Export_Excel_Button.Name = "Export_Excel_Button";
            this.Export_Excel_Button.Size = new System.Drawing.Size(80, 80);
            this.Export_Excel_Button.TabIndex = 126;
            this.Export_Excel_Button.UseVisualStyleBackColor = false;
            this.Export_Excel_Button.Click += new System.EventHandler(this.Export_Excel_Button_Click);
            // 
            // Filter_Show_Button
            // 
            this.Filter_Show_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Filter_Show_Button.BackgroundImage = global::Testing.Properties.Resources.Filter_Image;
            this.Filter_Show_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Filter_Show_Button.FlatAppearance.BorderSize = 0;
            this.Filter_Show_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filter_Show_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Filter_Show_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Filter_Show_Button.Location = new System.Drawing.Point(792, 988);
            this.Filter_Show_Button.Name = "Filter_Show_Button";
            this.Filter_Show_Button.Size = new System.Drawing.Size(80, 80);
            this.Filter_Show_Button.TabIndex = 125;
            this.Filter_Show_Button.UseVisualStyleBackColor = false;
            this.Filter_Show_Button.Click += new System.EventHandler(this.Filter_Show_Button_Click);
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
            this.First_Entry_Button.TabIndex = 124;
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
            this.Last_Entry_Button.TabIndex = 123;
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
            this.Next_Entry_Button.TabIndex = 122;
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
            this.Previos_Entry_Button.TabIndex = 121;
            this.Previos_Entry_Button.UseVisualStyleBackColor = false;
            this.Previos_Entry_Button.Click += new System.EventHandler(this.Previos_Entry_Button_Click);
            // 
            // Update_DataGridView_Button
            // 
            this.Update_DataGridView_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Update_DataGridView_Button.BackgroundImage = global::Testing.Properties.Resources.Update_Image;
            this.Update_DataGridView_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Update_DataGridView_Button.FlatAppearance.BorderSize = 0;
            this.Update_DataGridView_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_DataGridView_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Update_DataGridView_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Update_DataGridView_Button.Location = new System.Drawing.Point(1050, 988);
            this.Update_DataGridView_Button.Name = "Update_DataGridView_Button";
            this.Update_DataGridView_Button.Size = new System.Drawing.Size(80, 80);
            this.Update_DataGridView_Button.TabIndex = 120;
            this.Update_DataGridView_Button.UseVisualStyleBackColor = false;
            this.Update_DataGridView_Button.Click += new System.EventHandler(this.Update_DataGridView_Button_Click);
            // 
            // Test_Show_Info_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.Number_Entry_Label);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Fiter_Reset_Button);
            this.Controls.Add(this.Delete_Entry_Button);
            this.Controls.Add(this.Export_Excel_Button);
            this.Controls.Add(this.Filter_Show_Button);
            this.Controls.Add(this.First_Entry_Button);
            this.Controls.Add(this.Last_Entry_Button);
            this.Controls.Add(this.Next_Entry_Button);
            this.Controls.Add(this.Previos_Entry_Button);
            this.Controls.Add(this.Update_DataGridView_Button);
            this.Controls.Add(this.save_Progress_GroupBox);
            this.Controls.Add(this.Filter_GroupBox);
            this.Controls.Add(this.Tests_DataGridView);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Test_Show_Info_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тесты";
            this.save_Progress_GroupBox.ResumeLayout(false);
            this.save_Progress_GroupBox.PerformLayout();
            this.Filter_GroupBox.ResumeLayout(false);
            this.Search_GroupBox.ResumeLayout(false);
            this.Search_GroupBox.PerformLayout();
            this.Filtering_GroupBox.ResumeLayout(false);
            this.Filtering_GroupBox.PerformLayout();
            this.Sorting_GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tests_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Number_Entry_Label;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button Fiter_Reset_Button;
        private System.Windows.Forms.Button Delete_Entry_Button;
        private System.Windows.Forms.Button Export_Excel_Button;
        private System.Windows.Forms.Button Filter_Show_Button;
        private System.Windows.Forms.Button First_Entry_Button;
        private System.Windows.Forms.Button Last_Entry_Button;
        private System.Windows.Forms.Button Next_Entry_Button;
        private System.Windows.Forms.Button Previos_Entry_Button;
        private System.Windows.Forms.Button Update_DataGridView_Button;
        private System.Windows.Forms.GroupBox save_Progress_GroupBox;
        private System.Windows.Forms.ProgressBar Save_Progress_ProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Filter_GroupBox;
        private System.Windows.Forms.Button Hide_Filter_Button;
        private System.Windows.Forms.GroupBox Search_GroupBox;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.GroupBox Filtering_GroupBox;
        private System.Windows.Forms.CheckBox Filtering_Full_Name_CheckBox;
        private System.Windows.Forms.Label Filtering_Full_Name_User_Label;
        private System.Windows.Forms.ComboBox Filtering_Full_Name_Tester_ComboBox;
        private System.Windows.Forms.GroupBox Sorting_GroupBox;
        private System.Windows.Forms.ComboBox Sorting_ComboBox;
        private System.Windows.Forms.DataGridView Tests_DataGridView;
    }
}