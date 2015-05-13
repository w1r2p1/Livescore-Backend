using Autofac;
using Autofac.Integration.WebApi;
using LivescoreRest.DataLayer.DAL;
using LivescoreRest.DataLayer.DAL.Interface;
using LivescoreRest.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using LivescoreRest.ServiceLayer.Service;
using LivescoreRest.ServiceLayer.Service.Interface;

namespace LivescoreRest.App_Start
{
    public static class AutofacSetup
    {
        

        public static void RegisterDependencies(ref ContainerBuilder builder)
        {

            builder.RegisterType<TeamsController>();
            builder.RegisterType<PlayersController>();

            builder.RegisterType<TeamRepository>().As<ITeamRepository>();
            builder.RegisterType<TeamService>().As<ITeamService>();
            builder.RegisterType<PlayerRepository>().As<IPlayerRepository>();
            builder.RegisterType<PlayerService>().As<IPlayerService>();

        }
    }
}