using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Interfaces
{
    public interface IProdutoService
    {

        Task<Response> Insert(Produto produto);
        Task<Response> Update(Produto produto);
        Task<Response> Delete(Produto produto);
        Task<DataResponse<Produto>> GetAll();
        Task<SingleResponse<Produto>> GetById(Produto produto);
    }
}
