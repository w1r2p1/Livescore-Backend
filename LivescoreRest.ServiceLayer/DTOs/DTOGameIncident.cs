using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Helpers;

namespace LivescoreRest.ServiceLayer.DTOs
{
    public class DTOGameIncident : BaseDTO
    {
        public int Id { get; set; }

        public string MatchTime { get; set; }

        public string Comment { get; set; }

        public int GameId { get; set; }

        public DTOGame Game { get; set; }

        public int? PlayerId { get; set; }

        public DTOPlayer Player { get; set; }

        public Common.Helpers.MatchIncidents.MatchIncidentsEnum MatchIncidentType { get; set; }

        public string Result { get; set; }
    }
}
