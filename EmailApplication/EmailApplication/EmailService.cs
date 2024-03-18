using System;
using System.Net.Mail;
using System.Net;

namespace EmailApplication
{
    public class EmailService
    {
        public void SendEmail(Email email)
        {
            // Sender's email address and password
            string senderEmail = "sailajaketha2001@gmail.com";
            string senderPassword = "cjrn oytk xxhy fdrz";

            // SMTP server details
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587; // Gmail SMTP port

            // Create SMTP client
            SmtpClient client = new SmtpClient(smtpServer)
            {
                Port = smtpPort,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail, senderPassword),
                EnableSsl = true,
            };

            // Create email message
            MailMessage mailMessage = new MailMessage(senderEmail, email.To)
            {
                Subject = email.Subject,
                Body = email.Body,
                IsBodyHtml = false
            };

            try
            {
                // Send the email
                client.Send(mailMessage);
                Console.WriteLine("\n--- Email Sent Successfully ---");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nFailed to send email: {ex.Message}");
            }
        }
    
    }
}
