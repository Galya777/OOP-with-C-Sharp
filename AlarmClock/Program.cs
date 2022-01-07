using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
   public class Program
    {
        public static void Main(string[] args)
        {
            AlarmClock clock = new AlarmClock();
            clock.Alarm += OnRing1;
            clock.Alarm += OnRing2;
            clock.PropertyChanged += OnPropertyChanged;
            clock.Rings = 5;
            clock.RingTime = 3000;
            clock.Start();
        }

        private static void OnRing1(object sender, EventArgs args)
        {
            int rings = ((AlarmEventArgs)args).NRings;
            Console.WriteLine("Ring1: {0}", rings);
        }
        private static void OnRing2(object sender, EventArgs args)
        {
            int rings = ((AlarmEventArgs)args).NRings;
            Console.WriteLine("Ring2: {0}", rings);
        }
        private static void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            Console.WriteLine("New ringtime setup.{0}", args.PropertyName);
        }
    }
}
