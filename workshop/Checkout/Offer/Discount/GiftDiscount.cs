using workshop;
using System;

namespace workshop
{
    public class GiftDiscount : DiscountRule
    {
        internal readonly int price;
        public GiftDiscount(int price)
        {
            this.price = price;
        }

    }
}