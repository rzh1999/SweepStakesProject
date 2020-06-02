﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;
        public Random random;

        public Contestant()
        {
            random = new Random();
            registrationNumber = CreateRegistrationNumber();
        }

        public int CreateRegistrationNumber()
        {
            return random.Next(1000000, 2000000);
        }
    }
}