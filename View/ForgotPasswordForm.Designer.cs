namespace toolsuiteapp.View
{
    partial class ForgotPasswordForm
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
            EmailTxtBox = new TextBox();
            EmailLabel = new Label();
            loginButton = new Button();
            nextButton = new Button();
            submitButton = new Button();
            SuspendLayout();
            // 
            // EmailTxtBox
            // 
            EmailTxtBox.Location = new Point(375, 105);
            EmailTxtBox.Name = "EmailTxtBox";
            EmailTxtBox.Size = new Size(150, 31);
            EmailTxtBox.TabIndex = 1;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(221, 108);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(124, 25);
            EmailLabel.TabIndex = 3;
            EmailLabel.Text = "Email Address";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(625, 38);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(112, 34);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(422, 236);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(112, 34);
            nextButton.TabIndex = 5;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(249, 236);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(112, 34);
            submitButton.TabIndex = 6;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submitButton);
            Controls.Add(nextButton);
            Controls.Add(loginButton);
            Controls.Add(EmailLabel);
            Controls.Add(EmailTxtBox);
            Name = "ForgotPasswordForm";
            Text = "ForgotPasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox EmailTxtBox;
        private Label EmailLabel;
        private Button loginButton;
        private Button nextButton;
        private Button submitButton;
    }
}