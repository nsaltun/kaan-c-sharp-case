using System;
using System.Collections.Generic;
using System.Linq;
using Onerov.Interviewset.Optimization.Infra.Logger;
using Onerov.InterviewSet.Optimization.Models;
using Onerov.InterviewSet.Optimization.Services.Abstraction;

namespace Onerov.InterviewSet.Optimization.Services
{
    public class SenderOrganizerService : ISenderOrganizerService
    {
        private readonly ILogger<SenderOrganizerService> logger;
        private readonly IEnumerable<ISenderService> senderServices;

        public SenderOrganizerService(ILogger<SenderOrganizerService> logger, IEnumerable<ISenderService> senderServices)
        {
            this.logger = logger;
            this.senderServices = senderServices;
        }

        public void Send(NotificationInfo notificationInfo)
        {
            var senderService = this.senderServices.FirstOrDefault(x => x.NotificationChannel == notificationInfo.NotificationChannel);
            if (senderService == null)
            {
                this.logger.Log($"{notificationInfo.NotificationChannel} service not implemented");
                throw new NotImplementedException($"{notificationInfo.NotificationChannel} service not implemented");
            }

            senderService.Send(notificationInfo.To, notificationInfo.MessageSubject, notificationInfo.MessageContent);
        }
    }
}