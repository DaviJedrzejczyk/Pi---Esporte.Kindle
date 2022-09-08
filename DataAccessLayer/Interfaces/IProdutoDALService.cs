using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IProdutoDALService
    {

        Task<Response> Insert(Produto produto);
        Task<Response> Update(Produto produto);
        Task<Response> Delete(Produto produto);
        Task<DataResponse<Produto>> GetAll();
        Task<SingleResponse<Produto>> GetById(Produto produto);
        Task<Response> UpdateValueAndInventory(Produto produto);
    }
}
