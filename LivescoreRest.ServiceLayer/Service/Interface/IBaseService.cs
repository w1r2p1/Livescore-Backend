using LivescoreRest.DataLayer.Entities;
using LivescoreRest.ServiceLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivescoreRest.ServiceLayer.Service.Interface
{
    public interface IBaseService<T, DTO> : IService 
        where T : BaseEntity
        where DTO : BaseDTO
    {
        IEnumerable<DTO> GetAll();
        DTO GetById(int id);
        DTO Add(DTO dto);
        void Delete(int id);
        void Edit(DTO dto);
    }
}
