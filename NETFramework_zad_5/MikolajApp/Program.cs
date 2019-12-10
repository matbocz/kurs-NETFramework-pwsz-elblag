using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikolajApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Media.SoundPlayer soundplayer = new System.Media.SoundPlayer("music/jingle_bell.wav");
            soundplayer.Play();

            Clock clock1 = new Clock(1000);

            Mikolaj1 mikolaj1 = new Mikolaj1(clock1);
            Mikolaj2 mikolaj2 = new Mikolaj2(clock1);

            clock1.RunClock();
        }
    }
}
