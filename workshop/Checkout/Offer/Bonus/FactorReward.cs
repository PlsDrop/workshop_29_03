using workshop;
using System;

namespace workshop
{
    public class FactorReward : BonusRule
    {   
        internal readonly int factor;
        public FactorReward(int factor)
        {
            this.factor = factor;
        }
    }
}