using AutoTaskScheduler.Models;
using Quartz;

namespace AutoTaskScheduler.Service
{
    public class JobReminders : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            Common.Logs($"JobReminders at " + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"), "JobReminders" + DateTime.Now.ToString("hhmmss"));

            return Task.CompletedTask;
        }
    }
}
