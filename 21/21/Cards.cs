using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21
{
    public class Cards
    {

        public int value;

        public Cards() 
        {
            this.value = 0;
        }
        public override string ToString()
        {
            return $"{value}";
        }
    }
}