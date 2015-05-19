using LivescoreRest.DataLayer.DAL.Interface;
using LivescoreRest.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivescoreRest.DataLayer.DAL
{
    public class GameRepository : BaseRepository<Game>, IGameRepository
    {
        public override System.Data.Entity.DbSet<Game> GetDbSet(LivescoreDbContext context)
        {
            return context.Game;
        }
    }
}
