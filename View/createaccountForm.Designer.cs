namespace toolsuiteapp.View
{
    partial class createaccountForm
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
            firstnameLabel = new Label();
            firstNameTextBox = new TextBox();
            lastnameLabel = new Label();
            emailLabel = new Label();
            passwordlabel = new Label();
            confirmpasswordLabel = new Label();
            lastnameText = new TextBox();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            confirmPasswordTxt = new TextBox();
            createAccountBttn = new Button();
            LoginButton = new Button();
            roleLabel = new Label();
            adminRoleBtn = new RadioButton();
            userRoleBtn = new RadioButton();
            SuspendLayout();
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new Point(193, 44);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new Size(97, 25);
            firstnameLabel.TabIndex = 0;
            firstnameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(358, 38);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(150, 31);
            firstNameTextBox.TabIndex = 1;
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new Point(193, 84);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new Size(95, 25);
            lastnameLabel.TabIndex = 2;
            lastnameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(193, 126);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(59, 25);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email ";
            // 
            // passwordlabel
            // 
            passwordlabel.AutoSize = true;
            passwordlabel.Location = new Point(193, 166);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new Size(87, 25);
            passwordlabel.TabIndex = 4;
            passwordlabel.Text = "Password";
            // 
            // confirmpasswordLabel
            // 
            confirmpasswordLabel.AutoSize = true;
            confirmpasswordLabel.Location = new Point(193, 209);
            confirmpasswordLabel.Name = "confirmpasswordLabel";
            confirmpasswordLabel.Size = new Size(156, 25);
            confirmpasswordLabel.TabIndex = 5;
            confirmpasswordLabel.Text = "Confirm Password";
            // 
            // lastnameText
            // 
            lastnameText.Location = new Point(358, 80);
            lastnameText.Name = "lastnameText";
            lastnameText.Size = new Size(150, 31);
            lastnameText.TabIndex = 6;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(358, 123);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(150, 31);
            emailTextBox.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(358, 166);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(150, 31);
            passwordTextBox.TabIndex = 8;
            // 
            // confirmPasswordTxt
            // 
            confirmPasswordTxt.Location = new Point(358, 209);
            confirmPasswordTxt.Name = "confirmPasswordTxt";
            confirmPasswordTxt.Size = new Size(150, 31);
            confirmPasswordTxt.TabIndex = 9;
            // 
            // createAccountBttn
            // 
            createAccountBttn.Location = new Point(619, 382);
            createAccountBttn.Name = "createAccountBttn";
            createAccountBttn.Size = new Size(158, 43);
            createAccountBttn.TabIndex = 10;
            createAccountBttn.Text = "Create Account";
            createAccountBttn.UseVisualStyleBackColor = true;
            createAccountBttn.Click += createAccountBttn_Click;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(653, 21);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(112, 34);
            LoginButton.TabIndex = 11;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new Point(78, 289);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(104, 25);
            roleLabel.TabIndex = 12;
            roleLabel.Text = "Assign Role";
            // 
            // adminRoleBtn
            // 
            adminRoleBtn.AutoSize = true;
            adminRoleBtn.Location = new Point(98, 347);
            adminRoleBtn.Name = "adminRoleBtn";
            adminRoleBtn.Size = new Size(90, 29);
            adminRoleBtn.TabIndex = 13;
            adminRoleBtn.TabStop = true;
            adminRoleBtn.Text = "Admin";
            adminRoleBtn.UseVisualStyleBackColor = true;
            // 
            // userRoleBtn
            // 
            userRoleBtn.AutoSize = true;
            userRoleBtn.Location = new Point(267, 347);
            userRoleBtn.Name = "userRoleBtn";
            userRoleBtn.Size = new Size(72, 29);
            userRoleBtn.TabIndex = 14;
            userRoleBtn.TabStop = true;
            userRoleBtn.Text = "User";
            userRoleBtn.UseVisualStyleBackColor = true;
            // 
            // createaccountForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userRoleBtn);
            Controls.Add(adminRoleBtn);
            Controls.Add(roleLabel);
            Controls.Add(LoginButton);
            Controls.Add(createAccountBttn);
            Controls.Add(confirmPasswordTxt);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(lastnameText);
            Controls.Add(confirmpasswordLabel);
            Controls.Add(passwordlabel);
            Controls.Add(emailLabel);
            Controls.Add(lastnameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstnameLabel);
            Name = "createaccountForm";
            Text = "createaccountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstnameLabel;
        private TextBox firstNameTextBox;
        private Label lastnameLabel;
        private Label emailLabel;
        private Label passwordlabel;
        private Label confirmpasswordLabel;
        private TextBox lastnameText;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private TextBox confirmPasswordTxt;
        private Button createAccountBttn;
        private Button LoginButton;
        private Label roleLabel;
        private RadioButton adminRoleBtn;
        private RadioButton userRoleBtn;
    }
}