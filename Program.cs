using System;
using System.Text.RegularExpressions;

namespace ValidateEmail
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an email address to validate:");
            string? email = Console.ReadLine();

            if (IsValidEmail(email!))
            {
                Console.WriteLine("The email address is valid.");
            }
            else
            {
                Console.WriteLine("The email address is invalid.");
            }
        }
        public static bool IsValidEmail(string email)
        {
            try
            {
                Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
                return emailRegex.IsMatch(email);
            }
            catch
            {
                return false;
            }
        }
    }
}