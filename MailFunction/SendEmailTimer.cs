using System;
using BuyMyHouse.Models;
using BuyMyHouse.Service.Interfaces;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace MailFunction
{
    public class SendEmailTimer
    {
        private readonly IUserService _userService;
        private readonly IMortgageService _mortgageService;

        public SendEmailTimer(IUserService userService, IMortgageService mortgageService)
        {
            _userService = userService;
            _mortgageService = mortgageService;
        }

        [Function("SendEmail")]
        public async Task Run([TimerTrigger("0 0/10 * * *")] TimerInfo myTimer)
        {
            List<Mortgage> mortgages = _mortgageService.GetMortgages().Result;
            if (myTimer.ScheduleStatus is not null)
            {
                _logger.LogInformation($"Next timer schedule at: {myTimer.ScheduleStatus.Next}");
            }
        }
    }
}
