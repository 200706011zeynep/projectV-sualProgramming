namespace projectVısualProgramming
{
    partial class EmployeeSignIn
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
            employeeSignInButton = new Button();
            employeeUsernameLabel = new Label();
            employeePasswordLabel = new Label();
            employeeUsernameTextBox = new TextBox();
            employeePasswordTextBox = new TextBox();
            employeeTitleTextBox = new TextBox();
            employeeTitleLabel = new Label();
            SuspendLayout();
            // 
            // employeeSignInButton
            // 
            employeeSignInButton.Location = new Point(340, 290);
            employeeSignInButton.Name = "employeeSignInButton";
            employeeSignInButton.Size = new Size(94, 29);
            employeeSignInButton.TabIndex = 0;
            employeeSignInButton.Text = "Sign In";
            employeeSignInButton.UseVisualStyleBackColor = true;
            // 
            // employeeUsernameLabel
            // 
            employeeUsernameLabel.AutoSize = true;
            employeeUsernameLabel.Location = new Point(176, 85);
            employeeUsernameLabel.Name = "employeeUsernameLabel";
            employeeUsernameLabel.Size = new Size(152, 20);
            employeeUsernameLabel.TabIndex = 1;
            employeeUsernameLabel.Text = "Employee Username :";
            // 
            // employeePasswordLabel
            // 
            employeePasswordLabel.AutoSize = true;
            employeePasswordLabel.Location = new Point(176, 152);
            employeePasswordLabel.Name = "employeePasswordLabel";
            employeePasswordLabel.Size = new Size(147, 20);
            employeePasswordLabel.TabIndex = 2;
            employeePasswordLabel.Text = "Employee Password :";
            // 
            // employeeUsernameTextBox
            // 
            employeeUsernameTextBox.Location = new Point(381, 85);
            employeeUsernameTextBox.Name = "employeeUsernameTextBox";
            employeeUsernameTextBox.Size = new Size(125, 27);
            employeeUsernameTextBox.TabIndex = 3;
            // 
            // employeePasswordTextBox
            // 
            employeePasswordTextBox.Location = new Point(381, 152);
            employeePasswordTextBox.Name = "employeePasswordTextBox";
            employeePasswordTextBox.Size = new Size(125, 27);
            employeePasswordTextBox.TabIndex = 4;
            // 
            // employeeTitleTextBox
            // 
            employeeTitleTextBox.Location = new Point(381, 220);
            employeeTitleTextBox.Name = "employeeTitleTextBox";
            employeeTitleTextBox.Size = new Size(125, 27);
            employeeTitleTextBox.TabIndex = 5;
            // 
            // employeeTitleLabel
            // 
            employeeTitleLabel.AutoSize = true;
            employeeTitleLabel.Location = new Point(176, 220);
            employeeTitleLabel.Name = "employeeTitleLabel";
            employeeTitleLabel.Size = new Size(142, 20);
            employeeTitleLabel.TabIndex = 6;
            employeeTitleLabel.Text = "Employee Job Title :";
            // 
            // EmployeeSignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(employeeTitleLabel);
            Controls.Add(employeeTitleTextBox);
            Controls.Add(employeePasswordTextBox);
            Controls.Add(employeeUsernameTextBox);
            Controls.Add(employeePasswordLabel);
            Controls.Add(employeeUsernameLabel);
            Controls.Add(employeeSignInButton);
            Name = "EmployeeSignIn";
            Text = "EmployeeSignIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button employeeSignInButton;
        private Label employeeUsernameLabel;
        private Label employeePasswordLabel;
        private TextBox employeeUsernameTextBox;
        private TextBox employeePasswordTextBox;
        private TextBox employeeTitleTextBox;
        private Label employeeTitleLabel;
    }
}