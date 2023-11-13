namespace AutoTaskScheduler.Models
{
    public class MyJob
    {
        public MyJob(Type type, string expression)
        {
            Common.Logs($"MyJob at " + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"), "MyJob" + DateTime.Now.ToString("hhmmss"));
            
            Type = type;
            Expression = expression;
        }

        public Type Type { get; }
        public string Expression { get; }
    }
}
