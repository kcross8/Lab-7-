using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid name:");
            string name = Console.ReadLine();
            FindName(name);

            Console.WriteLine("Please enter a valid email:");
            string email = Console.ReadLine();
            FindEmail(email);

            Console.WriteLine("Please enter a valid phone number:");
            string phone = Console.ReadLine();
            FindPhone(phone);

            Console.WriteLine("Please enter a valid date:");
            string date = Console.ReadLine();
            FindDate(date);

        }
        public static void FindName(string input)
        {
            string name = input;
            if (Regex.IsMatch(name, @"[\d]"))
            {
                Console.WriteLine("Sorry, name is not valid");
            }
            else if (Regex.IsMatch(name, @"\b[A-Z]+\w[a-z]{1,30}"))
            {
                Console.WriteLine("Name is valid");
            }
            else
            {
                Console.WriteLine("Sorry, name is not valid");
            }
        }

        public static void FindEmail(string input)
        {
            string email = input;
            if (Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
            {
                Console.WriteLine("Email is valid");
            }
            else
            {
                Console.WriteLine("Sorry, email is not valid");
            }
        }

        public static void FindDate(string input)
        {
            string date = input;
            if (Regex.IsMatch(date, @"^\d{1,2}\/\d{1,2}\/\d{4}$"))
            {
                Console.WriteLine("Date is valid");
            }
            else
            {
                Console.WriteLine("Sorry, date is not valid");
            }
        }

        public static void FindPhone(string input)
        {
            string phone = input;
            if (Regex.IsMatch(phone, @"\d{3}-\d{3}-\d{4}$"))
            {
                Console.WriteLine("Phone is valid");
            }
            else
            {
                Console.WriteLine("Sorry, phone is not valid");
            }
        }
    }
}

