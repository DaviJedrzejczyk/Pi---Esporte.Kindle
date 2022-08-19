using Entities;
using Shared.DataResponses;
using Shared.Responses;
using Shared.SingleResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IFornecedoraDALService
    {
        Response Insert(Fornecedor fornecedor);
        Response Update(Fornecedor fornecedor);
        Response Delete(Fornecedor fornecedor);
        DataResponse<Fornecedor> GetAll();
        SingleResponse<Fornecedor> GetById(int id);
    }
}
