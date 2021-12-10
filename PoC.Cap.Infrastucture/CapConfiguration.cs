using Microsoft.Extensions.DependencyInjection;

namespace PoC.Cap.Infrastucture
{
    public static class CapConfiguration
    {
        public static void AddCapConfiguration(this IServiceCollection services)
        {
            services.AddCap(capOptions =>
            {
                // If you are using ADO.NET, choose to add configuration you needed：
                capOptions.UseSqlServer(opt =>
                {
                    opt.ConnectionString = @"YOUR_CONNECTION_STRING";
                });
                // CAP support Kafka：
                capOptions.UseKafka(opt =>
                {

                    opt.Servers = "localhost:9092";
                });

                capOptions.UseDashboard();
            });
        }
    }
}