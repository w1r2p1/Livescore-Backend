using LivescoreRest.DataLayer.DAL.Interface;
using LivescoreRest.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivescoreRest.DataLayer.DAL
{
    public class TeamRepository : BaseRepository<Team>, ITeamRepository
    {
        public override System.Data.Entity.DbSet<Team> GetDbSet(LivescoreDbContext context)
        {
            return context.Team;
        }

        public IEnumerable<Team> GetAllTeamsForUser(string userID)
        {
            using (var dbContext = new LivescoreDbContext())
            {
                return dbContext.Team.Where(x => x.UserID == userID).ToList();
            }
        }
    }
}
