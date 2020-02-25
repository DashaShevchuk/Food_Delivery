using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.Services
{
    public class EmailSender : IEmailSender
    {



        private readonly IConfiguration _configuration;
        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }



        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(/*_configuration.GetValue<string>("EmailGridKey")*/"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", subject, htmlMessage, email);
        }



        public Task Execute(string apiKey, string subject, string message, string email)
        {
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("77dasha0377@gmail.com", "Dashka"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(email));
            msg.SetClickTracking(false, false);
            return client.SendEmailAsync(msg);
        }
    }
}
