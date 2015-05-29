using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helpers
{
    public class MatchIncidents
    {
        public enum MatchIncidentsEnum
        {
            Comment = 1,
            Goal = 2,
            YellowCarcd = 3,
            TwoMinutesSuspension = 4,
            RedCard = 5,
            Timeout = 6
        };

        public int GetMatchIncidentId(MatchIncidentsEnum incident)
        {
            return (int)incident;
        }
    }
}
