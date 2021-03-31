using System;

namespace workshop
{
    public abstract class Offer 
    {
        public DateTime expireDate; 
        public abstract void Apply(Check check);
    }
}
