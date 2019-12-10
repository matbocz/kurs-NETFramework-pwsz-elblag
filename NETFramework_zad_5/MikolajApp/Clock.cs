using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MikolajApp
{
    public class Clock
    {
        public string filename;

        public delegate void ClockDelegateType(object sender, TimeInfoEventArgs t);
        public event ClockDelegateType clockEvent;

        private int timeInterval;

        public Clock(int x)
        {
            timeInterval = x;
        }

        public void RunClock()
        {
            int i = 0;
            System.DateTime newDateTime;
            TimeInfoEventArgs t;

            FileInfo[] filesInfo = (new DirectoryInfo("pictures")).GetFiles();
            int imax = filesInfo.Length - 1;

            for (; ; )
            {
                Thread.Sleep(timeInterval);
                newDateTime = System.DateTime.Now;

                t = new TimeInfoEventArgs(newDateTime.Hour, newDateTime.Minute, newDateTime.Second);
                this.filename = "pictures\\" + filesInfo[i].Name;

                clockEvent(this, t);

                i = (i == imax) ? 0 : i + 1;
            }
        }
    }
}
