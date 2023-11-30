using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toolsuiteapp.Service
{
    public class EmailService
    {// this configurations shouldn't be hardcoded but due to the lack of time, it's been hardcoded
        private string _smtpHost = "smtp.gmail.com";
        private int _smtpPort = 587;
        private string _fromAddress = "cietiesoft@gmail.com";
        private string _fromPassword = "password4cietie";



        public void SendPasswordResetEmail(string recipientEmail, string resetToken)
        {
            using (var smtpClient = new SmtpClient(_smtpHost)
            {
                Port = _smtpPort,
                Credentials = new NetworkCredential(_fromAddress, _fromPassword),
                EnableSsl = true,
            })
            {
                var mailMessage = new MailMessage()
                {
                    From = new MailAddress(_fromAddress),
                    Subject = "Password Reset Request",
                    Body = $"please enter this code in the Application: {resetToken}",
                    IsBodyHtml = false,

                };
                mailMessage.To.Add(recipientEmail);
                smtpClient.Send(mailMessage);
            }
    }
    }
  

   
}
