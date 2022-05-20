using Onerov.InterviewSet.Optimization.Models;

namespace Onerov.InterviewSet.Optimization.Services.Abstraction
{
    public interface ISenderOrganizerService
    {
        void Send(NotificationInfo notificationInfo);
    }
}