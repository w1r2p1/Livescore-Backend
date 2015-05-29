using AutoMapper;
using LivescoreRest.DataLayer.DAL;
using LivescoreRest.DataLayer.Entities;
using LivescoreRest.Models;
using LivescoreRest.ServiceLayer.DTOs;
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
            _teamService = teamService;
        }

        private string GetUserID()
        {
            var user = (ClaimsIdentity)RequestContext.Principal.Identity;
            return user.Claims.First(x => x.Type == "UserID").Value;
        }
        
        public IHttpActionResult GetAllTeamsForUser()
        {
            string userID = GetUserID();
            var teams = _teamService.GetAllTeamsForUser(userID);
            return Ok(Mapper.Map<IEnumerable<TeamViewModel>>(teams));
        }

        [Route("api/teams/allteams")]
        [HttpGet]
        public IHttpActionResult GetAllTeams()
        {
            var teams = Mapper.Map<IEnumerable<TeamViewModel>>(_teamService.GetAll());
            var model = new AllTeamsViewModel()
            {
                MyTeams = teams.Where(x => x.UserID == GetUserID()),
                OtherTeams = teams.Where(x => x.UserID != GetUserID())
            };
            return Ok(model);
        }

        [Route("api/teams/levels")]
        [HttpGet]
        public IHttpActionResult Levels() 
        {

            return Ok(_teamService.GetAllLevels());
        }

        [Route("api/teams/levels/{level}")]
        [HttpGet]
        public IHttpActionResult Levels(string level)
        {
            return Ok(Mapper.Map<IEnumerable<TeamViewModel>>(_teamService.GetAllTeamsFromLevel(level)));
        }

        [HttpGet]
        public IHttpActionResult GetTeam(int id)
        {
            var team = _teamService.GetById(id);
            return Ok(Mapper.Map<TeamViewModel>(team));
        }

        [HttpPost]
        public IHttpActionResult AddTeam(TeamViewModel team)
        {
            string userID = GetUserID();
            team.UserID = userID;
            _teamService.Add(Mapper.Map<DTOTeam>(team));
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult DeleteTeam(int id)
        {
                _teamService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult EditTeam(TeamViewModel team)
        {
            _teamService.Edit(Mapper.Map<DTOTeam>(team));
            return Ok(team);
        }
    }
}
