# AutoTaskScheduler

Auto Task Scheduler is a feature in **ASP.NET Core** that allows you to schedule tasks to run automatically at specific times. This feature is useful for running tasks such as sending emails, updating data, or performing other background tasks. 

There are several ways to implement Auto Task Scheduler in ASP.NET Core. One way is to use the **Quartz.NET** library, which provides a powerful and flexible scheduling framework for .NET applications ¹. Another way is to use the **IHostedService** interface, which allows you to create a background service that runs automatically when your application starts ³. 

If you choose to use Quartz.NET, you can define jobs and triggers to schedule tasks to run at specific times. You can also configure the scheduler to run tasks on a recurring basis, such as every day at 9:00 AM ¹. 

If you choose to use IHostedService, you can create a background service that runs automatically when your application starts. You can then use the **System.Threading.Timer** class to schedule tasks to run at specific times ³. 

Both of these approaches have their own advantages and disadvantages, so it's important to choose the one that best fits your needs. I hope this helps!

Source: Conversation with Bing, 11/13/2023
(1) c# - .Net Core 6 Create Scheduling Task - Stack Overflow. https://stackoverflow.com/questions/72373372/net-core-6-create-scheduling-task.
(2) Running automatic tasks in .NET Core WebAPI - Medium. https://medium.com/@niteshsinghal85/running-automatic-task-in-asp-net-core-webapi-d5605b3a1114.
(3) A Dynamic Task Scheduler for ASP.NET Core - DZone. https://dzone.com/articles/a-dynamic-task-scheduler-for-aspnet-core.
(4) Telerik UI for ASP.NET Core Scheduler Overview. https://demos.telerik.com/aspnet-core/scheduler.
(5) ASP.NET Core MVC scheduled task - Stack Overflow. https://stackoverflow.com/questions/40050753/asp-net-core-mvc-scheduled-task.
