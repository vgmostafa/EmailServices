using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmailServices.Business;
using EmailServices.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmailServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailSender _emailSender;

        public EmailController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpPost]
        public void SendMail(EmailEntity model)
        {
            //var message = new Message(new string[] { "jhonna7an@gmail.com" }, "Test email", "This is the content from our email.");
            foreach (var item in model.To)
            {
                var message = new Message(model.To, model.Subject, model.Body);
                _emailSender.SendEmail(message);
            }
        }
    }
}