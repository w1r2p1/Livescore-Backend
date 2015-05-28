using LivescoreRest.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivescoreRest.ServiceLayer.DTOs
{
    public class DTOGame
    {
        public int Id { get; set; }
        public Team HomeTeam { get; set; }
        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }
        public string UserId { get; set; }
        public DateTime MatchDate { get; set; }

        public IEnumerable<Player> HomeTeamPlayers { get; set; }
        public IEnumerable<Player> AwayTeamPlayers { get; set; }
    }
}
