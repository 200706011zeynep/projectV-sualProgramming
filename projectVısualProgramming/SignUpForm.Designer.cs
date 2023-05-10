namespace projectVısualProgramming
{
    partial class SignUpForm
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
            nameLabel = new Label();
            surnameLabel = new Label();
            userNameLabel2 = new Label();
            passwordLabel2 = new Label();
            signUpButton2 = new Button();
            nameTextBox = new TextBox();
            surnameTextBox = new TextBox();
            userNameTextBox2 = new TextBox();
            passwordTextBox2 = new TextBox();
            eMailLabel = new Label();
            eMailTextBox = new TextBox();
            addressTextBox = new TextBox();
            numberTextBox = new TextBox();
            numberLabel = new Label();
            adressLabel = new Label();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(180, 32);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(56, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name :";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(180, 87);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(74, 20);
            surnameLabel.TabIndex = 1;
            surnameLabel.Text = "Surname :";
            // 
            // userNameLabel2
            // 
            userNameLabel2.AutoSize = true;
            userNameLabel2.Location = new Point(180, 193);
            userNameLabel2.Name = "userNameLabel2";
            userNameLabel2.Size = new Size(82, 20);
            userNameLabel2.TabIndex = 2;
            userNameLabel2.Text = "Username :";
            // 
            // passwordLabel2
            // 
            passwordLabel2.AutoSize = true;
            passwordLabel2.Location = new Point(180, 252);
            passwordLabel2.Name = "passwordLabel2";
            passwordLabel2.Size = new Size(77, 20);
            passwordLabel2.TabIndex = 3;
            passwordLabel2.Text = "Password :";
            // 
            // signUpButton2
            // 
            signUpButton2.Location = new Point(309, 409);
            signUpButton2.Name = "signUpButton2";
            signUpButton2.Size = new Size(94, 29);
            signUpButton2.TabIndex = 4;
            signUpButton2.Text = "SignUp";
            signUpButton2.UseVisualStyleBackColor = true;
            signUpButton2.Click += signUpButton2_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(309, 32);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 27);
            nameTextBox.TabIndex = 5;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(309, 87);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(125, 27);
            surnameTextBox.TabIndex = 6;
            // 
            // userNameTextBox2
            // 
            userNameTextBox2.Location = new Point(309, 193);
            userNameTextBox2.Name = "userNameTextBox2";
            userNameTextBox2.Size = new Size(125, 27);
            userNameTextBox2.TabIndex = 7;
            // 
            // passwordTextBox2
            // 
            passwordTextBox2.Location = new Point(309, 252);
            passwordTextBox2.Name = "passwordTextBox2";
            passwordTextBox2.Size = new Size(125, 27);
            passwordTextBox2.TabIndex = 8;
            // 
            // eMailLabel
            // 
            eMailLabel.AutoSize = true;
            eMailLabel.Location = new Point(180, 143);
            eMailLabel.Name = "eMailLabel";
            eMailLabel.Size = new Size(59, 20);
            eMailLabel.TabIndex = 9;
            eMailLabel.Text = "E-Mail :";
            // 
            // eMailTextBox
            // 
            eMailTextBox.Location = new Point(309, 143);
            eMailTextBox.Name = "eMailTextBox";
            eMailTextBox.Size = new Size(125, 27);
            eMailTextBox.TabIndex = 10;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(309, 305);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(125, 27);
            addressTextBox.TabIndex = 8;
            // 
            // numberTextBox
            // 
            numberTextBox.Location = new Point(309, 357);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(125, 27);
            numberTextBox.TabIndex = 8;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new Point(177, 357);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(107, 20);
            numberLabel.TabIndex = 3;
            numberLabel.Text = "PhoneNumber:";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new Point(185, 305);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new Size(65, 20);
            adressLabel.TabIndex = 3;
            adressLabel.Text = "Address:";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(eMailTextBox);
            Controls.Add(eMailLabel);
            Controls.Add(numberTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(passwordTextBox2);
            Controls.Add(userNameTextBox2);
            Controls.Add(surnameTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(signUpButton2);
            Controls.Add(adressLabel);
            Controls.Add(numberLabel);
            Controls.Add(passwordLabel2);
            Controls.Add(userNameLabel2);
            Controls.Add(surnameLabel);
            Controls.Add(nameLabel);
            Name = "SignUpForm";
            Text = "SignUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label surnameLabel;
        private Label userNameLabel2;
        private Label passwordLabel2;
        private Button signUpButton2;
        private TextBox nameTextBox;
        private TextBox surnameTextBox;
        private TextBox userNameTextBox2;
        private TextBox passwordTextBox2;
        private Label eMailLabel;
        private TextBox eMailTextBox;
        private TextBox addressTextBox;
        private TextBox numberTextBox;
        private Label numberLabel;
        private Label adressLabel;
    }
}