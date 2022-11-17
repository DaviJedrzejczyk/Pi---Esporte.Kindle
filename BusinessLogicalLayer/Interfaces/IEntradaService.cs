using Entities;
using Entities.Filters;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Interfaces
{
    public interface IEntradaService
    {
        Task<SingleResponse<List<EntradaView>>> GetByDate(FilterEntrada entrada);
        DataResponse<ProdutoEntradaView> GetAllEntradaById(int id);
        Task<Response> Insert(Entrada entrada);
        Task<DataResponse<EntradaView>> GetAll();
        Task<SingleResponse<EntradaView>> GetById(int entrada);
    }
}
