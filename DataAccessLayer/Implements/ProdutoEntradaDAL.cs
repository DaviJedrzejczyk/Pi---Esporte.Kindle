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
    public class ProdutoEntradaDAL : IProdutoEntradaDALService
    {
        private readonly PIKindleDB _kindle;
        public ProdutoEntradaDAL(PIKindleDB pIKindleDB)
        {
            _kindle = pIKindleDB;
        }
        public async Task<DataResponse<ProdutoEntradaView>> GetAllByEntradaID(ProdutoEntrada produtosEntrada)
        {
            try
            {
                List<ProdutoEntradaView> pr = await _kindle.ProdutoEntradasViews.Where(p => p.Entrada.ID == produtosEntrada.ID).ToListAsync();

                if(pr == null)
                {
                    return DataResponseFactory<ProdutoEntradaView>.CreateFailureResponse();
                }
                return DataResponseFactory<ProdutoEntradaView>.CreateSuccessResponse(pr);
            }
            catch (Exception ex)
            {
                return DataResponseFactory<ProdutoEntradaView>.CreateFailureResponse(ex);
            }
        }

        public async Task<Response> Insert(ProdutoEntrada produtosEntrada)
        {
            _kindle.Add(produtosEntrada);
            try
            {
                await _kindle.SaveChangesAsync();
                return ResponseFactory.CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateFailureResponse(ex);
            }
        }
    }
}
