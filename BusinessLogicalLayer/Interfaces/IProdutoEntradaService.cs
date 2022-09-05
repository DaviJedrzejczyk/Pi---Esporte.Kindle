using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Interfaces
{
    public interface IProdutoEntradaService
    {
        Task<Response> Insert(ProdutoEntrada produtosEntrada);
        Task<DataResponse<ProdutoEntradaView>> GetAllByEntradaID(ProdutoEntrada produtosEntrada);
    }
}
