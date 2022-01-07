using System;
using System.Collections;
using System.Timers;
using System.Windows.Threading;
using System.Windows.Controls;

namespace Delegates
{
	class Clock
	{
		private Ticker pulsed ;
        private TextBox display;
        private DispatcherTimer timer;
        
        public Clock(TextBox displayBox)
        {
            timer = new DispatcherTimer();
            this.timer.Tick += new EventHandler(this.OnTimedEvent);
            this.timer.Interval = new TimeSpan(0, 0, 1); // 1 second
            this.timer.Start();
            pulsed = new Ticker();
            this.display = displayBox;

        }
        private void OnTimedEvent(object source, EventArgs args)
        {
            DateTime now = DateTime.Now;
            int hh = now.Hour;
            int mm = now.Minute;
            int ss = now.Second;
            this.display.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", hh, mm, ss);
        }

        public void Start()
		{
            //second approach
            timer.Start();
            //first aproach
            //pulsed.Add(RefreshTime);
            
            //pulsed.Add((int hh, int mm, int ss)=>
            //display.Text= string.Format("{0:D2}:{1:D2}:{2:D2}", hh, mm, ss));
            // To do
        }

		public void Stop()
		{
            // To do
            timer.Stop();
            //pulsed.Remove(RefreshTime);
        }

		private void RefreshTime(int hh, int mm, int ss)
		{
			this.display.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", hh, mm, ss);
		}


    }
}
