﻿using LivescoreRest.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivescoreRest.DataLayer.DAL.Interface
{
    public interface ITeamRepository : IBaseRepository<Team>
    {
        IEnumerable<Team> GetAllTeamsForUser(string userID);
        IEnumerable<string> GetAllLevels();
        IEnumerable<Team> GetAllTeamsFromLevel(string level);
    }
}
