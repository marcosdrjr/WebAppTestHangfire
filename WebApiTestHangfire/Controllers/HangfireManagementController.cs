using Hangfire;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHangfire.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangfireManagementController : ControllerBase
    {
        //[HttpGet]
        //public string Get()
        //{
        //    Console.WriteLine($"Request: {DateTime.Now}");
        //    var jobFireForget = BackgroundJob.Enqueue(() => Debug.WriteLine($"Fire and forget: {DateTime.Now}"));
        //    var jobDelayed = BackgroundJob.Schedule(() => Debug.WriteLine($"Delayed: {DateTime.Now}"), TimeSpan.FromSeconds(30));
        //    BackgroundJob.ContinueWith(jobDelayed, () => Debug.WriteLine($"Continuation: {DateTime.Now}"));
        //    RecurringJob.AddOrUpdate(() => Debug.WriteLine($"Recurring: {DateTime.Now}"), Cron.Minutely);
        //    return "Jobs criados com sucesso!";
        //}
        [HttpGet]
        public object GetJobs()
        {
            //    Console.WriteLine($"Request: {DateTime.Now}");
            //    var jobFireForget = BackgroundJob.Enqueue(() => Debug.WriteLine($"Fire and forget: {DateTime.Now}"));
            //    var jobDelayed = BackgroundJob.Schedule(() => Debug.WriteLine($"Delayed: {DateTime.Now}"), TimeSpan.FromSeconds(30));
            //    BackgroundJob.ContinueWith(jobDelayed, () => Debug.WriteLine($"Continuation: {DateTime.Now}"));
            //    RecurringJob.AddOrUpdate(() => Debug.WriteLine($"Recurring: {DateTime.Now}"), Cron.Minutely);

            var getMonitoringApi = Hangfire.JobStorage.Current.GetMonitoringApi();
            int.TryParse(getMonitoringApi.DeletedListCount().ToString(), out int deletedListCount);
            var deletedList = getMonitoringApi.DeletedJobs(1, deletedListCount);
            var jobsListQueues = getMonitoringApi.Queues();
            var jobsListScheduledCount = getMonitoringApi.ScheduledCount();
            var jobsListScheduledJobs = getMonitoringApi.ScheduledJobs(1, 20);
            var jobsListServers = getMonitoringApi.Servers();
            var jobsListSucceededByDatesCount = getMonitoringApi.SucceededByDatesCount();
            var jobsListSucceededListCount = getMonitoringApi.SucceededListCount();
            var jobsListFailedByDatesCount = getMonitoringApi.FailedByDatesCount();
            var jobsListFailedCount = getMonitoringApi.FailedCount();
            var jobsListGetStatistics = getMonitoringApi.GetStatistics();
            var jobsListHourlyFailedJobs = getMonitoringApi.HourlyFailedJobs();
            var jobsListHourlySucceededJobs = getMonitoringApi.HourlySucceededJobs();
            var jobsListProcessingCount = getMonitoringApi.ProcessingCount();


            return Ok(new
            {
                //deletedList,
                jobsListQueues,
                jobsListScheduledCount,
                jobsListScheduledJobs,
                jobsListServers,
                jobsListSucceededByDatesCount,
                jobsListSucceededListCount,
                jobsListFailedByDatesCount,
                jobsListFailedCount,
                jobsListGetStatistics,
                jobsListHourlyFailedJobs,
                jobsListHourlySucceededJobs,
                jobsListProcessingCount
            }
            );

            //return Ok( new { jobFireForget, jobDelayed });

        }
    }
}
