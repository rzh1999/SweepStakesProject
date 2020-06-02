using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStake
    {
        private Dictionary<int, Contestant> _contestants;

        private string name;
        public string Name { get => name; set => name = value; }
       

        public SweepStake()
        {
            _contestants = new Dictionary<int, Contestant>();
        }
        public string SweepStakes() {
            return UserInterface.GetSweepStakesName();
        }

       public void RegisterContestant(Contestant contestant)
        {
            if (contestant != null)
            {
                _contestants.Add(contestant.registrationNumber, contestant);
            }
        }

        public Contestant PickWinner()
        {
            List<int> keyList = new List<int>(_contestants.Keys);

            Random random = new Random();

            int randomKey = keyList[random.Next(keyList.Count)];

            return _contestants[randomKey];
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"Contestant info: {contestant.registrationNumber} {contestant.firstName} {contestant.lastName}");
        }
    }
}
