using AutoMapper;
using LivescoreRest.DataLayer.DAL.Interface;
using LivescoreRest.DataLayer.Entities;
using LivescoreRest.ServiceLayer.DTOs;
using LivescoreRest.ServiceLayer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace LivescoreRest.ServiceLayer.Service
{
    public  class GameService : BaseService<Game, DTOGame>, IGameService
    {

        private readonly IGameRepository _gameRepository;
        private readonly IPlayerRepository _playerRepository;
        private readonly IGameIncidentRepository _gameIncidentRepository;

        public GameService(
            IGameRepository gameRepository, 
            IPlayerRepository playerRepository,
            IGameIncidentRepository gameIncidentRepository) 
            : base(gameRepository)
        {
            _gameRepository = gameRepository;
            _playerRepository = playerRepository;
            _gameIncidentRepository = gameIncidentRepository;
        }

        public IEnumerable<DTOGame> GetMyComingGames(string userId)
        {
            return Mapper.Map<IEnumerable<DTOGame>>(_gameRepository.GetMyComingGames(userId));
        }

        public DTOGame GetGame(int id)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                var game = Mapper.Map<DTOGame>(_gameRepository.GetById(id));
                game.HomeTeamPlayers = Mapper.Map<IEnumerable<DTOPlayer>>(_playerRepository.GetAllByTeamID(game.HomeTeam.Id));
                game.AwayTeamPlayers = Mapper.Map<IEnumerable<DTOPlayer>>(_playerRepository.GetAllByTeamID(game.AwayTeam.Id));
                return game;
            }
        }

        public IEnumerable<DTOGame> GetTodaysGames()
        {
            return Mapper.Map<IEnumerable<DTOGame>>(_gameRepository.GetTodaysGames());
        }

        public DTOFollowGame GetGameToFollow(int gameId)
        {
            using (var scope = new TransactionScope())
            {
                DTOFollowGame game = Mapper.Map<DTOFollowGame>(_gameRepository.GetById(gameId));
                game.GameIncidents = Mapper.Map<IEnumerable<DTOGameIncident>>(_gameIncidentRepository.GetGameIncidentsFromGame(gameId));
                return game;
            }
        }
    }
}
