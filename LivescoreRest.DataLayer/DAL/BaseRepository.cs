using LivescoreRest.DataLayer.DAL.Interface;
using LivescoreRest.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivescoreRest.DataLayer.DAL
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {

        public abstract DbSet<T> GetDbSet(LivescoreDbContext context);

        public virtual IEnumerable<T> GetAll()
        {
            using (var dbContext = new LivescoreDbContext())
            {
                var dbSet = GetDbSet(dbContext);
                return dbSet.ToList();
            }
        }

        public virtual T GetById(int id)
        {
            using (var dbContext = new LivescoreDbContext())
            {
                var dbSet = GetDbSet(dbContext);
                return dbSet.Find(id);
            }
        }

        public virtual T Add(T entity)
        {
            using (var dbContext = new LivescoreDbContext())
            {
                dbContext.Entry(entity).State = EntityState.Added;
                dbContext.SaveChanges();
                return entity;
            }
        }

        public virtual void Delete(int id)
        {
            using (var dbContext = new LivescoreDbContext())
            {
                var dbSet = GetDbSet(dbContext);
                var entity = dbSet.Find(id);
                dbContext.Entry(entity).State = EntityState.Deleted;
                dbContext.SaveChanges();
            }
        }

        public virtual void Edit(T entity)
        {
            using (var dbContext = new LivescoreDbContext())
            {
                var dbSet = GetDbSet(dbContext);
                dbContext.Entry(entity).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }
    }
}
