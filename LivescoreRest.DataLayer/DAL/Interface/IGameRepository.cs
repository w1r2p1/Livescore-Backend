using LivescoreRest.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivescoreRest.DataLayer.DAL.Interface
{
    public interface IGameRepository : IBaseRepository<Game>
    {
        IEnumerable<Game> GetMyComingGames(string userId);
        //Game GetGame(int id);
        IEnumerable<Game> GetTodaysGames();
        
    }
}
