using EmailServices.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmailServices.Business
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
    }
}
