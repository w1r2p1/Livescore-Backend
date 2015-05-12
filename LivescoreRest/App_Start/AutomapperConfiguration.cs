using AutoMapper;
using LivescoreRest.DataLayer.Entities;
using LivescoreRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LivescoreRest.App_Start
{
    public static class AutomapperConfiguration
    {
        public static void Configure()
        {
            TeamMappers();
        }

        private static void TeamMappers() 
        {
            Mapper.CreateMap<TeamViewModel, Team>();
        }
    }
}