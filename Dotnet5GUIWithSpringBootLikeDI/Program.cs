using System;
using Microsoft.Extensions.Hosting;
using Dotnet5GUIWithSpringBootLikeDI.Domain.DI.Extension;

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
                    services.AddAttributedClassOf(typeof(Program).Assembly);
                });
    }
}
