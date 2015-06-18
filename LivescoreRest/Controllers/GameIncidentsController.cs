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
using System.Web.Http;

namespace LivescoreRest.Controllers
{
    [AllowAnonymous]
    public class GameIncidentsController : ApiController
    {
        private readonly IGameIncidentService _gameIncidentService;

        public GameIncidentsController(IGameIncidentService gameIncidentService)
        {
            _gameIncidentService = gameIncidentService;
        }


        [HttpPost]
        [Authorize]
        public IHttpActionResult NewGameIncident(GameIncidentViewModel model)
        {
            var incident = Mapper.Map<DTOGameIncident>(model);
            _gameIncidentService.Add(incident);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult GetGameIncidents(int gameId)
        {
            var incidentsFromGame = _gameIncidentService.GetGameIncidentsFromGame(gameId);
            return Ok(Mapper.Map<IEnumerable<GameIncidentViewModel>>(incidentsFromGame));
        }
    }
}
