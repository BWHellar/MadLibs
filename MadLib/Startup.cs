using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MadLib
{
  public class Startup
  {
    public Startup(IHostingEnvironment env)
    {
      // This is required for configuring the basics of ASP.NET.
      var builder = new ConfigurationBuilder()
        .SetBasePath(env.ContentRootPath)
        .AddEnvironmentVariables();
      Configuration = builder.Build();
    }
    // Get the root configuration that we will need for later.
    public IConfigurationRoot Configuration { get; }
    // This is a required method to setup an application's server.  We configure other things within this.
    public void ConfigureServices (IServiceCollection services)
    {
      // Adds Mvc service to the project.
      services.AddMvc();
    }
    //This tells our app how to handle requests to the server.
    public void Configure(IApplicationBuilder app)
    {
      // We call on the Mvc we stated earlier in the ConfigureService. This is how we tell the app we are using the MVC framework to respond to http requests.
      app.UseMvc(routes =>
      {
        // Tells the project to use the Index action of the Home controller as the default route (homepage).
        routes.MapRoute(
          // What we name it.
          name: "default",
          // Controller is set to home.
          template: "{controller=Home}/{action=Index}/{id?}");
      });
      // When the page is loading up the resources this is what will display.
      app.Run(async (context) =>
      {
        await context.Response.WriteAsync("!Please! !Wait!");
      });
    }
  }
}