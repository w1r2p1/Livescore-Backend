using LivescoreRest.DataLayer.DAL;
using LivescoreRest.DataLayer.Entities;
using LivescoreRest.ServiceLayer.Service;
using LivescoreRest.ServiceLayer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LivescoreRest.Controllers
{

    public class TeamsController : ApiController
    {
        private readonly ITeamService _teamService;

        public TeamsController()
        {
            _teamService = new TeamService(new TeamRepository());
        }

        public IHttpActionResult GetAllTeams()
        {
            var teams = _teamService.GetAll();
            return Ok(teams);
        }

        [HttpGet]
        public IHttpActionResult GetTeam(int id)
        {
            var team = _teamService.GetById(id);
            return Ok(team);
        }

        [HttpPost]
        public IHttpActionResult AddTeam(Team team)
        {
            _teamService.Add(team);
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult DeleteTeam(int id)
        {
                _teamService.Delete(id);
            return Ok();
        }
    }
}
