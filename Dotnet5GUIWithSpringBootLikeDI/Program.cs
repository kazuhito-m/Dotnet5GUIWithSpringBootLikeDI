using System;
using Microsoft.Extensions.Hosting;

namespace Dotnet5GUIWithSpringBootLikeDI
{
    static class Program
    {
        static void Main() => CreateHostBuilder().Build().Run();

        public static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder(Array.Empty<string>())
                .UseWindowsFormsLifetime<Form1>()
                .ConfigureServices((hostContext, services) =>
                {
                });
    }
}
