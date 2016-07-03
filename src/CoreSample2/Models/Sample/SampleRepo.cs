using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSample2.Models
{
    public class SampleRepo : ISample
    {
        private int Value;
        public int getValue()
        {
            return Value;
        }

        public void setValue(int value)
        {
            Value = value;
        }
    }
}
