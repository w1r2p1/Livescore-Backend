using AutoMapper;
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
            IEnumerable<Player> players = _playerService.GetAllByTeamID(teamID);
            IEnumerable<PlayerViewModel> models = Mapper.Map<IEnumerable<PlayerViewModel>>(players);
            return Ok(models);
        }

        [HttpPost]
        public IHttpActionResult AddPlayer(PlayerViewModel player)
        {
            player =  Mapper.Map<PlayerViewModel>(_playerService.Add(Mapper.Map<Player>(player)));
            return Ok(player);
        }
    }
}
