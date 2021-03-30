using System;
using System.Collections.Generic;

namespace workshop
{
    public class FactorByTradeMarkOffer : Offer 
    {
        internal readonly TM tm;
        internal readonly int factor;

        public FactorByTradeMarkOffer(TM tm, int factor, DateTime expireDade) 
        {
            this.tm = tm;
            this.factor = factor;
            this.expireDate = expireDade;
        }
        public FactorByTradeMarkOffer(TM tm, int factor) 
        {
            this.tm = tm;
            this.factor = factor;
            this.expireDate = DateTime.MaxValue;
        }
        public override void Apply(Check check)
        {
            if (expireDate > DateTime.Today)
            {
                int points = check.GetCostByTM(tm);
                check.AddPoints(points * (factor - 1));
            }
        }
    }
}