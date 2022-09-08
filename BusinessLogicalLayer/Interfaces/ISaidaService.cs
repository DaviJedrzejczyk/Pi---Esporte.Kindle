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
    public interface ISaidaService
    {
        Task<SingleResponse<List<SaidaView>>> GetByDate(FilterSaida saida);
        Task<Response> Insert(Saida saida);
        Task<DataResponse<SaidaView>> GetAll();
        Task<SingleResponse<SaidaView>> GetSaidaViewById(Saida saida);
        Task<SingleResponse<Saida>> GetById(Saida saida);
    }
}
