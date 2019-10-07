using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PtocessKill
{
    static class KillerP
    {

        public static void LoadAllProcess()
        {
            var allProcess = from proc in Process.GetProcesses(".") 
                             orderby proc.Id
                             select new { proc.ProcessName, proc.Id };


            int numbers = 0;
            foreach(var p in allProcess)
            {
                Console.WriteLine("[{0}]  {1} {2}", numbers, p.Id, p.ProcessName);
                numbers++;
                
            }
        }
        
        public static void GetProcess(int id)
        {
            Process process = null;
            try
            {
                process = Process.GetProcessById(id);
                
                process.Kill();

                Console.WriteLine("Процесс {0} убит", process.ProcessName);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }

        public static void Start(string startProcessName, string url)
        {
            //TODO: проверка.
            if (string.IsNullOrWhiteSpace(startProcessName))
            {
                throw new ArgumentNullException("имя процесса не может быть Null");
            }

            Process startProcess = null;
            try
            {
                startProcess = Process.Start(startProcessName, url);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
