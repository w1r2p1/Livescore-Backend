using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivescoreRest.ServiceLayer.DTOs
{
    public class DTOTeam : BaseDTO
    {
        public int Id { get; set; }

        public string TeamName { get; set; }

        public string TeamLevel { get; set; }

        public string UserID { get; set; }
    }
}
