using Microsoft.Extensions.DependencyInjection;
using Onerov.InterviewSet.Optimization.HostedServices;
using Onerov.Interviewset.Optimization.Infra.Logger;
using Onerov.InterviewSet.Optimization.Services;
using Onerov.InterviewSet.Optimization.Services.Abstraction;

namespace Onerov.InterviewSet.Optimization
{
    public class ServiceConfigurator
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ISenderOrganizerService, SenderOrganizerService>();
            services.AddSingleton<ISenderService, EmailSenderService>();
            services.AddSingleton<ISenderService, SmsSenderService>();
            services.AddSingleton<ISenderService, PushNotificationSenderService>();
            services.AddSingleton(typeof(ILogger<>), typeof(Logger<>));
            services.AddHostedService<SenderHostedService>();
        }
    }
}