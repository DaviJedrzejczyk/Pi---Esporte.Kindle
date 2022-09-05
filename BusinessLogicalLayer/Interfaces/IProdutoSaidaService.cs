using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Interfaces
{
    public interface IProdutoSaidaService
    {
        Task<Response> Insert(ProdutoSaida produto);
        Task<DataResponse<ProdutoSaidaView>> GetAllBySaidaID(ProdutoSaida produto);
    }
}
