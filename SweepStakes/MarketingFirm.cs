﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class MarketingFirm 
    {
        private ISweepStakesManager _manger;
       
        public  MarketingFirm(ISweepStakesManager _manager)
        {
            this._manger = _manager;
        }

       

        public void CreateSweepStakes()
        {
            string sweepStakesName = UserInterface.GetSweepStakesName();
            SweepStake sweepStake = new SweepStake(sweepStakesName);
            //Then insert it using manager
            _manger.InsertSweepStakes(sweepStake);
        }
    }
}
