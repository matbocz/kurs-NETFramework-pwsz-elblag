using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace FoldersAndFilesApp
{
    class HostIP
    {
        public static string ShowIPAddress(string hostName)
        {
            IPAddress[] addresslist = Dns.GetHostAddresses(hostName);
            string adresses = "";

            foreach (IPAddress ipa in addresslist)
            {
                adresses += ipa.ToString();
            }

            return adresses;
        }

        public static void ReadFileToScreen(string filename)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    string hostline = "", stringAfterPing;
                    IPAddress afterPing;

                    while (hostline != null)
                    {
                        hostline = sr.ReadLine();

                        afterPing = HostPingIPAddress(hostline);
                        stringAfterPing = afterPing.ToString();

                        Console.WriteLine("Host: {0}; IP: {1}; Ping: {2}", hostline, ShowIPAddress(hostline), stringAfterPing);
                    }
                }
            }
            catch { }
        }

        public static IPAddress HostPingIPAddress(string hostName)
        {
            Ping ping = new Ping();
            var replay = ping.Send(hostName);

            if (replay.Status == IPStatus.Success)
            {
                return replay.Address;
            }
            else return null;
        }
    }
}