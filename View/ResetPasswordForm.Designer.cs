namespace toolsuiteapp.View
{
    partial class ResetPasswordForm
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
            tokenTxtBox = new TextBox();
            nextButton = new Button();
            newPasswordLabel = new Label();
            newPasswordTxtBox = new TextBox();
            confirmPasswordLabel = new Label();
            confirmPasswordTxtBox = new TextBox();
            tokenLabel = new Label();
            emailLabel = new Label();
            emailTxtBox = new TextBox();
            SuspendLayout();
            // 
            // tokenTxtBox
            // 
            tokenTxtBox.Location = new Point(389, 122);
            tokenTxtBox.Name = "tokenTxtBox";
            tokenTxtBox.Size = new Size(189, 31);
            tokenTxtBox.TabIndex = 3;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(390, 326);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(94, 47);
            nextButton.TabIndex = 4;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Location = new Point(205, 180);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(127, 25);
            newPasswordLabel.TabIndex = 5;
            newPasswordLabel.Text = "New Password";
            // 
            // newPasswordTxtBox
            // 
            newPasswordTxtBox.Location = new Point(386, 180);
            newPasswordTxtBox.Name = "newPasswordTxtBox";
            newPasswordTxtBox.Size = new Size(189, 31);
            newPasswordTxtBox.TabIndex = 6;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Location = new Point(206, 243);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(161, 25);
            confirmPasswordLabel.TabIndex = 7;
            confirmPasswordLabel.Text = "Confirm Password ";
            // 
            // confirmPasswordTxtBox
            // 
            confirmPasswordTxtBox.Location = new Point(388, 243);
            confirmPasswordTxtBox.Name = "confirmPasswordTxtBox";
            confirmPasswordTxtBox.Size = new Size(189, 31);
            confirmPasswordTxtBox.TabIndex = 8;
            // 
            // tokenLabel
            // 
            tokenLabel.AutoSize = true;
            tokenLabel.Location = new Point(205, 128);
            tokenLabel.Name = "tokenLabel";
            tokenLabel.Size = new Size(105, 25);
            tokenLabel.TabIndex = 9;
            tokenLabel.Text = "Reset Token";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(209, 80);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(124, 25);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email Address";
            // 
            // emailTxtBox
            // 
            emailTxtBox.Location = new Point(393, 76);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(185, 31);
            emailTxtBox.TabIndex = 11;
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(emailTxtBox);
            Controls.Add(emailLabel);
            Controls.Add(tokenLabel);
            Controls.Add(confirmPasswordTxtBox);
            Controls.Add(confirmPasswordLabel);
            Controls.Add(newPasswordTxtBox);
            Controls.Add(newPasswordLabel);
            Controls.Add(nextButton);
            Controls.Add(tokenTxtBox);
            Name = "ResetPasswordForm";
            Text = "ResetPasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tokenTxtBox;
        private Button nextButton;
        private Label newPasswordLabel;
        private TextBox newPasswordTxtBox;
        private Label confirmPasswordLabel;
        private TextBox confirmPasswordTxtBox;
        private Label tokenLabel;
        private Label emailLabel;
        private TextBox emailTxtBox;
    }
}