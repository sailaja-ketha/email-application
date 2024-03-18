using System;

namespace EmailApplication
{
    public class EmailService
    {
        public void SendEmail(Email email)
        {

            // Simulate sending the email
            Console.WriteLine("\nSimulating sending email...");

            // Display the "sent" email
            
            Console.WriteLine($"To: {email.To}");
            Console.WriteLine($"Subject: {email.Subject}");
            Console.WriteLine($"Body: {email.Body}");
            Console.WriteLine("\n--- Email Sented Successfully ---");
        }
    }
}
