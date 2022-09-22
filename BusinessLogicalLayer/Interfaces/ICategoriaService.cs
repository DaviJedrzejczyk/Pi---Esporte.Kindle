using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Interfaces
{
    public interface ICategoriaService
    {

        Task<Response> Insert(Categoria item);
        Task<Response> Update(Categoria item);
        Task<Response> Delete(Categoria item);
        Task<DataResponse<Categoria>> GetAll();
        Task<SingleResponse<Categoria>> GetById(int id);
    }
}
