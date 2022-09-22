using BusinessLogicalLayer.Extensions;
using BusinessLogicalLayer.Interfaces;
using BusinessLogicalLayer.Validators.Saidas;
using DataAccessLayer.Interfaces;
using Entities;
using Entities.Filters;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BusinessLogicalLayer.BLL
{
    public class SaidaBLL : ISaidaService
    {
        private readonly ISaidaDALService saidaDAL;
        private readonly IProdutoSaidaDALService produtoSaidaDAL;
        public SaidaBLL(ISaidaDALService saidaDAL, IProdutoSaidaDALService produtoSaidaDAL)
        {
            this.saidaDAL = saidaDAL;
            this.produtoSaidaDAL = produtoSaidaDAL;
        }
        public async Task<Response> Insert(Saida saida)
        {
            SaidaInsertValidator saidaInsertValidator = new();
            Response response = saidaInsertValidator.Validate(saida).ToResponse();
            using (TransactionScope transactionScope = new())
            {
                response = await saidaDAL.Insert(saida);
                for (int i = 0; i < saida.produtoSaidas.Count; i++)
                {
                    saida.produtoSaidas[i].SaidaId = saida.ID;
                    response = await produtoSaidaDAL.Insert(saida.produtoSaidas[i]);
                }
                if (!response.HasSuccess)
                {
                    return response;
                }
                transactionScope.Complete();
            }
            return response;
            
        }
        public async Task<DataResponse<SaidaView>> GetAll()
        {
            return await saidaDAL.GetAll();
        }
        public async Task<DataResponse<ProdutoSaidaView>> GetAllBySaidaId(ProdutoSaida saida)
        {
            return await produtoSaidaDAL.GetAllBySaidaID(saida.ID);
        }
        public async Task<SingleResponse<Saida>> GetById(Saida saida)
        {
            return await saidaDAL.GetById(saida.ID);
        }

        public async Task<SingleResponse<SaidaView>> GetSaidaViewById(Saida saida)
        {
            return await saidaDAL.GetSaidaViewById(saida.ID);
        }

        public async Task<SingleResponse<List<SaidaView>>> GetByDate(FilterSaida saida)
        {
            return await saidaDAL.GetByDate(saida);
        }
    }
}
