using BusinessLogicalLayer.Extensions;
using BusinessLogicalLayer.Interfaces;
using BusinessLogicalLayer.Validators.Entradas;
using BusinessLogicalLayer.Validators.Produtos;
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
using System.Transactions;

namespace BusinessLogicalLayer.BLL
{
    public class EntradaBLL : IEntradaService
    {
        private readonly IEntradaDALService entradaDAL;
        private readonly IProdutoEntradaDALService produtoEntradaDAL;
        public EntradaBLL(IEntradaDALService entradaDAL, IProdutoEntradaDALService produto)
        {
            this.entradaDAL = entradaDAL;
            this.produtoEntradaDAL = produto;
        }

        public async Task<Response> Insert(Entrada entrada)
        {
            EntradaValidator validationRules = new();
            Response response = validationRules.Validate(entrada).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            using (TransactionScope scope = new())
            {
                response = await entradaDAL.Insert(entrada);
                for (int i = 0; i < entrada.produtosEntradas.Count; i++)
                {
                    entrada.produtosEntradas[i].EntradaID = entrada.ID;
                    response = await produtoEntradaDAL.Insert(entrada.produtosEntradas[i]);
                }
                if (!response.HasSuccess)
                {
                    return response;
                }
                scope.Complete();
            }
            return response;
        }
        public async Task<DataResponse<ProdutoEntradaView>> GetAllEntradaById(ProdutoEntrada produtoEntrada)
        {
            return await produtoEntradaDAL.GetAllByEntradaID(produtoEntrada.ID);
        }
        public async Task<DataResponse<EntradaView>> GetAll()
        {
            return await entradaDAL.GetAll();
        }

        public async Task<SingleResponse<EntradaView>> GetById(Entrada entrada)
        {
            return await entradaDAL.GetById(entrada.ID);
        }

        public async Task<SingleResponse<List<EntradaView>>> GetByDate(FilterEntrada entrada)
        {
            return await entradaDAL.GetByDate(entrada);
        }
    }
}
