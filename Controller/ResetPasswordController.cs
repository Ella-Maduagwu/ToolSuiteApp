using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using toolsuiteapp.Data;

namespace toolsuiteapp.Controller
{
    internal class ResetPasswordController
    {

        private UserRepository _userRepository;

        public ResetPasswordController()
        {
            _userRepository = new UserRepository();
        }
        public List<string> resetValidators(string emailAddress, string Token, string newPassword, string confirmPassword)
        {
            string emailPattern = @"^[a-zA-Z0-9]+@[a-zA-Z]+\.[a-zA-Z]+$";
            Regex regex = new Regex(emailPattern);
            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(emailAddress))
            {
                errors.Add("please fill all textboxes");
            }

            if (!regex.IsMatch(emailAddress))
            {
                errors.Add("please input a valid email address ");
            }
            if (string.IsNullOrEmpty(Token))
            {
                errors.Add("please fill all textboxes");
            }

            if (string.IsNullOrEmpty(newPassword))
            {
                errors.Add("please fill all textboxes");
            }

            if (string.IsNullOrEmpty(confirmPassword))
            {
                errors.Add("please fill all textboxes");
            }
            if (newPassword != confirmPassword)
            {
                errors.Add("passwords do not match");
            }

            return errors;
        }

        public bool ResetPassword(string emailAddress, string tokenInputted, string newPassword)
        {
            var (storedToken, tokenExpiry) = _userRepository.GetResetTokenInfo(emailAddress);

            if (storedToken != null && tokenInputted == storedToken && DateTime.UtcNow <= tokenExpiry)
            {
                string Salt = CreateAcctValidator.GenerateSalt();
                string hashedPassword = CreateAcctValidator.hashPassword(newPassword, Salt);

                _userRepository.UpdateUserPassword(emailAddress, hashedPassword, Salt);
                _userRepository.ClearResetToken(emailAddress);
                return true;

            }

            else
            {
                return false;
            }
        }
    }
}
