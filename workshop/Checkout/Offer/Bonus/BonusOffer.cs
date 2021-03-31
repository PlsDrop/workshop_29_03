using workshop;
using System;

namespace workshop
{
    public class BonusOffer : Offer
    {
        internal readonly DateTime dateTime;
        internal readonly Condition condition;
        internal readonly BonusRule bonusRule;

        public BonusOffer(DateTime dateTime, Condition condition,  BonusRule bonusRule)
        {
            this.dateTime = dateTime;
            this.condition = condition;
            this.bonusRule = bonusRule;
        }

        public override void Apply(Check check)
        {
            // implementation
        }

    }
}