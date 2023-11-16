using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using toolsuiteapp.Controller;
using toolsuiteapp.Model;
using toolsuiteapp.Data;

namespace toolsuiteapp.View
{
    public partial class createaccountForm : Form
    {
        public createaccountForm()
        {
            InitializeComponent();
        }

        private void createAccountBttn_Click(object sender, EventArgs e)
        {
            string firstName1 = firstNameTextBox.Text;
            string lastName1 = lastnameText.Text;
            string emailAddress = emailTextbox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTxt.Text;

            // create an instance of the controller 
            var controller = new CreateAcctValidator();
            //call the validation method
            List<string> validationErrors = controller.acctValidators(firstName1, lastName1, emailAddress, password, confirmPassword);

            if (validationErrors.Count == 0)
            {
                string salt = CreateAcctValidator.GenerateSalt();// generate salt for the new user 
                string hashedPassword = CreateAcctValidator.hashPassword(password, salt);//call the hashpassword method
                var user = new UserAccount
                {//assign the values gotten from the textboxes to the property of the userAccount object
                    firstName = firstName1,
                    lastName = lastName1,
                    email = emailAddress,
                    passwordHash = hashedPassword,
                    passwordSalt = salt
                    // TO-DO: generate and assign a salt
                };

                var userRepository = new UserRepository();
                userRepository.AddUser(user);// pass the data assigned to the Data repo to get stored in the database
                // TO-DO: open the next form/window here

            }
            else
            {
                MessageBox.Show(string.Join("\n", validationErrors));
            }

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // open the login window/Form here 

        }
    }
}
