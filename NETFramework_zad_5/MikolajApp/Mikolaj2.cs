using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikolajApp
{
    public class Mikolaj2
    {
        public Mikolaj2(Clock clock1)
        {
            clock1.clockEvent += GiveGift;
        }

        public void GiveGift(object sender, TimeInfoEventArgs t)
        {
            if (sender.GetType().Equals(typeof(Clock)))
            {
                try
                {
                    string[] lines = System.IO.File.ReadAllLines(((Clock)sender).filename);
                    Console.ForegroundColor = (ConsoleColor)((new Random()).Next(15));

                    foreach (string line1 in lines)
                    {
                        Console.WriteLine(line1);
                    }
                }
                catch { }
                finally
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
