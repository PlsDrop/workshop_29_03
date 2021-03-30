using System;
using System.Collections.Generic;

namespace workshop
{
    public class AnyGoodsOffer : Offer 
    {
        internal readonly int totalCost;
        internal readonly int points;

        public AnyGoodsOffer(int totalCost, int points, DateTime expireDate) 
        {
            this.totalCost = totalCost;
            this.points = points;
            this.expireDate = expireDate;
        }

        public AnyGoodsOffer(int totalCost, int points) 
        {
            this.totalCost = totalCost;
            this.points = points;
            this.expireDate = DateTime.MaxValue;
        }

        public override void Apply(Check check) 
        {
            if ((expireDate > DateTime.Today) && (totalCost <= check.GetTotalCost()))
                check.AddPoints(points);
        }
    }
}
