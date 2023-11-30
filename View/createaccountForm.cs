using System.Text.RegularExpressions;
using toolsuiteapp.Controller;
using toolsuiteapp.Data;
using toolsuiteapp.Model;

namespace toolsuiteapp.View
{
    public partial class createaccountForm : Form
    {
        public createaccountForm()
        {
            InitializeComponent();
        }
        private string GetSelectedRole()
        {
            if (adminRoleBtn.Checked)
                return adminRoleBtn.Text;
            else if (userRoleBtn.Checked)
                return userRoleBtn.Text;
            else
                return null;
        }
        private void createAccountBttn_Click(object sender, EventArgs e)
        {
            string firstName1 = firstNameTextBox.Text;
            string lastName1 = lastnameText.Text;
            string emailAddress = emailTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTxt.Text;
            string selectedRole = GetSelectedRole();

            // create an instance of the controller 
            var controller = new CreateAcctValidator();
            //call the validation method
            List<string> validationErrors = controller.acctValidators(firstName1, lastName1, emailAddress, password, confirmPassword, selectedRole);
            string emailPattern = @"^[a-zA-Z0-9]+@[a-zA-Z]+\.[a-zA-Z]+$";
            Regex regex = new Regex(emailPattern);
            if (validationErrors.Count == 0)
            {
                if (regex.IsMatch(emailAddress))
                {

                    string salt = CreateAcctValidator.GenerateSalt();// generate salt for the new user 
                    string hashedPassword = CreateAcctValidator.hashPassword(password, salt);//call the hashpassword method
                    var user = new UserAccount
                    {//assign the values gotten from the textboxes to the property of the userAccount object
                        firstName = firstName1,
                        lastName = lastName1,
                        email = emailAddress,
                        passwordHash = hashedPassword,
                        passwordSalt = salt,
                        role = selectedRole

                    };

                    var userRepository = new UserRepository();
                    userRepository.AddUser(user);// pass the data assigned to the Data repo to get stored in the database
                                                 // TO-DO: open the next form/window here
                    LoginForm loginForm = new LoginForm();
                    this.Hide();
                    loginForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please input valid email address");
                }

            }
            else
            {
                MessageBox.Show(string.Join("\n", validationErrors));
            }

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            this.Close();

        }
    }
}
