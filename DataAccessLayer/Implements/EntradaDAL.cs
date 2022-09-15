using DataAccessLayer.Interfaces;
using Entities;
using Entities.Filters;
using Shared;
using Shared.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implements
{
    public class EntradaDAL : IEntradaDALService
    {
        

        public async Task<Response> Insert(Entrada entrada)
        {
            return null;
        }
        public async Task<DataResponse<EntradaView>> GetAll()
        {
            return null;
        }
        public async Task<SingleResponse<EntradaView>> GetById(Entrada entrada)
        {
            return null;
        }
        public async Task<SingleResponse<List<EntradaView>>> GetByDate(FilterEntrada filterEntrada)
        {
            return null;
        }
    }
}
