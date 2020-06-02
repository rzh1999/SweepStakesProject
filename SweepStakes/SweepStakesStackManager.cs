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

        public SweepStakesStackManager()
        {
            stack = new Stack<SweepStake>();
        }
        public void InsertSweepStakes(SweepStake sweepStake)
        {
            stack.Push(sweepStake);
        }

        public SweepStake GetSweepStakes()
        {
            
            return stack.Pop();
        }


    }
}
