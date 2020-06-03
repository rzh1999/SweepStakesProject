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
       

        public SweepStake(string name)
        {
            this.Name = name;
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

        public void CreateContestant(int numberOfContestants)
        {
           
            string firstName = null;
            string lastName = null;
            string emailAddress = null;
            for (int i = 0; i < numberOfContestants; i++)
            {
                firstName = UserInterface.GetFirstName();
                lastName = UserInterface.GetLastName();
                emailAddress = UserInterface.GetEmailAddress();
                Contestant contestant = new Contestant(firstName, lastName, emailAddress);
                RegisterContestant(contestant);               
            }


        }
    }
}
