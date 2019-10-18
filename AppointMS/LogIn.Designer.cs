namespace c969_Fickenscher
{
    partial class LogIn
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
            this.LogInLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ResponseLabel = new System.Windows.Forms.Label();
            this.LogInCancelButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogInLabel
            // 
            this.LogInLabel.AutoSize = true;
            this.LogInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInLabel.ForeColor = System.Drawing.Color.Gray;
            this.LogInLabel.Location = new System.Drawing.Point(13, 13);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(67, 15);
            this.LogInLabel.TabIndex = 99;
            this.LogInLabel.Text = "AppointMS";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(73, 61);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(52, 12);
            this.UserNameLabel.TabIndex = 98;
            this.UserNameLabel.Text = "User Name";
            // 
            // UserNameField
            // 
            this.UserNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserNameField.Location = new System.Drawing.Point(75, 76);
            this.UserNameField.MaxLength = 255;
            this.UserNameField.Name = "UserNameField";
            this.UserNameField.Size = new System.Drawing.Size(150, 18);
            this.UserNameField.TabIndex = 0;
            this.UserNameField.TextChanged += new System.EventHandler(this.LogInFields_TextChanged);
            // 
            // PasswordField
            // 
            this.PasswordField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordField.Location = new System.Drawing.Point(75, 124);
            this.PasswordField.MaxLength = 255;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(150, 18);
            this.PasswordField.TabIndex = 1;
            this.PasswordField.TextChanged += new System.EventHandler(this.LogInFields_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(73, 109);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(47, 12);
            this.PasswordLabel.TabIndex = 97;
            this.PasswordLabel.Text = "Password";
            // 
            // ResponseLabel
            // 
            this.ResponseLabel.AutoSize = true;
            this.ResponseLabel.ForeColor = System.Drawing.Color.Blue;
            this.ResponseLabel.Location = new System.Drawing.Point(73, 145);
            this.ResponseLabel.Name = "ResponseLabel";
            this.ResponseLabel.Size = new System.Drawing.Size(62, 12);
            this.ResponseLabel.TabIndex = 96;
            this.ResponseLabel.Text = "Please, log in.";
            // 
            // LogInCancelButton
            // 
            this.LogInCancelButton.Location = new System.Drawing.Point(13, 205);
            this.LogInCancelButton.Name = "LogInCancelButton";
            this.LogInCancelButton.Size = new System.Drawing.Size(50, 23);
            this.LogInCancelButton.TabIndex = 3;
            this.LogInCancelButton.Text = "Cancel";
            this.LogInCancelButton.UseVisualStyleBackColor = true;
            this.LogInCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.Enabled = false;
            this.LogInButton.Location = new System.Drawing.Point(238, 205);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(50, 23);
            this.LogInButton.TabIndex = 2;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 240);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.LogInCancelButton);
            this.Controls.Add(this.ResponseLabel);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameField);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.LogInLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogInLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox UserNameField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label ResponseLabel;
        private System.Windows.Forms.Button LogInCancelButton;
        private System.Windows.Forms.Button LogInButton;
    }
}

