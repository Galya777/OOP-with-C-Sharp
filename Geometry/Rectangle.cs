using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Rectangle
    {
        #region Fields
        public delegate double CompareBy(Rectangle r);

        public readonly string R_ID;
        private static readonly char[] indexes = new[] { 'x', 'y', 'w', 'h' };
        private static int cntID = 1;
        private double length;
        private double width;
        private Point leftPoint;
        #endregion

        #region Constructor
        public Rectangle(double length, double width, Point leftPoint)
        {
            Length = length;
            Width = width;
            LeftPoint = leftPoint;
            R_ID = string.Format($"{cntID++:D6}");
        }
        public Rectangle() : this(0, 0, new Point())
        {

        }
        public Rectangle(Rectangle r) : this(r.length, r.width, r.leftPoint)
        {

        }
        #endregion


        #region Properties
        public Point LeftPoint
        {
            get
            {
                return new Point(leftPoint);
            }
            set
            { 
                leftPoint = value != null ? new Point(value) : new Point();
            }
        }
        public double Length
        {
            get { return length; }
            set { length = value >= 0 ? value : 0; }
        }

        public double Width
        {
            get { return width; }
            set { width = value >= 0 ? value : 0; }
        }

        public double this[char index]
        {
            get
            { /* return the specified index here */
                // validate idex
                if (indexes.Contains(index))
                {
                    switch (index)
                    {
                        case 'w': return width;
                        case 'l': return length;
                        case 'x': return leftPoint['x'];
                        case 'y': return leftPoint['y'];

                    }
                }
                return double.MaxValue;
            }
            set
            {

                if (indexes.Contains(index))
                {
                    switch (index)
                    {
                        case 'w': width = value >= 0 ? value : 0; break;
                        case 'l': length = value >= 0 ? value : 0; break;
                        case 'x': leftPoint['x'] = value; break;
                        case 'y': leftPoint['y'] = value; break;

                    }
                }
            }
        }

        #endregion

        #region Utility methods
        public static double Area(Rectangle r)
        {
            return r.length * r.width;
        }
        public static IEnumerable<Rectangle> SortBy(List<Rectangle> list, CompareBy compare)
        {
            var sort = list.OrderBy(r=>compare(r));
            return sort;
        }
        #endregion

        public override string ToString()
        {
            return string.Format($"Rectangle:{R_ID}  Length: {length}, Width:{width}, LeftPoint: {leftPoint}");
        }
    }
}
