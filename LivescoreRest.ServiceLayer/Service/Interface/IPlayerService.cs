using LivescoreRest.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivescoreRest.ServiceLayer.Service.Interface
{
    public interface IPlayerService : IBaseService<Player>
    {
        IEnumerable<Player> GetAllByTeamID(int teamID);
    }
}
