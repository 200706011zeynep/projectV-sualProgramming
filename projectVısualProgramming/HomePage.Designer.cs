namespace projectVısualProgramming
{
    partial class HomePage
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
            CustomerSignInButton = new Button();
            employeeLogInButton = new Button();
            customerSignUpButton = new Button();
            label1 = new Label();
            customerSignUpLabel = new Label();
            customerSigninLabel = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // CustomerSignInButton
            // 
            CustomerSignInButton.Location = new Point(320, 72);
            CustomerSignInButton.Name = "CustomerSignInButton";
            CustomerSignInButton.Size = new Size(137, 33);
            CustomerSignInButton.TabIndex = 0;
            CustomerSignInButton.Text = "Customer Sign In";
            CustomerSignInButton.UseVisualStyleBackColor = true;
            CustomerSignInButton.Click += CustomerSignInButton_Click;
            // 
            // employeeLogInButton
            // 
            employeeLogInButton.Location = new Point(327, 305);
            employeeLogInButton.Name = "employeeLogInButton";
            employeeLogInButton.Size = new Size(137, 30);
            employeeLogInButton.TabIndex = 1;
            employeeLogInButton.Text = "Employee Log In";
            employeeLogInButton.UseVisualStyleBackColor = true;
            employeeLogInButton.Click += employeeLogInButton_Click;
            // 
            // customerSignUpButton
            // 
            customerSignUpButton.Location = new Point(320, 162);
            customerSignUpButton.Name = "customerSignUpButton";
            customerSignUpButton.Size = new Size(137, 29);
            customerSignUpButton.TabIndex = 2;
            customerSignUpButton.Text = "Customer Sign Up";
            customerSignUpButton.UseVisualStyleBackColor = true;
            customerSignUpButton.Click += customerSignUpButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 36);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // customerSignUpLabel
            // 
            customerSignUpLabel.AutoSize = true;
            customerSignUpLabel.Location = new Point(220, 205);
            customerSignUpLabel.Name = "customerSignUpLabel";
            customerSignUpLabel.Size = new Size(361, 20);
            customerSignUpLabel.TabIndex = 4;
            customerSignUpLabel.Text = "IF YOU DO NOT HAVE AN ACCOUNT PLEASE SIGN UP";
            // 
            // customerSigninLabel
            // 
            customerSigninLabel.AutoSize = true;
            customerSigninLabel.Location = new Point(251, 32);
            customerSigninLabel.Name = "customerSigninLabel";
            customerSigninLabel.Size = new Size(270, 20);
            customerSigninLabel.TabIndex = 5;
            customerSigninLabel.Text = "IF YOU ARE A REGISTERED CUSTOMER :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 52);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 6;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(customerSigninLabel);
            Controls.Add(customerSignUpLabel);
            Controls.Add(label1);
            Controls.Add(customerSignUpButton);
            Controls.Add(employeeLogInButton);
            Controls.Add(CustomerSignInButton);
            Name = "HomePage";
            Text = "HomePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CustomerSignInButton;
        private Button employeeLogInButton;
        private Button customerSignUpButton;
        private Label label1;
        private Label customerSignUpLabel;
        private Label customerSigninLabel;
        private Label label2;
    }
}