using System;
using System.Collections.Generic;

namespace workshop
{
    public class FactorByCategoryOffer : Offer 
    {
        internal readonly Category category;
        internal readonly int factor;

        public FactorByCategoryOffer(Category category, int factor, DateTime expireDade) 
        {
            this.category = category;
            this.factor = factor;
            this.expireDate = expireDade;
        }

        public FactorByCategoryOffer(Category category, int factor) 
        {
            this.category = category;
            this.factor = factor;
            this.expireDate = DateTime.MaxValue;
        }
        

        public override void Apply(Check check)
        {
            if (expireDate > DateTime.Today)
            {
                int points = check.GetCostByCategory(category);
                check.AddPoints(points * (factor - 1));
            }
        }
    }
}
