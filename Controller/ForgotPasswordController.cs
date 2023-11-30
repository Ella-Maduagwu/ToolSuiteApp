using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using toolsuiteapp.Data;
using toolsuiteapp.Service;
using System.Security.Cryptography;
using System.Net.Mail;
using toolsuiteapp.View;

namespace toolsuiteapp.Controller
{
    public class ForgotPasswordController
    {
        private UserRepository _userRepository;// field declaration to store a reference to an instance of the 
        private EmailService _emailService;
    
        public ForgotPasswordController()
        {
            _userRepository = new UserRepository();
            _emailService = new EmailService();
        }

        private string GenerateResetToken()
        {
            int tokenLength = 32;
            byte[] randomNumber = new byte[tokenLength];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
            }

            return Convert.ToBase64String(randomNumber);
        }

        public void RequestPasswordReset(string userEmail)
        {// validate if the user exists 
            if (_userRepository.EmailExists(userEmail))// there is an EmailExists method inthe UserRepository class
            {
                // generate a password reset token and store it in the database 
                var resetToken = GenerateResetToken();
                var tokenExpiry = DateTime.UtcNow.AddSeconds(120);// set the token to expire in 2 mins
                _userRepository.StorePasswordResetToken(userEmail, resetToken,tokenExpiry);
                // sendthe password reset email with the token
               _emailService.SendPasswordResetEmail(userEmail, resetToken);
            }
            else
            {
                // handle the case where the email doesn't exist with like a message box and a logger 
                // log password reset attempts 
            }
        }

        
    }
}
