using Onerov.InterviewSet.Optimization.Enums;

namespace Onerov.InterviewSet.Optimization.Services.Abstraction
{
    public interface ISenderService
    {
        NotificationChannel NotificationChannel { get; }
        
        void Send(string to, string subject, string body);
    }
}