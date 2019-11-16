using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripCalcAndEnvironmentInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;

            Console.WriteLine("----------- Trip Calc And Environment Info App -----------");
            Console.WriteLine("<Left>-Trip calculation, <Right>-Info about environment");

            while (true)
            {
                Console.WriteLine("\n Press an <Arrow> key or <Esc> to exit: ");
                key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow: TripCalcAndEnvironmentInfo.TripCalc(); break;
                    case ConsoleKey.RightArrow: TripCalcAndEnvironmentInfo.EnvironmentInfo(); break;
                    case ConsoleKey.Escape: return;
                }
            }
        }
    }
}