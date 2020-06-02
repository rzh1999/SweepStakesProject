using System;
using System.Collections.Generic;
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
            Console.ReadLine();
        }
    }
}
