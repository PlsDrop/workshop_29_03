using System;
using System.Collections.Generic;

namespace workshop
{
    public class ByAnyGoods : Condition
    {
        internal readonly int totalCost;
        internal readonly int points;

        public ByAnyGoods(int totalCost, int points)
        {
            this.totalCost = totalCost;
            this.points = points;
        }

        // implementation

        // public override void Apply(Check check) 
        // {
        //     if ((expireDate > DateTime.Today) && (totalCost <= check.GetTotalCost()))
        //         check.AddPoints(points);
        // }
    }
}
