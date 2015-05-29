using LivescoreRest.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivescoreRest.ServiceLayer.DTOs
{
    public class DTOGame : BaseDTO
    {
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public DTOTeam HomeTeam { get; set; }
        public int AwayTeamId { get; set; }
        public DTOTeam AwayTeam { get; set; }
        public string UserId { get; set; }
        public DateTime MatchDate { get; set; }

        public IEnumerable<DTOPlayer> HomeTeamPlayers { get; set; }
        public IEnumerable<DTOPlayer> AwayTeamPlayers { get; set; }
    }
}
