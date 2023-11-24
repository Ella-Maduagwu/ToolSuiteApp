using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using toolsuiteapp.Controller;
using toolsuiteapp.Data;

namespace toolsuiteapp.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
          
            string emailAddress1 = emailTextBox.Text;
            string password1 = PasswordTextBox.Text;
            var loginValidators = new LoginValidators()
            {
                Email = emailAddress1,
                Password = password1

            };
            //call the validation method
            List<string> errorValidations = loginValidators.detailsValidation();
            string emailPattern = @"^[a-zA-Z0-9]+@[a-zA-Z]+\.[a-zA-Z]+$";
            Regex regex = new Regex(emailPattern);// valiadtions
            var userRepo = new UserRepository();
            var (storedHash, storedSalt, userRole) = userRepo.GetUserPasswordInfo(emailAddress1);// this method returns the hashed password and salt stored in the db for the email entered 
            if (errorValidations.Count == 0 && regex.IsMatch(emailTextBox.Text))
            {
                //TO-DO: retrieve the salt and hashed password for the given email from the database
                // hash the password input by the user with this retrieved salt 
                // Compare the resulting hash with the stored hash to verify the password 
               
                if (!string.IsNullOrEmpty(storedHash) && !string.IsNullOrEmpty(storedSalt))
                {

                    // hash the provided password with the retrieved salt 
                    string hashedPassword = CreateAcctValidator.hashPassword(password1, storedSalt);

                    // compare the hashed password with the stored hash 

                    if (hashedPassword == storedHash)
                    {
                        grantAccess(userRole);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password");
                    }
                }
                else
                {
                    MessageBox.Show("There is no account registered with this email address");
                }

            }
            else
            {
                MessageBox.Show(string.Join("\n", errorValidations));
            }


        }
        //TO-DO: ensure to include a userrole column in the DB
        // 2. handle exception, it is a must
        // 3. Include a logger
        public void grantAccess(string role)
        {
            if(role == "admin")
            {
                AdminDashboardForm adminDashboard = new AdminDashboardForm();
                adminDashboard.ShowDialog();
                this.Close();
            }
            else if (role == "user")
            {
                HomePageForm homePageForm = new HomePageForm();
                homePageForm.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show(Text, "error");
                // implement logger 
            }
        }

        private void ForgotPasswordBtn_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm form = new ForgotPasswordForm();
            form.ShowDialog();
            this.Close();
        }
    }
}
