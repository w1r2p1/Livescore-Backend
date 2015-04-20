using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivescoreRest.DataLayer.Entities
{
    public class Player : BaseEntity
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string Surename { get; set; }

        public int? ShirtNumber { get; set; }

        [Required]
        public int TeamID { get; set; }

        [ForeignKey("TeamID")]
        public Team Team { get; set; }
    }
}
