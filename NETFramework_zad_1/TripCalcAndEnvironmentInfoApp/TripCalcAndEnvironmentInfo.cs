using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripCalcAndEnvironmentInfoApp
{
    class TripCalcAndEnvironmentInfo
    {
        public static void EnvironmentInfo()
        {
            Console.WriteLine("\nMachine Information");
            Console.WriteLine("======================");

            Console.WriteLine("Machine Name: " + Environment.MachineName);
            Console.WriteLine("OS Version: " + Environment.OSVersion);
            Console.WriteLine("System Directory: " + Environment.SystemDirectory);
            Console.WriteLine("User Name: " + Environment.UserName);
            Console.WriteLine("Version: " + Environment.Version);
            Console.WriteLine("Current Directory: " + Environment.CurrentDirectory);

            Console.WriteLine("\nAvailable drives");
            Console.WriteLine("======================");

            string[] drives = Environment.GetLogicalDrives();
            foreach (string drive in drives)
                Console.WriteLine(drive);
        }

        public static void TripCalc()
        {
            Console.WriteLine("\nCaclulate your trip");
            Console.WriteLine("======================");

            Console.Write("Distance in km: ");
            string x = Console.ReadLine();
            decimal a = Convert.ToDecimal(x);

            Console.Write("Fuel per 100km: ");
            x = Console.ReadLine();
            decimal b = Convert.ToDecimal(x);

            Console.Write("Petrol price: ");
            x = Console.ReadLine();
            decimal c = Convert.ToDecimal(x);

            decimal d = ((b * a) / 100) * c;
            Console.WriteLine("Distance: {0} km, cost: {1} PLN", a, d);
        }
    }
}