using System;
using System.Net;
using Xceed.Wpf.Toolkit;

namespace GetMyIp
{
    class Program
    {
        static void Main(string[] args)
        {
            string host = Dns.GetHostName();
            int ipNumbrer = Dns.GetHostByName(host).AddressList.Length - 1;
            string ip = Dns.GetHostByName(host).AddressList[ipNumbrer].ToString();
            Console.WriteLine(ip);
            Console.ReadLine();
        }   
    }
}
