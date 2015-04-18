using LivescoreRest.DataLayer.Entities;
using LivescoreRest.ServiceLayer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivescoreRest.DataLayer.DAL.Interface;

namespace LivescoreRest.ServiceLayer.Service
{
    public abstract class BaseService<T> : IBaseService<T> 
        where T : BaseEntity
    {

        private readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;

        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public T Add(T entity)
        {
            return _repository.Add(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public void Edit(T entity)
        {
            _repository.Edit(entity);
        }
    }
}
