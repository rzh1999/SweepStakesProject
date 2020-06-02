using System;
using System.CodeDom.Compiler;
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
            string results = DataValidation(userInput);
            return results;
        }

        public static string GetFirstName()
        {
            Console.WriteLine($"Please enter your first name.");
            string userInput = Console.ReadLine();
            string results = DataValidation(userInput);
            return results;
        }

        public static string GetEmailAddress()
        {
            Console.WriteLine($"Please enter your email address.");
            string userInput = Console.ReadLine();
            string results = DataValidation(userInput);
            return results;
            //If time add code to validate if its a real email address
        }

        public static string GetSweepStakesName()
        {
            Console.WriteLine($"Please enter the name of your sweepstake.");
            string userInput = Console.ReadLine();
            string results = DataValidation(userInput);
            return results;
        }

        public static int HowManyContestants()
        {
            Console.WriteLine($"Please enter the name of your sweepstake.");
            string userInput = Console.ReadLine();
            string results = DataValidation(userInput);
            int resultToInt = int.Parse(results);
            return resultToInt;
        }
        public static string DataValidation(string userInput)
        {
            while (String.IsNullOrEmpty(userInput))
            {
                Console.WriteLine($"Please enter valid input");
                userInput = Console.ReadLine();
            }
            return userInput;
        }
    }
}
