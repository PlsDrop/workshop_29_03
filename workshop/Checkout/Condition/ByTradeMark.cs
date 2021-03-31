using System;
using System.Collections.Generic;

namespace workshop
{
    public class ByTradeMark : Condition 
    {
        internal readonly TM tm;

        public ByTradeMark(TM tm) 
        {
            this.tm = tm;
        }

        // implementation
    }
}