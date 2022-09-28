using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface ICategoriaDALService
    {
        Task<Response> Insert(Categoria categoria);
        Task<Response> Update(Categoria categoria);
        Task<Response> Delete(Categoria categoria);
        Task<DataResponse<Categoria>> GetAll();
        Task<SingleResponse<Categoria>> GetById(int id);
    }
}
