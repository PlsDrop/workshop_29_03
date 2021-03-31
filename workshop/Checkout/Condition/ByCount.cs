using System;
using System.Collections.Generic;

namespace workshop
{
    public class ByCount : Condition 
    {
        internal readonly int cond;

        public ByCount(int cond) 
        {
            this.cond = cond;
        }

        // implementation
    }
}