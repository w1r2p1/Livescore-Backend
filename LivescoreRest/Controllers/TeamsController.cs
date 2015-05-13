using AutoMapper;
using LivescoreRest.DataLayer.DAL;
using LivescoreRest.DataLayer.Entities;
using LivescoreRest.Models;
using LivescoreRest.ServiceLayer.Service;
using LivescoreRest.ServiceLayer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace LivescoreRest.Controllers
{
    [Authorize]
    public class TeamsController : ApiController
    {
        private readonly ITeamService _teamService;

        public TeamsController(ITeamService teamService)
        {
            var serviceProvider = new ServiceClassProvider();
            _teamService = teamService;//serviceProvider.GetTeamServiceObject();
        }

        private string GetUserID()
        {
            var user = (ClaimsIdentity)RequestContext.Principal.Identity;
            return user.Claims.First(x => x.Type == "UserID").Value;
        }
        
        public IHttpActionResult GetAllTeams()
        {
            string userID = GetUserID();
            var teams = _teamService.GetAllTeamsForUser(userID);
            return Ok(teams);
        }

        [HttpGet]
        public IHttpActionResult GetTeam(int id)
        {
            var team = _teamService.GetById(id);
            return Ok(team);
        }

        [HttpPost]
        public IHttpActionResult AddTeam(TeamViewModel team)
        {
            string userID = GetUserID();
            team.UserID = userID;
            _teamService.Add(Mapper.Map<Team>(team));
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult DeleteTeam(int id)
        {
                _teamService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult EditTeam(Team team)
        {
            _teamService.Edit(team);
            return Ok(team);
        }
    }
}
