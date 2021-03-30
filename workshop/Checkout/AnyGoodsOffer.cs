using System;
using System.Collections.Generic;

public class AnyGoodsOffer : Offer 
{
    public readonly int totalCost;
    public readonly int points;

    public AnyGoodsOffer(int totalCost, int points) 
    {
        this.totalCost = totalCost;
        this.points = points;
    }

    public override void Apply(Check check) 
    {

    }
}
