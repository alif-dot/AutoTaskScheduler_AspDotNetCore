using AutoTaskScheduler.Models;
using Quartz;
using Quartz.Spi;

namespace AutoTaskScheduler.Service
{
    public class QuartzHostedService : IHostedService
    {
        private readonly ISchedulerFactory _scedulerFactory;
        private readonly IJobFactory _jobFactory;
        private readonly IEnumerable<MyJob> _myJobs;

        public QuartzHostedService(ISchedulerFactory scedulerFactory, IJobFactory jobFactory, IEnumerable<MyJob> myJobs)
        {
            _scedulerFactory = scedulerFactory;
            _jobFactory = jobFactory;
            _myJobs = myJobs;
        }

        public IScheduler Scheduler { get; set; }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            Common.Logs($"StartAsync at " + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"), "StartAsync" + DateTime.Now.ToString("hhmmss"));

            Scheduler = await _scedulerFactory.GetScheduler(cancellationToken);
            Scheduler.JobFactory = _jobFactory;
            foreach (var myJob in _myJobs)
            {
                var job = CreateJob(myJob);
                var trigger = CreateTrigger(myJob);
                await Scheduler.ScheduleJob(job, trigger, cancellationToken);
            }
            await Scheduler.Start(cancellationToken);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            Common.Logs($"StopAsync at " + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"), "StopAsync" + DateTime.Now.ToString("hhmmss"));

            await Scheduler.Shutdown(cancellationToken);
        }

        private static IJobDetail CreateJob(MyJob myJob)
        {
            var type = myJob.Type;
            return JobBuilder.Create(type).WithIdentity(type.FullName).WithDescription(type.Name).Build();
        }

        private static ITrigger CreateTrigger(MyJob myJob)
        {
            return TriggerBuilder.Create().WithIdentity($"{myJob.Type.FullName}.trigger").WithCronSchedule(myJob.Expression).WithDescription(myJob.Expression).Build();
        }
    }
}
