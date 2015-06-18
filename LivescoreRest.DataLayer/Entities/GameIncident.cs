using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Helpers;

namespace LivescoreRest.DataLayer.Entities
{
    public class GameIncident : BaseEntity
    {
        public int Id { get; set; }

        [Required]
        public string MatchTime { get; set; }

        public string Comment { get; set; }

        [Required]
        public int GameId { get; set; }

        [ForeignKey("GameId")]
        public Game Game { get; set; }

        public int? PlayerId { get; set; }

        [ForeignKey("PlayerId")]
        public Player Player { get; set; }

        public int MatchIncidentType { get; set; }

        [Required]
        public string Result { get; set; }
    }
}
