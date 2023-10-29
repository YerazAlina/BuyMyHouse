using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace MailFunction
{
    public class SendEmailTimer
    {
        private readonly ILogger _logger;

        public SendEmailTimer(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<SendEmailTimer>();
        }

        [Function("Function1")]
        public void Run([TimerTrigger("0 0/10 * * *")] TimerInfo myTimer)
        {
            _logger.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            
            if (myTimer.ScheduleStatus is not null)
            {
                _logger.LogInformation($"Next timer schedule at: {myTimer.ScheduleStatus.Next}");
            }
        }
    }
}
