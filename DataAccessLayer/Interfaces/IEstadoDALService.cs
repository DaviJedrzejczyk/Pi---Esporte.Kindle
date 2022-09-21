using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IEstadoDALService
    {
        Task<Response> Insert(Estado estado);
        Task<Response> Update(Estado estado);
        Task<Response> Delete(int id);
        Task<DataResponse<Estado>> GetAll();
        Task<SingleResponse<Estado>> GetById(int id);
    }
}
