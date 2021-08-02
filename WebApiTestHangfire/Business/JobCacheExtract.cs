using System;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Logging;

namespace WebApiHangfire.Business
{
    public interface IJobCacheExtract
    {
        void LoadHelloWord();
    }

    public class JobCacheExtract :  IJobCacheExtract
    {
        private readonly ILogger<string> _logger;
        public JobCacheExtract(IHttpClientFactory httpClientFactory, ILogger<string> logger)
        {
            _logger = logger;
        }

        public void LoadHelloWord()
        {
            var ret = 1;
            switch (ret)
            {
                case 1:
                    break;
            }
        }

        public static void hello()
        {
            var exec = "hello word!";
            throw new Exception(exec);
        }
    }
}