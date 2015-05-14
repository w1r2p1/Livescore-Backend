using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LivescoreRest.Models
{
    public class AllTeamsViewModel
    {
        public IEnumerable<TeamViewModel> MyTeams { get; set; }
        public IEnumerable<TeamViewModel> OtherTeams { get; set; }
    }
}