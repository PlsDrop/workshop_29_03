using workshop;
using System;

namespace workshop
{
    public class PercentDiscount : DiscountRule
    {
        internal readonly int percent;
        public PercentDiscount(int percent)
        {
            this.percent = percent;
        }

    }
}