using Hangfire;
using System;
using System.Threading.Tasks;

namespace WebApiHangfire.Business.Schedule
{
    //Aviso: Esta abordagem de serviço "Interface" é usada para que o JOB aceite injeção de depenencia
    public interface IJobHandler
    {
        //void Start();
        Task CompanyRecoverJobAsync();
    }

    public class JobHandler : IJobHandler
    {
        public readonly IJobScheduleService _jobScheduleService;

        public JobHandler(IJobScheduleService jobScheduleService)
        {
            _jobScheduleService = jobScheduleService;
        }

        //public void Start()
        //{
        //    RecurringJob.AddOrUpdate<JobHandler>($"Company Recover", job => job.CompanyRecoverJobAsync(), Cron.Minutely);
        //}

        public async Task CompanyRecoverJobAsync()
        {
            //try
            //{
            //    await _jobScheduleService.GerenciarContasCompanhiasKYC();
            //}
            //catch { }
        }
    }
}
