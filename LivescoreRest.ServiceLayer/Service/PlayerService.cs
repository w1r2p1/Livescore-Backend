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

namespace LivescoreRest.ServiceLayer.Service
{
    public class PlayerService : BaseService<Player, DTOPlayer>, IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
            : base(playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public IEnumerable<DTOPlayer> GetAllByTeamID(int teamID) 
        {
            return Mapper.Map<IEnumerable<DTOPlayer>>(_playerRepository.GetAllByTeamID(teamID));
        }
    }
}
