using System;
using workshop;

namespace workshop
{
    public class DiscountOffer : Offer
    {
        internal readonly DateTime dateTime;
        internal readonly Condition condition;
        internal readonly DiscountRule discountRule;

        public DiscountOffer(DateTime dateTime, Condition condition,  DiscountRule discountRule)
        {
            this.dateTime = dateTime;
            this.condition = condition;
            this.discountRule = discountRule;
        }

        public override void Apply(Check check)
        {
            // implementation
        }
    }
}