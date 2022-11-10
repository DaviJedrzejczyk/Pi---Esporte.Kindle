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
    public interface ISaidaDALService
    {
        Task<SingleResponse<List<SaidaView>>> GetByDate(FilterSaida saida);
        Task<Response> Insert(Saida saida);
        Task<DataResponse<SaidaView>> GetAll();
        SingleResponse<SaidaView> GetSaidaViewById(int id);
        SingleResponse<SaidaView> GetById(int id);
    }
}
