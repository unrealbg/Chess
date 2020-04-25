using Autofac;
using Chess.Services;
using Chess.Services.Contracts;
using Chess.ViewModels;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Chess
{
    public static class Bootstrapper
    {
        public static IContainer Container { get; set; }

        public static void Init()
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => t.Name.EndsWith("ViewModel"))
                .AsSelf();

            Container = builder.Build();
        }
    }
}
