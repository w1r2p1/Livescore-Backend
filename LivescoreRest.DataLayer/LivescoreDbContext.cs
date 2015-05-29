using LivescoreRest.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivescoreRest.DataLayer
{
    public class LivescoreDbContext : DbContext
    {
        public LivescoreDbContext()
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Team> Team { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Game> Game { get; set; }
        public DbSet<GameIncident> GameIncident { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Game>()
            //    .ha
        }
    }
}
