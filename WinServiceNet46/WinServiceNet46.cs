using Common.Logging;
using WinServiceNet46.Data;
using System.ServiceProcess;

namespace WinServiceNet46
{
    public partial class WinServiceNet46 : ServiceBase
    {
        ILog log = LogManager.GetLogger("Logger");

        public WinServiceNet46()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            JobHelper.JobLoader();
            log.Info("WinServiceNet46 Started");
        }

        protected override void OnStop()
        {
            JobHelper.QuartzShutdown(false);
            log.Info("WinServiceNet46 Stoped");
        }
    }
}
