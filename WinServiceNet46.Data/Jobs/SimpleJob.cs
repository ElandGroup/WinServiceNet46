using Common.Logging;
using Quartz;
using WinServiceNet46.Data.Service;

namespace WinServiceNet46.Data.Jobs
{
    [DisallowConcurrentExecution]
    public class SimpleJob : IJob
    {
        ILog log = LogManager.GetLogger("Logger");
        public void Execute(IJobExecutionContext context)
        {
            log.Info("SimpleJob");
        }

    }


}
