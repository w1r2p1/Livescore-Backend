using LivescoreRest.DataLayer.Entities;
using LivescoreRest.ServiceLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivescoreRest.ServiceLayer.Service.Interface
{
    public interface IGameIncidentService : IBaseService<GameIncident, DTOGameIncident>
    {
        IEnumerable<DTOGameIncident> GetGameIncidentsFromGame(int id);
    }
}
