using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IProdutoEntradaDALService
    {
        Task<Response> Insert(ProdutoEntrada produtosEntrada);
        Task<DataResponse<ProdutoEntradaView>> GetAllByEntradaID(int id);
    }
}
