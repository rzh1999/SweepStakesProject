using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Simulation
    {
        public void RunSweepStakes()
        {
            UserInterface.Greeting();

        }

        public void CreateMarketingFirmWithManager()
        {
            var queueOrStack = UserInterface.QueueOrStack();
            MarketingFirm marketingFirm = new MarketingFirm(queueOrStack);
        }
        public Contestant CreateContestant(int numberOfContestants)
        {
            string firstName = null;
            string lastName = null;
            string emailAddress = null;
            for (int i = 0; i < numberOfContestants; i++)
            {
                firstName = UserInterface.GetFirstName();
                lastName = UserInterface.GetLastName();
                emailAddress = UserInterface.GetEmailAddress();
            }
            return new Contestant(firstName, lastName, emailAddress);
            
        }
    }
}
