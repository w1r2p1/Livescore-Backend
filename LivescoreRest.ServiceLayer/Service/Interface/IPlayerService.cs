using LivescoreRest.DataLayer.Entities;
using LivescoreRest.ServiceLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivescoreRest.ServiceLayer.Service.Interface
{
    public interface IPlayerService : IBaseService<Player, DTOPlayer>
    {
        IEnumerable<DTOPlayer> GetAllByTeamID(int teamID);
    }
}
