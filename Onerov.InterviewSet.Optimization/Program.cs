using Microsoft.Extensions.Hosting;

namespace Onerov.InterviewSet.Optimization
{
    public class Program {
        static void Main(string[] args) {
            CreateHostBuilder(args).Build().Run();
        }
        
        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    var serviceConfigurator = new ServiceConfigurator();
                    serviceConfigurator.ConfigureServices(services);
                });
        }
    }
}