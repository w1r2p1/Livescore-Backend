using AutoMapper;
using LivescoreRest.DataLayer.Entities;
using LivescoreRest.Models;
using LivescoreRest.ServiceLayer.DTOs;
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
            GameIncidentMappers();
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
            Mapper.CreateMap<Game, GameViewModel>()
                .ForMember(x => x.AwayTeamPlayers, y => y.Ignore())
                .ForMember(x => x.HomeTeamPlayers, y => y.Ignore());

            Mapper.CreateMap<GameViewModel, Game>();

            Mapper.CreateMap<DTOGame, Game>();
            Mapper.CreateMap<Game, DTOGame>()
                .ForMember(x => x.AwayTeamPlayers, y => y.Ignore())
                .ForMember(x => x.HomeTeamPlayers, y => y.Ignore());

            Mapper.CreateMap<DTOGame, GameViewModel>();
            Mapper.CreateMap<GameViewModel, DTOGame>();
        }

        private static void GameIncidentMappers()
        {

        }

    }
}