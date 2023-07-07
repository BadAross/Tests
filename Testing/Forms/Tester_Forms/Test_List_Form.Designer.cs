namespace Testing.Forms.Tester_Form
{
    partial class Test_List_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test_List_Form));
            this.New_Test_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Delete_Test_Button = new System.Windows.Forms.Button();
            this.Edit_Test_Button = new System.Windows.Forms.Button();
            this.Tests_DataGridView = new System.Windows.Forms.DataGridView();
            this.Info_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Tests_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // New_Test_Button
            // 
            this.New_Test_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.New_Test_Button.BackgroundImage = global::Testing.Properties.Resources.New_Entry_Image;
            this.New_Test_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.New_Test_Button.FlatAppearance.BorderSize = 0;
            this.New_Test_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_Test_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.New_Test_Button.Location = new System.Drawing.Point(706, 12);
            this.New_Test_Button.Name = "New_Test_Button";
            this.New_Test_Button.Size = new System.Drawing.Size(80, 80);
            this.New_Test_Button.TabIndex = 6;
            this.Info_ToolTip.SetToolTip(this.New_Test_Button, "Новый тест");
            this.New_Test_Button.UseVisualStyleBackColor = false;
            this.New_Test_Button.Click += new System.EventHandler(this.New_Test_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Back_Button.BackgroundImage = global::Testing.Properties.Resources.Back_Image;
            this.Back_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Back_Button.FlatAppearance.BorderSize = 0;
            this.Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Back_Button.Location = new System.Drawing.Point(706, 270);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(80, 80);
            this.Back_Button.TabIndex = 11;
            this.Info_ToolTip.SetToolTip(this.Back_Button, "Вернуться в меню");
            this.Back_Button.UseVisualStyleBackColor = false;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Delete_Test_Button
            // 
            this.Delete_Test_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Delete_Test_Button.BackgroundImage = global::Testing.Properties.Resources.Delete_Image;
            this.Delete_Test_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Delete_Test_Button.FlatAppearance.BorderSize = 0;
            this.Delete_Test_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Test_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Delete_Test_Button.Location = new System.Drawing.Point(706, 184);
            this.Delete_Test_Button.Name = "Delete_Test_Button";
            this.Delete_Test_Button.Size = new System.Drawing.Size(80, 80);
            this.Delete_Test_Button.TabIndex = 12;
            this.Info_ToolTip.SetToolTip(this.Delete_Test_Button, "Удалить тест");
            this.Delete_Test_Button.UseVisualStyleBackColor = false;
            this.Delete_Test_Button.Click += new System.EventHandler(this.Delete_Test_Button_Click);
            // 
            // Edit_Test_Button
            // 
            this.Edit_Test_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Edit_Test_Button.BackgroundImage = global::Testing.Properties.Resources.Editing_Entry_Image;
            this.Edit_Test_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Edit_Test_Button.FlatAppearance.BorderSize = 0;
            this.Edit_Test_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Test_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Edit_Test_Button.Location = new System.Drawing.Point(706, 98);
            this.Edit_Test_Button.Name = "Edit_Test_Button";
            this.Edit_Test_Button.Size = new System.Drawing.Size(80, 80);
            this.Edit_Test_Button.TabIndex = 13;
            this.Info_ToolTip.SetToolTip(this.Edit_Test_Button, "Измениить тест");
            this.Edit_Test_Button.UseVisualStyleBackColor = false;
            this.Edit_Test_Button.Click += new System.EventHandler(this.Edit_Test_Button_Click);
            // 
            // Tests_DataGridView
            // 
            this.Tests_DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Tests_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tests_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tests_DataGridView.Location = new System.Drawing.Point(12, 12);
            this.Tests_DataGridView.Name = "Tests_DataGridView";
            this.Tests_DataGridView.Size = new System.Drawing.Size(688, 338);
            this.Tests_DataGridView.TabIndex = 14;
            this.Info_ToolTip.SetToolTip(this.Tests_DataGridView, "Ваши тесты");
            // 
            // Test_List_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(803, 364);
            this.Controls.Add(this.Tests_DataGridView);
            this.Controls.Add(this.Edit_Test_Button);
            this.Controls.Add(this.Delete_Test_Button);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.New_Test_Button);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Test_List_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мои тесты";
            ((System.ComponentModel.ISupportInitialize)(this.Tests_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button New_Test_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Delete_Test_Button;
        private System.Windows.Forms.Button Edit_Test_Button;
        private System.Windows.Forms.DataGridView Tests_DataGridView;
        private System.Windows.Forms.ToolTip Info_ToolTip;
    }
}