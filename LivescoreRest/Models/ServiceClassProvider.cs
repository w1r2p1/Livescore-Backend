using LivescoreRest.ServiceLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LivescoreRest.Models
{
    public class ServiceClassProvider
    {
        private readonly RepositoryClassProvider _repositoryProvider;

        public ServiceClassProvider()
        {
            _repositoryProvider = new RepositoryClassProvider();
        }

        public TeamService GetTeamServiceObject()
        {
            return new TeamService(_repositoryProvider.GetTeamRepository());
        }

        public PlayerService GetPlayerService()
        {
            return new PlayerService(_repositoryProvider.GetPlayerRepository());
        }
    }
}