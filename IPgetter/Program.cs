using System;
using System.Collections.Generic;
using System.Net;

namespace IPgetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = GetLocalIP.IP();
            Console.WriteLine($"{ip}");
            Console.ReadLine();
        }
    }
}
