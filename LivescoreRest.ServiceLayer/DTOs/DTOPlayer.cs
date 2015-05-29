using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivescoreRest.ServiceLayer.DTOs
{
    public class DTOPlayer : BaseDTO
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }

        
        public string Surename { get; set; }

        public int? ShirtNumber { get; set; }

        
        public int TeamID { get; set; }

        
        public DTOTeam Team { get; set; }
    }
}
