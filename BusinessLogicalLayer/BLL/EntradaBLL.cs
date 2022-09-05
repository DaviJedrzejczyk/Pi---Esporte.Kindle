using BusinessLogicalLayer.Interfaces;
using DataAccessLayer.Interfaces;
using Entities;
using Entities.Filters;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BLL
{
    public class EntradaBLL : IEntradaService
    {
        private readonly IEntradaDALService entradaDAL;
        public EntradaBLL(IEntradaDALService entradaDAL)
        {
            this.entradaDAL = entradaDAL;
        }

        public async Task<Response> Insert(Entrada entrada)
        {
            return await entradaDAL.Insert(entrada);
        }
        public async Task<DataResponse<EntradaView>> GetAll()
        {
            return await entradaDAL.GetAll();
        }

        public async Task<SingleResponse<EntradaView>> GetById(Entrada entrada)
        {
            return await entradaDAL.GetById(entrada);
        }

        public async Task<SingleResponse<List<EntradaView>>> GetByDate(FilterEntrada entrada)
        {
            return await entradaDAL.GetByDate(entrada);
        }
    }
}
