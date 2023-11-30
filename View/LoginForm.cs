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
using toolsuiteapp.Service;

namespace toolsuiteapp.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        string currentUserRole = string.Empty;

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
            var (storedHash, storedSalt) = userRepo.GetUserPasswordInfo(emailAddress1);// this method returns the hashed password and salt stored in the db for the email entered 
            UserSession userSession = new UserSession();
            userSession.Initialize(emailAddress1);
            if (errorValidations.Count == 0)
            {
                if (regex.IsMatch(emailTextBox.Text))
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
                            string userRole = userSession.GetRole();
                           if (currentUserRole == "Admin" || currentUserRole == "User")
                            {
                                HomepageForm homepageForm = new HomepageForm();
                                this.Hide();
                                homepageForm.ShowDialog();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Password");
                        }
                    }
                    else
                    {
                        // log error here 
                        MessageBox.Show(Text, "stored hash and stored salt was not returned ");
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
       

        private void ForgotPasswordBtn_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm form = new ForgotPasswordForm();
            form.ShowDialog();
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // ignore this 
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            createaccountForm account = new createaccountForm();
            this.Hide();
            account.ShowDialog();
            this.Close();
        }
    }
}
