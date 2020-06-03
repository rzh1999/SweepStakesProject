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
            UserInterface.GetMarketingFirmManager();

        }

        public void CreateMarketingFirmWithManager()
        {
            string managerType = UserInterface.GetMarketingFirmManager();

            if (Equals(managerType.ToLower(), "queue"))
            {

            }
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
