namespace Testing.Forms
{
    partial class Сapcha_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Сapcha_Form));
            this.Capcha_PictureBox = new System.Windows.Forms.PictureBox();
            this.Capcha_TextBox = new System.Windows.Forms.TextBox();
            this.Сonfirm_Button = new System.Windows.Forms.Button();
            this.Change_Button = new System.Windows.Forms.Button();
            this.Block_Timer = new System.Windows.Forms.Timer(this.components);
            this.Info_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Capcha_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Capcha_PictureBox
            // 
            this.Capcha_PictureBox.Location = new System.Drawing.Point(12, 12);
            this.Capcha_PictureBox.Name = "Capcha_PictureBox";
            this.Capcha_PictureBox.Size = new System.Drawing.Size(422, 240);
            this.Capcha_PictureBox.TabIndex = 0;
            this.Capcha_PictureBox.TabStop = false;
            this.Info_ToolTip.SetToolTip(this.Capcha_PictureBox, "Капча");
            // 
            // Capcha_TextBox
            // 
            this.Capcha_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.Capcha_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Capcha_TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Capcha_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.Capcha_TextBox.Location = new System.Drawing.Point(148, 258);
            this.Capcha_TextBox.Name = "Capcha_TextBox";
            this.Capcha_TextBox.Size = new System.Drawing.Size(165, 33);
            this.Capcha_TextBox.TabIndex = 2;
            this.Info_ToolTip.SetToolTip(this.Capcha_TextBox, "Введите текст с картинки");
            // 
            // Сonfirm_Button
            // 
            this.Сonfirm_Button.FlatAppearance.BorderSize = 0;
            this.Сonfirm_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Сonfirm_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Сonfirm_Button.Location = new System.Drawing.Point(12, 297);
            this.Сonfirm_Button.Name = "Сonfirm_Button";
            this.Сonfirm_Button.Size = new System.Drawing.Size(208, 38);
            this.Сonfirm_Button.TabIndex = 5;
            this.Сonfirm_Button.Text = "Подвердить";
            this.Info_ToolTip.SetToolTip(this.Сonfirm_Button, "Поддвердить капчу");
            this.Сonfirm_Button.UseVisualStyleBackColor = true;
            this.Сonfirm_Button.Click += new System.EventHandler(this.Сonfirm_Batton_Click);
            // 
            // Change_Button
            // 
            this.Change_Button.FlatAppearance.BorderSize = 0;
            this.Change_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Change_Button.Location = new System.Drawing.Point(226, 297);
            this.Change_Button.Name = "Change_Button";
            this.Change_Button.Size = new System.Drawing.Size(208, 38);
            this.Change_Button.TabIndex = 6;
            this.Change_Button.Text = "Изменить";
            this.Info_ToolTip.SetToolTip(this.Change_Button, "Изменить капчу");
            this.Change_Button.UseVisualStyleBackColor = true;
            this.Change_Button.Click += new System.EventHandler(this.Change_Button_Click);
            // 
            // Block_Timer
            // 
            this.Block_Timer.Interval = 1000;
            this.Block_Timer.Tick += new System.EventHandler(this.Block_Timer_Tick);
            // 
            // Сapcha_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(446, 349);
            this.Controls.Add(this.Change_Button);
            this.Controls.Add(this.Сonfirm_Button);
            this.Controls.Add(this.Capcha_TextBox);
            this.Controls.Add(this.Capcha_PictureBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Сapcha_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Не верный пароль";
            ((System.ComponentModel.ISupportInitialize)(this.Capcha_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Capcha_PictureBox;
        private System.Windows.Forms.TextBox Capcha_TextBox;
        private System.Windows.Forms.Button Сonfirm_Button;
        private System.Windows.Forms.Button Change_Button;
        private System.Windows.Forms.Timer Block_Timer;
        private System.Windows.Forms.ToolTip Info_ToolTip;
    }
}