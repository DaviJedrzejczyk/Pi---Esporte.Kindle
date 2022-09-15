using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IEnderecoDALService
    {

        Task<Response> Insert(Endereco endereco);
        Task<Response> Update(Endereco endereco);
        Task<Response> Delete(int id);
        Task<DataResponse<Endereco>> GetAll();
        Task<SingleResponse<Endereco>> GetById(int id);
    }
}
