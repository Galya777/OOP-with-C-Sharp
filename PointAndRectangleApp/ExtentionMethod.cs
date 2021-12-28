using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_Problem2Test
{
   public class ExtentionMethod
    {
        public static double Perimeter(this Rectangle rectangle)
        {
            var lpCoordinates = rectangle.LowerRightPoint.Coordinates;
            var upCoord= rectangle.UpperRightPoint.Coordinates;
            var length= Math.Abs(rectangle.LowerRightPoint[0]- rectangle.UpperRightPoint[0]);
            var width= Math.Abs(rectangle.LowerRightPoint[1] - rectangle.UpperRightPoint[1]);
            return 2 * (length + width);
        }
    }
}
