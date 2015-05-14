using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LivescoreRest.Models
{
    public class PlayerViewModel
    {

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string Surename { get; set; }

        public int? ShirtNumber { get; set; }

        public int TeamID { get; set; }

        public TeamViewModel Team { get; set; }
    }
}