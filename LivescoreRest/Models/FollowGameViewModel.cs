using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LivescoreRest.Models
{
    public class FollowGameViewModel : GameViewModel
    {
        public IEnumerable<GameIncidentViewModel> GameIncidents { get; set; }
    }
}