using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LivescoreRest.Models
{
    public class GameViewModel
    {
        public int Id { get; set; }

        [Required]
        public int HomeTeamId { get; set; }

        public TeamViewModel HomeTeam { get; set; }

        [Required]
        public int AwayTeamId{ get; set; }

        public TeamViewModel AwayTeam { get; set; }

        public string UserId { get; set; }

        [Required]
        public DateTime MatchDate { get; set; }

        public IEnumerable<PlayerViewModel> HomeTeamPlayers { get; set; }
        public IEnumerable<PlayerViewModel> AwayTeamPlayers { get; set; }
    }
}