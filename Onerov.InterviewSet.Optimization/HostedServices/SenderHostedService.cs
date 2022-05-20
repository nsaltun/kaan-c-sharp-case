using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Onerov.InterviewSet.Optimization.Enums;
using Onerov.InterviewSet.Optimization.Models;
using Onerov.InterviewSet.Optimization.Services.Abstraction;

namespace Onerov.InterviewSet.Optimization.HostedServices
{
    public class SenderHostedService : IHostedService
    {
        private readonly ISenderOrganizerService _senderOrganizerService;

        public SenderHostedService(ISenderOrganizerService senderOrganizerService)
        {
            this._senderOrganizerService = senderOrganizerService;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            NotificationInfo notificationInfo = TakeInputs();

            this._senderOrganizerService.Send(notificationInfo);

            return Task.CompletedTask;
        }

        private NotificationInfo TakeInputs()
        {
            string notificationChannel = Console.ReadLine();
            ValidateNotificationChannel(notificationChannel, out NotificationChannel notificationChannelType);
            var to = Console.ReadLine();
            string messageSubject = "sample message title";
            var messageContentSb = new StringBuilder();
            messageContentSb.Append("sample multi line");
            messageContentSb.Append("message content.");
            messageContentSb.Append("regards");

            return NotificationInfo.Create(notificationChannelType, to, messageSubject,
                messageContentSb.ToString());
        }

        private static void ValidateNotificationChannel(string notificationChannelInput,
            out NotificationChannel notificationChannel)
        {
            if (!Enum.TryParse(notificationChannelInput, true, out notificationChannel))
            {
                throw new InvalidEnumArgumentException(
                    $"{notificationChannelInput} Not a valid notification channel type");
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}