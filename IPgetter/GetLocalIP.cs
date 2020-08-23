using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace IPgetter
{
    public static class GetLocalIP
    {
        static string ip = default;

        public static string IP()
        {
            string nameMachine = Dns.GetHostName();
            IPHostEntry ipEntry = Dns.GetHostEntry(nameMachine);
            IPAddress[] ip = ipEntry.AddressList;
            IPAddress localIp = ip[ip.Length - 1];
            Console.WriteLine($"Machine Name = {localIp}");
            return localIp.ToString();
            if (localIp == null) return null;
        }

    }
}
