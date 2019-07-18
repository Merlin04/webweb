using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace webweb.Services
{
    public class EmailSender : IEmailSender
    {
        private string host;
        private int port;
        private bool enableSSL;
        private string userName;
        private string password;
        private string fromAddress;

        public EmailSender(string host, int port, bool enableSSL, string userName, string password, string fromAddress)
        {
            this.host = host;
            this.port = port;
            this.enableSSL = enableSSL;
            this.userName = userName;
            this.password = password;
            this.fromAddress = fromAddress;
        }
        
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient(host, port)
            {
                Credentials = new NetworkCredential(userName, password),
                EnableSsl = enableSSL
            };
            MailMessage mailMessage =
                new MailMessage(fromAddress, email, subject, htmlMessage);
            mailMessage.IsBodyHtml = true;
            return client.SendMailAsync(
                mailMessage 
            );
        }
    }
}