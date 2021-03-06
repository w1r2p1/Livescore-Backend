﻿using LivescoreRest.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivescoreRest.DataLayer.DAL.Interface
{
    public interface IGameIncidentRepository : IBaseRepository<GameIncident>
    {
        IEnumerable<GameIncident> GetGameIncidentsFromGame(int id);
    }
}
