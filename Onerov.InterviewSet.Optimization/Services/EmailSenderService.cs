using System;
using Onerov.InterviewSet.Optimization.Enums;
using Onerov.Interviewset.Optimization.Infra.Logger;
using Onerov.InterviewSet.Optimization.Services.Abstraction;

namespace Onerov.InterviewSet.Optimization.Services
{
    public class EmailSenderService : ISenderService
    {
        private readonly ILogger<EmailSenderService> logger;

        public EmailSenderService(ILogger<EmailSenderService> logger)
        {
            this.logger = logger;
        }

        public NotificationChannel NotificationChannel => NotificationChannel.Email;

        public void Send(string to, string subject, string body)
        {
            this.logger.Log("email sender worked");
        }
    }
}