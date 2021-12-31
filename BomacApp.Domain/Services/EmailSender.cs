using BomacApp.Domain.Services.Interfaces;
using Postal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Services
{
   public class EmailSender:Email,IEmailSender
    {

        public string From { get; set; }
        public string Subject { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string To { get; set; }
        public string Message { get; set; }

        public string ButtonText { get; set; }

        public string Link { get; set; }



        public EmailSender()
        {

            From = string.Format("{0} {1}", "mofrank.com", "noreply@mofrank.com");
        }


        public void ActivateAccount(string to, string message, string url, string text = "Activate account")
        {

            var email = new EmailSender
            {
                Subject = "Account Verification",
                To = to,
                Message = message,
                ButtonText = text,
                Link = url,
                ViewName = "account"
            };
            email.Send();
        }

        public void InviteUser(string to, string name, string message, string link, string buttonText, string title)
        {
            var email = new EmailSender
            {
                Subject = "Account Verification",
                To = to,
                Name = name,
                Message = message,
                ButtonText = buttonText,
                Link = link,
                Title = title,
                ViewName = "account",

            };

            email.Send();
        }

        public void ResetPassword(string callbackurl, string to, string name)
        {

            var email = new EmailSender
            {
                ButtonText = "Reset Now",
                Title = "Reset Password",
                Subject = "Reset Password Confirmation",
                Name = name,
                To = to,
                Message = $"you requested for your a password restet to happen on your account. please click on the button below to reset." +
                          $" ignore this email if you  did not make this request",
                Link = callbackurl,
                ViewName = "account"
            };
            email.Send();


        }




    }
}
