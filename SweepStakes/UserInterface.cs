using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    static class UserInterface
    {
        public static void Greeting()
        {
            Console.WriteLine($"Welcome to the Sweepstakes, good luck!");
        }

        public static string GetLastName()
        {
            Console.WriteLine($"Please enter your last name.");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static string GetFirstName()
        {
            Console.WriteLine($"Please enter your first name.");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static string GetEmailAddress()
        {
            Console.WriteLine($"Please enter your email address.");
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
