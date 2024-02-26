using Turbo.Extensions;

namespace Turbo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            // Add all the services needed for the builder.
            builder.Services.AddAllServices(builder.Configuration);

            WebApplication app = builder.Build();

            app.AddAllConfigurations();
            app.Run();
        }
    }
}