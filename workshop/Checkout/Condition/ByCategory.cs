using System;
using System.Collections.Generic;

namespace workshop
{
    public class ByCategory : Condition 
    {
        internal readonly Category category;

        public ByCategory(Category category) 
        {
            this.category = category;
        }

        // implementation
        
        // public override void Apply(Check check)
        // {
        //     int points = check.GetCostByCategory(category);
        //     check.AddPoints(points * (factor - 1));
        // }
    }
}
