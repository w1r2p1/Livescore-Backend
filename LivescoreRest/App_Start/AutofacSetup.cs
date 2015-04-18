using Autofac;
using LivescoreRest.DataLayer.DAL;
using LivescoreRest.DataLayer.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LivescoreRest.App_Start
{
    public class AutofacSetup
    {
        public static IContainer Container { get; set; }

        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<TeamRepository>().As<ITeamRepository>().InstancePerLifetimeScope();

            Container = builder.Build();
            
        }
    }
}