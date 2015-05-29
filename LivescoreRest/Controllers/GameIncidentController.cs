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
    public class GameIncidentController : ApiController
    {
        private readonly IGameIncidentService _gameIncidentService;

        public GameIncidentController(IGameIncidentService gameIncidentService)
        {
            _gameIncidentService = gameIncidentService;
        }


        [HttpPost]
        public IHttpActionResult NewGameIncident(GameIncidentViewModel model)
        {
            var incident = Mapper.Map<DTOGameIncident>(model);
            _gameIncidentService.Add(incident);
            return Ok();
        }
    }
}
