using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Interfaces
{
    public interface IFornecedoraService
    {

        Task<Response> Insert(Fornecedor item);
        Task<Response> Update(Fornecedor item);
        Task<Response> Delete(int item);
        Task<DataResponse<Fornecedor>> GetAll();
        Task<SingleResponse<Fornecedor>> GetById(int fornecedor);
    }
}
