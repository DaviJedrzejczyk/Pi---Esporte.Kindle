using DataAccessLayer.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using Shared;
using Shared.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implements
{
    public class ProdutosSaidaDAL : IProdutoSaidaDALService
    {
        private readonly PIKindleDB pIKindleDB;
        public ProdutosSaidaDAL(PIKindleDB pIKindleDB)
        {
            this.pIKindleDB = pIKindleDB;
        }

        public async Task<DataResponse<ProdutoSaidaView>> GetAllBySaidaID(ProdutoSaida produto)
        {
            try
            {
                List<ProdutoSaidaView> produtoSaidaViews = await pIKindleDB.ProdutosSaidaViews.Where(p => p.Saida.ID == produto.Saida.ID).ToListAsync();
                return DataResponseFactory<ProdutoSaidaView>.CreateInstance().CreateSuccessResponse(produtoSaidaViews);
            }
            catch (Exception ex)
            {
                return DataResponseFactory<ProdutoSaidaView>.CreateInstance().CreateFailureResponse(ex);
            }
        }

        public async Task<Response> Insert(ProdutoSaida produto)
        {
            pIKindleDB.Add(produto);
            try
            {
                await pIKindleDB.SaveChangesAsync();
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateFailureResponse(ex);
            }
        }
    }
}
