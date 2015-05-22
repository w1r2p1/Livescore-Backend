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
    public class GameRepository : BaseRepository<Game>, IGameRepository
    {
        public override System.Data.Entity.DbSet<Game> GetDbSet(LivescoreDbContext context)
        {
            return context.Game;
        }

        public IEnumerable<Game> GetMyComingGames(string userId)
        {
            using (var dbContext = new LivescoreDbContext())
            {
                DateTime comparisonDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 1);
                var games = 
                    dbContext.Game.Where(x => x.UserId == userId && x.MatchDate > comparisonDate).Include(x => x.AwayTeam).Include(x => x.HomeTeam);
                return games.ToList();
            }
        }
    }
}
