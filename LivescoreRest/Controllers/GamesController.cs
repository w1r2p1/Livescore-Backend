using AutoMapper;
using LivescoreRest.DataLayer.Entities;
using LivescoreRest.Models;
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
    public class GamesController : ApiController
    {
        private readonly IGameService _gameService;

        public GamesController(IGameService gameService)
        {
            _gameService = gameService;
        }

        private string GetUserID()
        {
            var user = (ClaimsIdentity)RequestContext.Principal.Identity;
            return user.Claims.First(x => x.Type == "UserID").Value;
        }

        [HttpPost]
        public IHttpActionResult Games(GameViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            model.UserId = GetUserID();
            var game = _gameService.Add(Mapper.Map<Game>(model));
            return Ok(Mapper.Map<GameViewModel>(game));
        }

        [HttpGet]
        [Route("api/games/mycoming")]
        public IHttpActionResult MyComingGames()
        {
            var comingGames = Mapper.Map<IEnumerable<GameViewModel>>(_gameService.GetMyComingGames(GetUserID()));
            return Ok(comingGames);
        }

        [HttpPut]
        public IHttpActionResult EditGames(GameViewModel model)
        {
            model.UserId = GetUserID();
            _gameService.Edit(Mapper.Map<Game>(model));
            
            return Ok();
        }
    }
}
