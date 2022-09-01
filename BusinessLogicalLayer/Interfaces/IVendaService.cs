using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Interfaces
{
    public interface IVendaService
    {

        Task<Response> Insert(Venda venda);
        Task<Response> Update(Venda venda);
        Task<Response> Delete(Venda venda);
        Task<DataResponse<Venda>> GetAll();
        Task<SingleResponse<Venda>> GetById(Venda venda);
    }
}
