using System;
using System.Collections.Generic;

public class FactorByCategoryOffer : Offer 
{
    public readonly Category category;
    public readonly int factor;

    public FactorByCategoryOffer(Category category, int factor) 
    {
        this.category = category;
        this.factor = factor;
    }

    public override void Apply(Check check)
    {

    }
}
