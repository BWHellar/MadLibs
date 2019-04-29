using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace MadLib
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var host = new WebHostBuilder()
            //This ASP.net for default webserver
            .UseKestrel()
            // This getter will obtain the current directory we are on or trying to get.
            .UseContentRoot(Directory.GetCurrentDirectory())
            //
            .UseIISIntegration()
            // Startup function
            .UseStartup<Startup>()
            // Build allows us to build the host when we do the dotnet build.
            .Build();
            // This will be how we run the host when we do dotnet run.
          host.Run(); 
        }
    }
}