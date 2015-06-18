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
                DateTime comparisonDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                var games = 
                    dbContext.Game.Where(x => x.UserId == userId && x.MatchDate > comparisonDate).Include(x => x.AwayTeam).Include(x => x.HomeTeam);
                return games.ToList();
            }
        }

        public override Game GetById(int id)
        {
            using (var dbContext = new LivescoreDbContext())
            {
                var game = dbContext.Game.Where(x => x.Id == id).Include(x => x.AwayTeam).Include(x => x.HomeTeam).FirstOrDefault();
                return game;
            }
        }

        public IEnumerable<Game> GetTodaysGames()
        {
            using (var dbContext = new LivescoreDbContext())
            {
                var games =
                    dbContext.Game.Where(x => x.MatchDate.Year == DateTime.Now.Year && x.MatchDate.Month == DateTime.Now.Month && x.MatchDate.Day == DateTime.Now.Day)
                    .Include(x => x.AwayTeam).Include(x => x.HomeTeam);
                return games.ToList();
            }
        }

        
    }
}
