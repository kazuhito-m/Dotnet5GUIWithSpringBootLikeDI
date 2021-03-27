using System;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Dotnet5GUIWithSpringBootLikeDI.Domain.DI.Attr;
using Microsoft.Extensions.DependencyInjection;

namespace Dotnet5GUIWithSpringBootLikeDI.Domain.DI.Extension
{
    public static class AttributedClassScannerExtension
    {
        private static readonly string THIS_APP_TOP_NAMESPACE = Regex.Replace(typeof(AttributedClassScannerExtension).Namespace, "\\..*", "");

        public static void AddAttributedClassOf(this IServiceCollection services, Assembly scanTargetAssembly)
        {
            scanTargetAssembly.ExportedTypes
                .Where(type => type.IsClass && !type.IsSubclassOf(typeof(Attribute)))
                .Where(type => type.GetCustomAttributes<ComponentAttribute>().Any())
                .ToList()
                .ForEach(type => RegisterDI(type, services));
        }

        private static void RegisterDI(Type type, IServiceCollection services)
        {
            foreach (var ifc in type.GetInterfaces())
            {
                var ns = ifc.Namespace;
                if (ns == null || !ns.StartsWith(THIS_APP_TOP_NAMESPACE)) continue;
                services.AddSingleton(ifc, type);
                return;
            }
            services.AddSingleton(type);
        }
    }
}
