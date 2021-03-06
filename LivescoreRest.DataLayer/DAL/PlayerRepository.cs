﻿using LivescoreRest.DataLayer.DAL.Interface;
using LivescoreRest.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivescoreRest.DataLayer.DAL
{
    public class PlayerRepository : BaseRepository<Player>, IPlayerRepository
    {

        public override System.Data.Entity.DbSet<Player> GetDbSet(LivescoreDbContext context)
        {
            return context.Player;
        }

        public IEnumerable<Player> GetAllByTeamID(int teamID)
        {
            using (var dbContext = new LivescoreDbContext())
            {
                return dbContext.Player.Where(x => x.TeamID == teamID).ToList();
            }
        }
    }
}
