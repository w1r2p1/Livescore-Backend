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
    public class TeamService : BaseService<Team>, ITeamService
    {
        private readonly ITeamRepository _teamRepository;

        public TeamService(ITeamRepository teamRepository) : base(teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public IEnumerable<Team> GetAllTeamsForUser(string userID)
        {
            return _teamRepository.GetAllTeamsForUser(userID);
        }
    }
}
