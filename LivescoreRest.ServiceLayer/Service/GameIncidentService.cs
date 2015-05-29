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
    public class GameIncidentService : BaseService<GameIncident, DTOGameIncident>, IGameIncidentService
    {
        private readonly IGameIncidentRepository _gameIncidentRepository;

        public GameIncidentService(IGameIncidentRepository gameIncidentRepository)
            : base(gameIncidentRepository)
        {
            _gameIncidentRepository = gameIncidentRepository;
        }
    }
}
