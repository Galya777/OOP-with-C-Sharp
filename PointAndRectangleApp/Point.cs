﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_task2
{
    public class Point
    {
        private int[] coordinates;
        #region Constructors
        //General-Purpose constructor
        public Point(int[] coordinates)
        {
            Coordinates = coordinates;
        }

        //Default constructor
        public Point():this(new int[2])
        {
                
        }
        //Copy Constructor
        public Point(Point point):this(point.coordinates)
        {

        }
        #endregion
        public int[] Coordinates
        {
            get { return new[] { coordinates[0], coordinates[1] }; }
            set {
                coordinates = value != null && value.Length == 2 ? new int[] { value[0], value[1] } : new int[2]; 
            }
        }

        public override string ToString()
        {
            return string.Format($"{string.Join(",", coordinates)}");
        }

    }
}
