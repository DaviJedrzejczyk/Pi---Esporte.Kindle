using Entities;
using Entities.Filters;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IEntradaDALService
    {
        Task<SingleResponse<List<EntradaView>>> GetByDate(FilterEntrada filterEntrada);
        Task<Response> Insert(Entrada entrada);
        Task<DataResponse<EntradaView>> GetAll();
        Task<SingleResponse<EntradaView>> GetById(Entrada entrada);

    }
}
