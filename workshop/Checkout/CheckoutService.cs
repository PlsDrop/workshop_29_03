using System;
using System.Collections.Generic;

public class CheckoutService 
{

    private Check check;

    public void OpenCheck() 
    {
        check = new Check();
    }

    public void AddProduct(Product product) 
    {
        if (check == null) 
        {
            OpenCheck();
        }
        check.AddProduct(product);
    }

    public Check CloseCheck() 
    {
        Check closedCheck = check;
        check = null;
        return closedCheck;
    }

    public void UseOffer(Offer offer) 
    {
        offer.Apply(check);
        if (offer is FactorByCategoryOffer) 
        {
            FactorByCategoryOffer fbOffer = (FactorByCategoryOffer) offer;
            int points = check.GetCostByCategory(fbOffer.category);
            check.AddPoints(points * (fbOffer.factor - 1));
        } 
        else 
        {
            if (offer is AnyGoodsOffer) 
            {
                AnyGoodsOffer agOffer = (AnyGoodsOffer) offer;
                if (agOffer.totalCost <= check.GetTotalCost())
                    check.AddPoints(agOffer.points);
            }
        }
    }
}
