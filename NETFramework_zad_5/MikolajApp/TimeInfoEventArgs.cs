using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikolajApp
{
    public class TimeInfoEventArgs : EventArgs
    {
        public int h, m, s;

        public TimeInfoEventArgs(int a, int b, int c)
        {
            h = a;
            m = b;
            s = c;
        }
    }
}
