using System;
using System.Threading.Tasks;

namespace WebApiHangfire.Business.Schedule
{
    //Aviso: Esta abordagem de serviço "Interface" é usada para que o JOB aceite injeção de depenencia
    public interface IJobHandlerCacheExtract
    {
        void LoadHelloWord();
    }

    public class JobHandlerCacheExtract : IJobHandlerCacheExtract
    {
        public readonly IJobCacheExtract _jobCacheExtract;

        public JobHandlerCacheExtract(IJobCacheExtract jobCacheExtract)
        {
            _jobCacheExtract = jobCacheExtract;
        }

        public void LoadHelloWord()
        {
            _jobCacheExtract.LoadHelloWord();
        }
    }
}
