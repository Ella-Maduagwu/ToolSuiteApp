using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using toolsuiteapp.Controller;

namespace toolsuiteapp.View
// this is the form where the user request for a password reset
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void SendEmailBtn_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = false;
            string emailPattern = @"^[a-zA-Z0-9]+@[a-zA-Z]+\.[a-zA-Z]+$";
            Regex regex = new Regex(emailPattern);
            string userEmail = EmailTxtBox.Text;
            if (string.IsNullOrEmpty(EmailTxtBox.Text) && regex.IsMatch(EmailTxtBox.Text))
            {
                // call method to handle password reset request 
                var passwordReset = new ForgotPasswordController();
                passwordReset.RequestPasswordReset(userEmail);

                MessageBox.Show("if your email is registered, you will recieve a password reset token.", "password Reset");
                nextButton.Enabled = true;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            ResetPasswordForm resetForm = new ResetPasswordForm();
            resetForm.ShowDialog();
            this.Close();
        }
    }
}
