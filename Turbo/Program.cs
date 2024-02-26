using Turbo.Extensions;

namespace Turbo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAllServices(builder.Configuration);

            WebApplication app = builder.Build();

            app.AddAllConfigurations();
            app.Run();
        }
    }
}