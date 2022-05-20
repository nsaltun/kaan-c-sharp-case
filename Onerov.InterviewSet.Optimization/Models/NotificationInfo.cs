using Onerov.InterviewSet.Optimization.Enums;

namespace Onerov.InterviewSet.Optimization.Models
{
    public class NotificationInfo
    {
        public NotificationChannel NotificationChannel { get; set; }
        
        public string MessageContent { get; private set; }

        public string MessageSubject { get; private set; }

        public string To { get; private set; }
        
        public static NotificationInfo Create(NotificationChannel notificationChannel, string messageContent, string messageSubject, string to)
        {
            return new NotificationInfo
            {
                NotificationChannel = notificationChannel,
                MessageSubject = messageSubject,
                MessageContent = messageContent,
                To = to
            };
        }
    }
}