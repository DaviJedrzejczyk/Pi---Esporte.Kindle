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
        double CalculateNewValueWihtProducts(Produto OldProduct, Produto NewProduct);
        Task<DataResponse<Produto>> CalculateNewValue(List<Produto> produtos);
        DataResponse<Produto> CalculateInventory(List<Produto> produtos);
        Task<Response> UpdateValueAndInventory(Produto produto);
    }
}
