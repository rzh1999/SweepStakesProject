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
            CreateMarketingFirmWithManager();
            UserInterface.GetSweepStakesName();



            UserInterface.Greeting();
            UserInterface.GetLastName();
            UserInterface.GetFirstName();
            UserInterface.GetEmailAddress();

            

        }

        public void CreateMarketingFirmWithManager()
        {
            var queueOrStack = UserInterface.QueueOrStack();
            MarketingFirm marketingFirm = new MarketingFirm(queueOrStack);
        }


       
    }
}
