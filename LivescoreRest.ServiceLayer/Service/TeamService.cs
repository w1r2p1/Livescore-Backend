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
    public class TeamService : BaseService<Team, DTOTeam>, ITeamService
    {
        private readonly ITeamRepository _teamRepository;

        public TeamService(ITeamRepository teamRepository) : base(teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public IEnumerable<DTOTeam> GetAllTeamsForUser(string userID)
        {
            return Mapper.Map<IEnumerable<DTOTeam>>(_teamRepository.GetAllTeamsForUser(userID));
        }

        public IEnumerable<string> GetAllLevels()
        {
            return _teamRepository.GetAllLevels();
        }

        public IEnumerable<DTOTeam> GetAllTeamsFromLevel(string level)
        {
            return Mapper.Map<IEnumerable<DTOTeam>>(_teamRepository.GetAllTeamsFromLevel(level));
        }
    }
}
