using workshop;
using System;

namespace workshop
{
    public class FlatReward : BonusRule
    {
        internal readonly int reward;
        public FlatReward(int reward)
        {
            this.reward = reward;
        }
    }
}