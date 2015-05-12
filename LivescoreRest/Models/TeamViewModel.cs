using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LivescoreRest.Models
{
    public class TeamViewModel
    {
        public int Id { get; set; }
        
        [Required]
        public string TeamLevel { get; set; }
        
        [Required]
        public string TeamName { get; set; }

        public string UserID { get; set; }
    }
}