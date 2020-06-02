using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakesStackManager : ISweepStakesManager
    {
        private Stack<SweepStake> stack;

        public void InsertSweepStakes(SweepStake sweepStake)
        {

        }

        public SweepStake GetSweepStakes()
        {
            //code here is just for removing error
            SweepStake sweepStake = new SweepStake();
            return sweepStake;
        }


    }
}
