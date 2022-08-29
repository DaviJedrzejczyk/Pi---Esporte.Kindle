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
    public class ProdutoBLL : IProdutoService
    {
        private readonly IProdutoDALService produtoDAL;
        public ProdutoBLL(IProdutoDALService produtoDAL)
        {
            this.produtoDAL = produtoDAL;
        }

        public async Task<Response> Insert(Produto produto)
        {
            return await produtoDAL.Insert(produto);
        }

        public async Task<Response> Update(Produto produto)
        {
            return await produtoDAL.Update(produto);
        }
        public async Task<Response> Delete(Produto produto)
        {
            return await produtoDAL.Delete(produto);
        }

        public async Task<DataResponse<Produto>> GetAll()
        {
            return await produtoDAL.GetAll();
        }

        public async Task<SingleResponse<Produto>> GetById(Produto produto)
        {
            return await produtoDAL.GetById(produto);
        }

     
    }
}
