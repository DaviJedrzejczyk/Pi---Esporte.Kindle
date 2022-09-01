using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface SaidaDALService
    {

        Task<Response> Insert(Saida saida);
        Task<DataResponse<Object>> GetAll();
        Task<SingleResponse<Object>> GetSaidaView();
        Task<SingleResponse<Object>> GetById(Saida saida);
    }
}
