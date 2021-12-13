using Microsoft.Extensions.DependencyInjection;

namespace PoC.Cap.Infrastucture
{
    public static class CapConfiguration
    {
        public static void AddCapConfiguration(this IServiceCollection services)
        {
            services.AddCap(capOptions =>
            {
                capOptions.FailedRetryCount = 5;
                capOptions.FailedRetryInterval = 120;
                // If you are using ADO.NET, choose to add configuration you needed：
                capOptions.UseSqlServer(opt =>
                {
                    //Don't hardcoded your sensitive information, this is only for PoC
                    opt.ConnectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=PoC.Cap.Db;Integrated Security=True";
                });
                // CAP support Kafka：
                capOptions.UseKafka(opt =>
                {
                    //Don't hardcoded your sensitive information, this is only for PoC
                    opt.Servers = "localhost:9092";
                });

                capOptions.UseDashboard();
            });
        }
    }
}