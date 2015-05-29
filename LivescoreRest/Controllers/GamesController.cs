using AutoMapper;
using LivescoreRest.DataLayer.Entities;
using LivescoreRest.Models;
using LivescoreRest.ServiceLayer.DTOs;
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
            var game = _gameService.Add(MapGameViewModelToDTO(model));
            return Ok(Mapper.Map<GameViewModel>(game));
        }

        private DTOGame MapGameViewModelToDTO(GameViewModel model)
        {
            return new DTOGame()
            {
                AwayTeamId = model.AwayTeamId,
                HomeTeamId = model.HomeTeamId,
                Id = 0,
                MatchDate = model.MatchDate,
                UserId = model.UserId
                
            };
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
            _gameService.Edit(Mapper.Map<DTOGame>(model));
            
            return Ok();
        }
        
        [HttpGet]
        public IHttpActionResult GetGame(int gameId)
        {
            var gameModel = Mapper.Map<GameViewModel>(_gameService.GetGame(gameId));
            return Ok(gameModel);
        }

        [HttpDelete]
        public IHttpActionResult DeleteGame(int gameId)
        {
            _gameService.Delete(gameId);
            return Ok();
        }

        
        
    }
}
