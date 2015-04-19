using LivescoreRest.DataLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LivescoreRest.Models
{
    public class RepositoryClassProvider
    {
        public TeamRepository GetTeamRepository()
        {
            return new TeamRepository();
        }
    }
}