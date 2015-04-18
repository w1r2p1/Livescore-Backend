using LivescoreRest.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivescoreRest.ServiceLayer.Service.Interface
{
    public interface IBaseService<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
    }
}
