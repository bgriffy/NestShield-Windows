using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShield
{
    class Logger
    {
        public HashSet<string> processNames = new HashSet<string>();

        System.Timers.Timer timer = new System.Timers.Timer();

        public void start()
        {
            timer.Interval = 2000; // 2 seconds
            timer.Elapsed += new System.Timers.ElapsedEventHandler(getActiveProcesses);
            timer.Start();
        }

        public void getActiveProcesses(object sender, System.Timers.ElapsedEventArgs args)
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                processNames.Add(p.ProcessName);
            }
        }

        public void stop()
        {
            timer.Stop();
        }
    }
}
