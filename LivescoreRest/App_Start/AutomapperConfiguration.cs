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
            PlayerMappers();
            GameMappers();
        }

        private static void TeamMappers() 
        {
            Mapper.CreateMap<TeamViewModel, Team>();
            Mapper.CreateMap<Team, TeamViewModel>();
        }

        private static void PlayerMappers()
        {
            Mapper.CreateMap<Player, PlayerViewModel>();
            Mapper.CreateMap<PlayerViewModel, Player>();
        }

        private static void GameMappers()
        {
            Mapper.CreateMap<Game, GameViewModel>();
            Mapper.CreateMap<GameViewModel, Game>();
        }

    }
}