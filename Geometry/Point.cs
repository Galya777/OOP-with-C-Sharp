using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Point
    {

        private int[] coordinates;

   
        public Point(int[] coordinates)
        {
            Coordinates = coordinates;
        }
        
        public Point() : this(new[] { 0, 0 })
        {

        }

        public Point(Point point) : this(point.coordinates)
        {

        }
        public int[] Coordinates
        {
            get
            {
                // reference mutable type!!!
                //var temp = new int[coordinates.Length];
                //for (int i = 0; i < coordinates.Length; i++)
                //{
                //    temp[i] = coordinates[i];
                //}
                //return temp; 
                return new int[] { coordinates[0], coordinates[1] };
            }
            set
            {
                // reference mutable type!!!
                if (value != null && value.Length == 2) // value != null ->obligatory for reference types for business object
                {
                    //coordinates = new int[value.Length];
                    //for (int i = 0; i < coordinates.Length; i++)
                    //{
                    //    coordinates[i] = value[i];
                    //}
                    coordinates = new int[] { value[0], value[1] };
                }
                else
                {
                    coordinates = new int[2]; // [0,0]
                }

            }


        }
        public double this[char index]
        {
            get
            {
                if (index == 'x' || index == 'y')
                {
                    if (index == 'x')
                        return coordinates[0];
                    else
                        return coordinates[1];
                }
                else
                {
                    return int.MaxValue;
                }
            }
            set
            { /* set the specified index to value here */
                if (index == 'x' || index == 'y')
                {
                    if (index == 'x')
                        coordinates[0] = (int)value;
                    else
                        coordinates[1] = (int)value;
                }
            }

        }
        public override string ToString()
        {
            return string.Format($"{string.Join(",", coordinates)}");
        }
    }


}
