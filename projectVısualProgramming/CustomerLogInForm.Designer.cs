namespace projectVısualProgramming
{
    partial class CustomerLogInForm
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
            PasswordLabel = new Label();
            UsernameLabel = new Label();
            PasswordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            LogInButton = new Button();
            SuspendLayout();
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(215, 185);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(77, 20);
            PasswordLabel.TabIndex = 9;
            PasswordLabel.Text = "Password :";
            
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(215, 108);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(82, 20);
            UsernameLabel.TabIndex = 8;
            UsernameLabel.Text = "Username :";
            
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(318, 178);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(186, 27);
            PasswordTextBox.TabIndex = 7;
            
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(316, 101);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(188, 27);
            usernameTextBox.TabIndex = 6;
            
            // 
            // LogInButton
            // 
            LogInButton.Location = new Point(318, 280);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(186, 29);
            LogInButton.TabIndex = 5;
            LogInButton.Text = "Log In";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            // 
            // CustomerLogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(LogInButton);
            Name = "CustomerLogInForm";
            Text = "CustomerLogInForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PasswordLabel;
        private Label UsernameLabel;
        private TextBox PasswordTextBox;
        private TextBox usernameTextBox;
        private Button LogInButton;
    }
}