namespace toolsuiteapp.View
{
    partial class LoginForm
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
            emailLabel = new Label();
            PasswordLabel = new Label();
            ForgotPasswordBtn = new Button();
            LoginButton = new Button();
            emailTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            CreateAccountButton = new Button();
            SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(204, 65);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(124, 25);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email Address";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(204, 125);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(87, 25);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Password";
            // 
            // ForgotPasswordBtn
            // 
            ForgotPasswordBtn.Location = new Point(434, 264);
            ForgotPasswordBtn.Name = "ForgotPasswordBtn";
            ForgotPasswordBtn.Size = new Size(188, 34);
            ForgotPasswordBtn.TabIndex = 2;
            ForgotPasswordBtn.Text = "Forgot Password";
            ForgotPasswordBtn.UseVisualStyleBackColor = true;
            ForgotPasswordBtn.Click += ForgotPasswordBtn_Click;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(278, 264);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(112, 34);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(334, 65);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(288, 31);
            emailTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(334, 122);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(288, 31);
            PasswordTextBox.TabIndex = 5;
            // 
            // CreateAccountButton
            // 
            CreateAccountButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            CreateAccountButton.Location = new Point(27, 34);
            CreateAccountButton.Name = "CreateAccountButton";
            CreateAccountButton.Size = new Size(137, 34);
            CreateAccountButton.TabIndex = 6;
            CreateAccountButton.Text = "Create Account ";
            CreateAccountButton.UseVisualStyleBackColor = true;
            CreateAccountButton.Click += CreateAccountButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateAccountButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(LoginButton);
            Controls.Add(ForgotPasswordBtn);
            Controls.Add(PasswordLabel);
            Controls.Add(emailLabel);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label emailLabel;
        private Label PasswordLabel;
        private Button ForgotPasswordBtn;
        private Button LoginButton;
        private TextBox emailTextBox;
        private TextBox PasswordTextBox;
        private Button CreateAccountButton;
    }
}