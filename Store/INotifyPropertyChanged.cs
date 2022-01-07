using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWeek9
{
    interface INotifyPropertyChanged
    {
        event EventHandler Appoint;
        event PropertyChangedEventHandler PropertyChanged;

    }
}
