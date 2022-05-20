using Onerov.InterviewSet.Optimization.Enums;
using Onerov.Interviewset.Optimization.Infra.Logger;
using Onerov.InterviewSet.Optimization.Services.Abstraction;

namespace Onerov.InterviewSet.Optimization.Services
{
    public class SmsSenderService : ISenderService
    {
        private readonly ILogger<SmsSenderService> logger;

        public SmsSenderService(ILogger<SmsSenderService> logger)
        {
            this.logger = logger;
        }

        public NotificationChannel NotificationChannel => NotificationChannel.Sms;

        public void Send(string to, string subject, string body)
        {
            this.logger.Log("sms sender worked");
        }
    }
}