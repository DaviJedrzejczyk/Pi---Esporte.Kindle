using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IFornecedoraDALService
    {
        Task<Response> Insert(Fornecedor fornecedor);
        Task<Response> Update(Fornecedor fornecedor);
        Task<Response> Delete(int id);
        DataResponse<Fornecedor> GetAll();
        Task<SingleResponse<Fornecedor>> GetById(int id);
    }
}
