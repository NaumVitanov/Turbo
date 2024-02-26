namespace Turbo.Extensions
{
    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder ConfigureMiddlewares(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
                app.UseMigrationsEndPoint();
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            return app;
        }

        public static IApplicationBuilder AddAllConfigurations(this WebApplication app)
        {
            app
               .UseHttpsRedirection()
               .UseStaticFiles()
               .UseRouting()
               .UseAuthentication()
               .UseAuthorization();

            app.MapDefaultControllerRoute();
            app.MapRazorPages();

            return app;
        }
    }
}
