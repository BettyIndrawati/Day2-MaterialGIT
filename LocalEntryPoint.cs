using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.SystemConsole.Themes;
using System.IO;

namespace IntracoAPI
{
    /// <summary>
    /// The Main function can be used to run the ASP.NET Core application locally using the Kestrel webserver.
    /// </summary>
    public class LocalEntryPoint
    {
        public static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables()
            .Build();

<<<<<<< HEAD
            Log.Logger = new iLoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();
=======
<<<<<<< HEAD
            //Log.Logger = new LoggerConfiguration()
            //    .ReadFrom.Configuration(configuration)
            //    .CreateLogger();

            AttributeTargets logger get
=======
            //Log.Logger = new iLoggerConfiguration()
            //    .ReadFrom.Configuration(configuration)
            //    .CreateLogger();
>>>>>>> 8c45838cc0e2c1d7e826cb69ad7f0333a60e92f4
            Attribute//Targets
                //logger get
>>>>>>> f341635f97dcf8a8e254c8a39d37e17a9d001112
            try
            {
                Log.Information("******Method: GetDetailsStarted*******");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "The application failed to start correctly");
            }
            finally
            {
                Log.Information("Existing File");
                Log.CloseAndFlush();
            }

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging(a => { 
                    a.ClearProviders();
                    a.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
                })
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseSerilog();

                });
    }
}
