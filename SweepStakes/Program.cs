using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Contestant contestant = new Contestant();
            Console.WriteLine($" Registration number equals {contestant.registrationNumber}");
            UserInterface.GetFirstName();
            
            Console.ReadLine();
        }
    }
}
