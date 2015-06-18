using LivescoreRest.DataLayer.DAL.Interface;
using LivescoreRest.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LivescoreRest.DataLayer.DAL
{
    public class GameIncidentRepository : BaseRepository<GameIncident>, IGameIncidentRepository
    {

        public override System.Data.Entity.DbSet<GameIncident> GetDbSet(LivescoreDbContext context)
        {
            return context.GameIncident;
        }

        public IEnumerable<GameIncident> GetGameIncidentsFromGame(int id) 
        {
            using (var dbContext = new LivescoreDbContext())
            {
                var incidents = dbContext.GameIncident
                    .Where(x => x.GameId == id).Include(x => x.Player).Include(x => x.Player.Team);
                    return incidents.ToList();
            }
        }
    }
}
