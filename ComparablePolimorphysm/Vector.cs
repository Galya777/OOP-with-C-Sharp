using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public struct Vector
    {
        private Point sp;//Point is value type
        private Point ep;

        public Vector(Point sp, Point ep)
        {
            this.sp = sp;
            this.ep = ep;
        }
        
        public override string ToString()
        {
            return string.Format($"Starting point={sp}, Ending point= {ep}");
        }
    }
}
