using LivescoreRest.ServiceLayer.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LivescoreRest.Models
{
    public class GameIncidentViewModel
    {
        public int Id { get; set; }

        [Required]
        public string MatchTime { get; set; }

        public string Comment { get; set; }

        [Required]
        public int GameId { get; set; }

        public DTOGame Game { get; set; }

        public int? PlayerId { get; set; }

        public DTOPlayer Player { get; set; }

        [Required]
        public Common.Helpers.MatchIncidents.MatchIncidentsEnum MatchIncidentType { get; set; }
    }
}