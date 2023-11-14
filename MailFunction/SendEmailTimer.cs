using System;
using System.Net.Mail;
using BuyMyHouse.Service.Interfaces;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace MailFunction
{
    public class SendEmailTimer
    {
        [FunctionName("SendMail")]
        public void Run([TimerTrigger("0 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            //key: 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

            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            // Set your SendGrid API Key
            // string apiKey = Environment.GetEnvironmentVariable("sendgrid_key");
            string apiKey = "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";

            // Set your sender email address
            string fromEmail = "665709@student.inholland.nl";

            // Set your recipient email address
            string toEmail = "yeraz.alina@gmail.com";

            // Create a SendGrid client
            var client = new SendGridClient(apiKey);

            // Create an email message
            var msg = new SendGridMessage
            {
                From = new EmailAddress(fromEmail, "Sender Name"),
                Subject = "Azure Function TimerTrigger Email",
                PlainTextContent = "This is a test email from your Azure Function.",
                HtmlContent = "<strong>This is a test email from your Azure Function.</strong>"
            };
            msg.AddTo(new EmailAddress(toEmail, "Recipient Name"));

            // Send the email
            var response = client.SendEmailAsync(msg).Result;

            log.LogInformation($"Email sent. Status code: {response.StatusCode}");
        }
    }
}
