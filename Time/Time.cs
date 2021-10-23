using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Time
{
    public class Time
    {
        #region Fields
        private int hours;
        private int minutes;
        private int seconds;
        #endregion
        #region Constructors
        public Time()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        #endregion
        #region Properties
        public int Hours{ get { return hours; } set { hours = value<60?value:value%60; } }
        public int Minutes { get { return minutes; } set { minutes = value < 60 ? value : value % 60; } }
        public int Seconds { get { return seconds; } set { seconds = value < 60 ? value : value % 60; } }

        #endregion
        #region Methods
        public Time(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        #endregion
        public override string ToString()
        {
            return string.Format($" {hours}" + $": {minutes}\n" +
            $": {seconds}");
        }
    }
}