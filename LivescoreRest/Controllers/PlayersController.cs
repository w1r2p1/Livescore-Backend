using LivescoreRest.DataLayer.Entities;
using LivescoreRest.Models;
using LivescoreRest.ServiceLayer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LivescoreRest.Controllers
{
    [Authorize]
    public class PlayersController : ApiController
    {
        private readonly IPlayerService _playerService;

        public PlayersController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet]
        public IHttpActionResult GetPlayers(int teamID)
        {
            var players = _playerService.GetAll().Where(x => x.TeamID == teamID);
            return Ok(players);
        }

        [HttpPost]
        public IHttpActionResult AddPlayer(Player player)
        {
            player = _playerService.Add(player);
            return Ok(player);
        }
    }
}
