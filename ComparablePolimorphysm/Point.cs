using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public struct Point:IComparable<Point>
    {
        private double x;
        private double y;
        private double z;

        public Point(double x,double y,double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())return false;
            //Points are equal if coordinates are equal
                
            
            if(x==((Point)obj).x&&y== ((Point)obj).y && z== ((Point)obj).z){
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            var norm = Math.Abs(x) + Math.Abs(y) + Math.Abs(y);
            return (int)norm;
        }
        public static bool operator==(Point obj1, Point obj2)
        {
            return obj1.Equals(obj2);
        }
        public static bool operator !=(Point obj1, Point obj2)
        {
            return obj1.Equals(obj2);
        }
        public override string ToString()
        {
            return string.Format($"X={x}, Y={y}, Z={z}");
        }

        public int CompareTo(Point other)
        {
            if (x == other.x && y==other.y && z==other.z) return 0;
            var normThis = Math.Abs(x) + Math.Abs(y) + Math.Abs(y);
            var normObject = Math.Abs(x) + Math.Abs(y) + Math.Abs(y);
            return (int)(normThis - normObject);
        }
    }
}
