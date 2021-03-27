﻿using System;
using System.Linq;
using System.Reflection;
using Dotnet5GUIWithSpringBootLikeDI.Domain.DI.Attr;
using Microsoft.Extensions.DependencyInjection;

namespace Dotnet5GUIWithSpringBootLikeDI.Domain.DI.Extension
{
    public static class AttributedClassScannerExtension
    {
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
            if (type.GetInterfaces().Any()) services.AddSingleton(type.GetInterfaces()[0], type);
            else services.AddSingleton(type);
        }
    }
}
