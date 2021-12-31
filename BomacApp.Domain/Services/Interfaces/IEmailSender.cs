using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Services.Interfaces
{
    public interface IEmailSender
    {
        void ActivateAccount(string to, string message, string url, string text = "Activate account");
        void InviteUser(string to, string name, string message, string link, string buttonText, string title);
        void ResetPassword(string callbackurl, string to, string name);
 

    }
}
