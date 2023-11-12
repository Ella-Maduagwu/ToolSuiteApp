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
            emailTextbox = new TextBox();
            passwordTextBox = new TextBox();
            confirmPasswordTxt = new TextBox();
            createAccountBttn = new Button();
            SuspendLayout();
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new Point(203, 81);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new Size(97, 25);
            firstnameLabel.TabIndex = 0;
            firstnameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(406, 75);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(150, 31);
            firstNameTextBox.TabIndex = 1;
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new Point(203, 127);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new Size(95, 25);
            lastnameLabel.TabIndex = 2;
            lastnameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(203, 173);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(59, 25);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email ";
            // 
            // passwordlabel
            // 
            passwordlabel.AutoSize = true;
            passwordlabel.Location = new Point(203, 221);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new Size(87, 25);
            passwordlabel.TabIndex = 4;
            passwordlabel.Text = "Password";
            // 
            // confirmpasswordLabel
            // 
            confirmpasswordLabel.AutoSize = true;
            confirmpasswordLabel.Location = new Point(203, 263);
            confirmpasswordLabel.Name = "confirmpasswordLabel";
            confirmpasswordLabel.Size = new Size(156, 25);
            confirmpasswordLabel.TabIndex = 5;
            confirmpasswordLabel.Text = "Confirm Password";
            // 
            // lastnameText
            // 
            lastnameText.Location = new Point(406, 127);
            lastnameText.Name = "lastnameText";
            lastnameText.Size = new Size(150, 31);
            lastnameText.TabIndex = 6;
            // 
            // emailTextbox
            // 
            emailTextbox.Location = new Point(406, 173);
            emailTextbox.Name = "emailTextbox";
            emailTextbox.Size = new Size(150, 31);
            emailTextbox.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(406, 221);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(150, 31);
            passwordTextBox.TabIndex = 8;
            // 
            // confirmPasswordTxt
            // 
            confirmPasswordTxt.Location = new Point(406, 263);
            confirmPasswordTxt.Name = "confirmPasswordTxt";
            confirmPasswordTxt.Size = new Size(150, 31);
            confirmPasswordTxt.TabIndex = 9;
            // 
            // createAccountBttn
            // 
            createAccountBttn.Location = new Point(328, 341);
            createAccountBttn.Name = "createAccountBttn";
            createAccountBttn.Size = new Size(121, 43);
            createAccountBttn.TabIndex = 10;
            createAccountBttn.Text = "Create Account";
            createAccountBttn.UseVisualStyleBackColor = true;
            createAccountBttn.Click += createAccountBttn_Click;
            // 
            // createaccountForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(createAccountBttn);
            Controls.Add(confirmPasswordTxt);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextbox);
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
        private TextBox emailTextbox;
        private TextBox passwordTextBox;
        private TextBox confirmPasswordTxt;
        private Button createAccountBttn;
    }
}