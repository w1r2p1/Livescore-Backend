using LivescoreRest.DataLayer.Entities;
using LivescoreRest.ServiceLayer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivescoreRest.DataLayer.DAL.Interface;
using AutoMapper;
using LivescoreRest.ServiceLayer.DTOs;

namespace LivescoreRest.ServiceLayer.Service
{
    public abstract class BaseService<T, DTO> : IBaseService<T, DTO> 
        where T : BaseEntity
        where DTO : BaseDTO
    {

        private readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;

        }

        public IEnumerable<DTO> GetAll()
        {
            return Mapper.Map<IEnumerable<DTO>>(_repository.GetAll());
        }

        public DTO GetById(int id)
        {
            return Mapper.Map<DTO>(_repository.GetById(id));
        }

        public DTO Add(DTO dto)
        {
            T entity = Mapper.Map<T>(dto);
            return Mapper.Map<DTO>(_repository.Add(entity));
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public void Edit(DTO dto)
        {
            T entity = Mapper.Map<T>(dto);
            _repository.Edit(entity);
        }
    }
}
