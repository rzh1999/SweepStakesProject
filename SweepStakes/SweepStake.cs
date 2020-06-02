using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStake
    {
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name { get => name; set => name = value; }

        public string SweepStakes() {
            return UserInterface.GetSweepStakesName();
        }

       public void RegisterContestant(Contestant contestant)
        {
            if (contestant != null)
            {
                contestants.Add(contestant.registrationNumber, contestant);
            }
        }
    }
}
