using WinServiceNet46.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WinServiceNet46
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {

#if DEBUG
            JobHelper.JobLoader();
            Console.Read();
#else
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new WinServiceNet46() 
            };
            ServiceBase.Run(ServicesToRun);
#endif

        }
    }
}
