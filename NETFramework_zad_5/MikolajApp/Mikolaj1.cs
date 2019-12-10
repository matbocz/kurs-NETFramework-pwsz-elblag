using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikolajApp
{
    public class Mikolaj1
    {
        public Mikolaj1(Clock clock1)
        {
            clock1.clockEvent += GiveGift;
        }

        public void GiveGift(object sender, TimeInfoEventArgs t)
        {
            Console.WriteLine("{0}:{1}:{2}", t.h, t.m, t.s);
        }
    }
}
