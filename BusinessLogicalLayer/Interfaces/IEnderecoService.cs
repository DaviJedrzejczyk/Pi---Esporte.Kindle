using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Interfaces
{
    public interface IEnderecoService
    {
        Task<Response> Update(Endereco endereco);
        Task<Response> Delete(int id);
        Task<DataResponse<Endereco>> GetAll();
        Task<SingleResponse<Endereco>> GetById(int id);
    }
}
