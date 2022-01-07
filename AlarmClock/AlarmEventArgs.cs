using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    public class AlarmEventArgs: EventArgs
    {
        private int nrings;
        public AlarmEventArgs(int nrings)
        {
            NRings = nrings;
        }
        public int NRings
        {
            get { return nrings; }
            set { nrings = value; }
        }

    }
}
