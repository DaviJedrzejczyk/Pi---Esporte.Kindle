using BusinessLogicalLayer.Interfaces;
using DataAccessLayer.Interfaces;
using Entities;
using Entities.Filters;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BLL
{
    public class SaidaBLL : ISaidaService
    {
        private readonly ISaidaDALService saidaDAL;
        public SaidaBLL(ISaidaDALService saidaDAL)
        {
            this.saidaDAL = saidaDAL;
        }
        public async Task<Response> Insert(Saida saida)
        {
            return await saidaDAL.Insert(saida);
        }
        public async Task<DataResponse<SaidaView>> GetAll()
        {
            return await saidaDAL.GetAll();
        }

        public async Task<SingleResponse<Saida>> GetById(Saida saida)
        {
            return await saidaDAL.GetById(saida);
        }

        public async Task<SingleResponse<SaidaView>> GetSaidaViewById(SaidaView saida)
        {
            return await saidaDAL.GetSaidaViewById(saida);
        }

        public async Task<SingleResponse<List<SaidaView>>> GetByDate(FilterSaida saida)
        {
            return await saidaDAL.GetByDate(saida);
        }
    }
}
