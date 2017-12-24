using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetCoreMVC
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
          services.AddMvc(); 
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
   
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Employee}/{action=Index}/{id?}");
            });
        }
    }
}
