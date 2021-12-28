using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_task2
{
   public class Rectangle:Point
    {

        private Point lowerRightPoint;
        

        #region Constructors
        //General-Purpose
        public Rectangle(Point UpperRightPoint, Point lowerRightPoint):base(UpperRightPoint)
        {
            LowerRigthPoint = lowerRightPoint;
        }
        //Default 
        public Rectangle():this(new Point(),new Point())
        {

        }
        //Copy
        public Rectangle(Rectangle r):this(r.UpperRightPoint, r.LowerRigthPoint)
        {
                
        }
        #endregion
        public Point LowerRigthPoint //Point is reference nutable type, has set Property
        {
            get { return new Point(lowerRightPoint); }
            set { lowerRightPoint = value!=null?new Point(value):new Point(); }
        }

        public Point UpperRightPoint //Point is reference nutable type, has set Property
        {
            get
            {
                return new Point(Coordinates);
            }
            set
            {
                Coordinates = value != null ? value.Coordinates : new int[2];
            }
        }

        public override string ToString()
        {
            return string.Format($"R: L={base.ToString()}, R={lowerRightPoint}");
        }

    }
}
