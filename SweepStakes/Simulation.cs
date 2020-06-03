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
        public Contestant CreateContestant()
        {
            string firstName = UserInterface.GetFirstName();
            string lastName = UserInterface.GetLastName();
            string emailAddress = UserInterface.GetEmailAddress();

            return new Contestant(firstName, lastName, emailAddress);
            
        }
    }
}
