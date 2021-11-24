
namespace Autoservice.Forms
{
    partial class Login
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginLable = new System.Windows.Forms.Label();
            this.forgetLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextBox.Location = new System.Drawing.Point(312, 169);
            this.usernameTextBox.MaxLength = 25;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(150, 26);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.usernameTextBox_MouseClick);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(312, 208);
            this.passwordTextBox.MaxLength = 25;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(150, 26);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordTextBox_MouseClick);
            // 
            // loginLable
            // 
            this.loginLable.AutoSize = true;
            this.loginLable.BackColor = System.Drawing.SystemColors.Control;
            this.loginLable.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLable.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loginLable.Location = new System.Drawing.Point(344, 100);
            this.loginLable.Name = "loginLable";
            this.loginLable.Size = new System.Drawing.Size(83, 36);
            this.loginLable.TabIndex = 2;
            this.loginLable.Text = "Login";
            // 
            // forgetLabel
            // 
            this.forgetLabel.AutoSize = true;
            this.forgetLabel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forgetLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.forgetLabel.Location = new System.Drawing.Point(309, 237);
            this.forgetLabel.Name = "forgetLabel";
            this.forgetLabel.Size = new System.Drawing.Size(100, 18);
            this.forgetLabel.TabIndex = 3;
            this.forgetLabel.Text = "Forgot password?";
            this.forgetLabel.Click += new System.EventHandler(this.forgetLabel_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.Control;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.loginButton.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginButton.Location = new System.Drawing.Point(312, 288);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(150, 39);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "SIGN IN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Autoservice.Properties.Resources.LoginImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.forgetLabel);
            this.Controls.Add(this.loginLable);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label loginLable;
        private System.Windows.Forms.Label forgetLabel;
        private System.Windows.Forms.Button loginButton;
    }
}