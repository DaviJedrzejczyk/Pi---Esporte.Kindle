using BusinessLogicalLayer.Interfaces;
using DataAccessLayer.Interfaces;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BLL
{
    public class ProdutoSaidaBLL : IProdutoSaidaService
    {
        private readonly IProdutoSaidaDALService produtoSaidaDAL;
        public ProdutoSaidaBLL(IProdutoSaidaDALService produtoSaidaDAL)
        {
            this.produtoSaidaDAL = produtoSaidaDAL;
        }
        public async Task<Response> Insert(ProdutoSaida produto)
        {
            return await produtoSaidaDAL.Insert(produto);
        }
        public async Task<DataResponse<ProdutoSaidaView>> GetAllBySaidaID(ProdutoSaida produto)
        {
            return await produtoSaidaDAL.GetAllBySaidaID(produto.ID);
        }

       
    }
}
