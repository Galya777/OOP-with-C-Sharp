using System;
using System.Collections;
using System.Timers;
using System.Windows.Threading;

namespace Delegates
{
	class Ticker
	{
        public delegate void Tick(int hh, int mm, int ss);

        private Tick tickers;
        private DispatcherTimer ticking ;    
    
        public Ticker()
		{
            ticking = new DispatcherTimer(); 
            this.ticking.Tick += new EventHandler(this.OnTimedEvent);
            this.ticking.Interval = new TimeSpan(0, 0, 1); // 1 second
            this.ticking.Start();
        }

		public void Add(Tick newMethod)
		{
			this.tickers += newMethod;
		}
		
		public void Remove(Tick oldMethod)
		{
			//this.tickers =null;
            while (tickers.GetInvocationList().Length>0)
            {
                tickers -= oldMethod;
            }
		}

		private void Notify(int hours, int minutes, int seconds)
		{
			this.tickers?.Invoke(hours, minutes, seconds);
            //if (this.tickers != null)
            //    this.tickers(hours, minutes, seconds);
        }
	
		private void OnTimedEvent(object source, EventArgs args)
		{
            DateTime now = DateTime.Now;
            int hh = now.Hour;
            int mm = now.Minute;
            int ss = now.Second;
            Notify(hh, mm, ss);
		}


	}
}
