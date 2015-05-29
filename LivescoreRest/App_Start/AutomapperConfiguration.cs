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
            Mapper.CreateMap<TeamViewModel, DTOTeam>();
            Mapper.CreateMap<DTOTeam, TeamViewModel>();

            Mapper.CreateMap<Team, DTOTeam>();
            Mapper.CreateMap<DTOTeam, Team>();
        }

        private static void PlayerMappers()
        {
            Mapper.CreateMap<DTOPlayer, PlayerViewModel>();
            Mapper.CreateMap<PlayerViewModel, DTOPlayer>();

            Mapper.CreateMap<DTOPlayer, Player>();
            Mapper.CreateMap<Player, DTOPlayer>();
        }

        private static void GameMappers()
        {
           

            Mapper.CreateMap<DTOGame, Game>();
            Mapper.CreateMap<Game, DTOGame>()
                .ForMember(x => x.AwayTeamPlayers, y => y.Ignore())
                .ForMember(x => x.HomeTeamPlayers, y => y.Ignore());

            Mapper.CreateMap<DTOGame, GameViewModel>();
            Mapper.CreateMap<GameViewModel, DTOGame>()
                .ForMember(x => x.HomeTeam, y => y.Ignore())
                .ForMember(x => x.AwayTeam, y => y.Ignore());
        }

        private static void GameIncidentMappers()
        {
            Mapper.CreateMap<DTOGameIncident, GameIncident>()
                .ForMember(x => x.MatchIncidentType, y => y.MapFrom(z => (int)z.MatchIncidentType));
            Mapper.CreateMap<GameIncident, DTOGameIncident>();

            Mapper.CreateMap<DTOGameIncident, GameIncidentViewModel>();
            Mapper.CreateMap<GameIncidentViewModel, DTOGameIncident>();
        }

    }
}