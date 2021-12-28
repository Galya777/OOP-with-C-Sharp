using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bits
{
    public class IntBits
    {
        private int bits;

        public IntBits(int bits)
        {
            this.bits = bits;
        }

        public bool this[int index]
        {
            get
            { /* return the specified index here */
                if (index >= 0 && index < 32)
                {
                    return (bits & (1 << index)) == 0 ? false : true;
                }
                return false;
            }
            set
            { /* set the specified index to value here */
                if (index >= 0 && index < 32)
                {
                    if (value)
                    {
                        bits |= 1 << index;
                    }
                    else
                    {
                        bits &= ~(1 << index);
                    }
                }
            }
        }

        public override string ToString()
        {
            var mask = 1 << 31;
            var output = "";
            var data = bits;
            for (int i = 0; i < 32; i++)
            {
                output += (data & mask) == 0 ? "0" : "1";
                data <<=1;
            }
            return output;
        }
    }
}
