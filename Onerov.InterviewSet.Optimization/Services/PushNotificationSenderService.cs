using System;
using Onerov.InterviewSet.Optimization.Enums;
using Onerov.Interviewset.Optimization.Infra.Logger;
using Onerov.InterviewSet.Optimization.Services.Abstraction;

namespace Onerov.InterviewSet.Optimization.Services
{
    public class PushNotificationSenderService : ISenderService
    {
        private readonly ILogger<PushNotificationSenderService> logger;

        public PushNotificationSenderService(ILogger<PushNotificationSenderService> logger)
        {
            this.logger = logger;
        }

        public NotificationChannel NotificationChannel => NotificationChannel.Push;

        public void Send(string to, string subject, string body)
        {
            this.logger.Log("push notification sender worked");
        }
    }
}