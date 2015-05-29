using LivescoreRest.DataLayer.Entities;
using LivescoreRest.ServiceLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivescoreRest.ServiceLayer.Service.Interface
{
    public interface ITeamService: IBaseService<Team, DTOTeam>
    {
        IEnumerable<DTOTeam> GetAllTeamsForUser(string userID);
        IEnumerable<string> GetAllLevels();
        IEnumerable<DTOTeam> GetAllTeamsFromLevel(string level);
    }
}
