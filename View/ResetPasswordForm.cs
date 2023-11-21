using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using toolsuiteapp.Controller;

namespace toolsuiteapp.View
{
    public partial class ResetPasswordForm : Form
    {
        // this is the form where the user enter the token sent via email and actually resets the password 
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            string emailAddy = emailTxtBox.Text;
            string tokenInput = tokenTxtBox.Text;
            string newPassword = newPasswordTxtBox.Text;
            string confirmPassword = confirmPasswordTxtBox.Text;

            // create an instance of the controller 
            var controller = new ResetPasswordController();
            //call the validation method
            List<string> validateErrors = controller.resetValidators(emailAddy, tokenInput, newPassword, confirmPassword);
            string emailPattern = @"^[a-zA-Z0-9]+@[a-zA-Z]+\.[a-zA-Z]+$";
            Regex regex = new Regex(emailPattern);
            if (validateErrors.Count > 0 && regex.IsMatch(emailTxtBox.Text))
            {

                controller.ResetPassword(emailAddy, newPassword, tokenInput);
                MessageBox.Show(Text,"Your password has been successfully changed, please proceed to login");
               LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            } 

            else
            {
                MessageBox.Show(string.Join("\n", validateErrors));
            }
        }
    }
}
