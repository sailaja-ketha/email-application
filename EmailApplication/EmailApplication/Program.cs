using System;
using System.Net;
using System.Net.Mail;

namespace EmailApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Email Application!");

            while (true)
            {
                Console.WriteLine("\n1. Compose Email");
                Console.WriteLine("2. Exit");
                Console.Write("Select an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        ComposeEmail();
                        break;
                    case "2":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select again.");
                        break;
                }
            }
        }

        static void ComposeEmail()
        {
            Email email = new Email();

            Console.WriteLine("\nEnter recipient's email address:");
            email.To = Console.ReadLine();

            Console.WriteLine("Enter subject:");
            email.Subject = Console.ReadLine();

            Console.WriteLine("Enter message body:");
            email.Body = Console.ReadLine();

            
            EmailService emailService = new EmailService();

            //composed email
            Console.WriteLine("\n--- Composed Email ---");
            Console.WriteLine($"To: {email.To}");
            Console.WriteLine($"Subject: {email.Subject}");
            Console.WriteLine($"Body: {email.Body}");

            // if user want to send the email
            Console.Write("\nDo you want to send this email? (yes/no): ");
            string sendOption = Console.ReadLine().ToLower();

            if (sendOption == "yes" || sendOption == "y")
            {
                // "Send" the email
                emailService.SendEmail(email);
            }
            else
            {
                Console.WriteLine("Email not sent.");
            }
        }

    }
}
