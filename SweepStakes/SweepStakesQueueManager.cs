using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakesQueueManager : ISweepStakesManager
    {
        Queue<SweepStake> queue;
        
        public SweepStakesQueueManager()
        {
            queue = new Queue<SweepStake>();
        }

        public void InsertSweepStakes(SweepStake sweepstake)
        {
            queue.Enqueue(sweepstake);
        }

        public SweepStake GetSweepStakes()
        {
           
            return queue.Dequeue();
        }
    }
}
