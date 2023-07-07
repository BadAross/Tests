namespace Testing.Forms
{
    partial class Test_Result_Form
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
            this.Result_Label = new System.Windows.Forms.Label();
            this.Number_Correct_Answers_Label = new System.Windows.Forms.Label();
            this.Close_Batton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Result_Label
            // 
            this.Result_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Result_Label.Font = new System.Drawing.Font("Segoe UI Symbol", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_Label.Location = new System.Drawing.Point(12, 9);
            this.Result_Label.Name = "Result_Label";
            this.Result_Label.Size = new System.Drawing.Size(456, 139);
            this.Result_Label.TabIndex = 2;
            this.Result_Label.Text = "100%";
            this.Result_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Number_Correct_Answers_Label
            // 
            this.Number_Correct_Answers_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Number_Correct_Answers_Label.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Correct_Answers_Label.Location = new System.Drawing.Point(12, 148);
            this.Number_Correct_Answers_Label.Name = "Number_Correct_Answers_Label";
            this.Number_Correct_Answers_Label.Size = new System.Drawing.Size(456, 60);
            this.Number_Correct_Answers_Label.TabIndex = 3;
            this.Number_Correct_Answers_Label.Text = "999 из 999";
            this.Number_Correct_Answers_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Close_Batton
            // 
            this.Close_Batton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.Close_Batton.BackgroundImage = global::Testing.Properties.Resources.Back_Image;
            this.Close_Batton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Close_Batton.FlatAppearance.BorderSize = 0;
            this.Close_Batton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Batton.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Batton.Location = new System.Drawing.Point(19, 211);
            this.Close_Batton.Name = "Close_Batton";
            this.Close_Batton.Size = new System.Drawing.Size(449, 71);
            this.Close_Batton.TabIndex = 5;
            this.Close_Batton.UseVisualStyleBackColor = false;
            this.Close_Batton.Click += new System.EventHandler(this.Close_Batton_Click);
            // 
            // Test_Result_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(480, 300);
            this.Controls.Add(this.Close_Batton);
            this.Controls.Add(this.Number_Correct_Answers_Label);
            this.Controls.Add(this.Result_Label);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(220)))), ((int)(((byte)(162)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Test_Result_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результат";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Result_Label;
        private System.Windows.Forms.Label Number_Correct_Answers_Label;
        private System.Windows.Forms.Button Close_Batton;
    }
}