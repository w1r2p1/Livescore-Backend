using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivescoreRest.ServiceLayer.DTOs
{
    public class DTOFollowGame : DTOGame
    {
        public IEnumerable<DTOGameIncident> GameIncidents { get; set; }
    }
}
