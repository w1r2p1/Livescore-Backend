using LivescoreRest.DataLayer.DAL.Interface;
using LivescoreRest.DataLayer.Entities;
using LivescoreRest.ServiceLayer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivescoreRest.ServiceLayer.Service
{
    public class PlayerService : BaseService<Player>, IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
            : base(playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public IEnumerable<Player> GetAllByTeamID(int teamID) 
        {
            return _playerRepository.GetAllByTeamID(teamID);
        }
    }
}
