using BusinessLogicalLayer.Extensions;
using BusinessLogicalLayer.Interfaces;
using DataAccessLayer.Interfaces;
using Entities;
using Shared;
using Shared.Factory;
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
            return await produtoDAL.Delete(produto.ID);
        }

        public async Task<DataResponse<Produto>> GetAll()
        {
            return await produtoDAL.GetAll();
        }

        public async Task<SingleResponse<Produto>> GetById(int produto)
        {
            return await produtoDAL.GetById(produto);
        }

        public double CalculateNewValueWihtProducts(Produto OldProduct, Produto NewProduct)
        {
            double valor = ((OldProduct.Valor_Unitario * OldProduct.QtdEstoque) + (NewProduct.Valor_Unitario * NewProduct.QtdEstoque) / (NewProduct.QtdEstoque * OldProduct.QtdEstoque));
            return Math.Round(valor, 2);
        }

        public async Task<DataResponse<Produto>> CalculateNewValue(List<Produto> produtos)
        {
            SingleResponse<Produto> singleResponse = new();
            for (int i = 0; i < produtos.Count; i++)
            {
                singleResponse = await produtoDAL.GetById(produtos[i].ID);
                if (singleResponse.HasSuccess)
                {
                    produtos[i].Valor_Unitario = ((singleResponse.Item.Valor_Unitario * singleResponse.Item.QtdEstoque) + (produtos[i].Valor_Unitario * produtos[i].QtdEstoque)) / (produtos[i].QtdEstoque + singleResponse.Item.QtdEstoque);
                    produtos[i].Valor_Unitario = Math.Round(produtos[i].Valor_Unitario,2);
                }
                else
                {
                    break;
                }
            }
            return new DataResponse<Produto>(singleResponse.Message, singleResponse.HasSuccess, produtos);
        }
        public DataResponse<Produto> CalculateInventory(List<Produto> produtos)
        {
            List<Produto> produtosWithEstoque = new();
            for (int i = 0; i < produtos.Count; i++)
            {
                produtosWithEstoque.Add(produtoDAL.GetById(produtos[i].ID).Result.Item);
                if (produtosWithEstoque[i].QtdEstoque >= produtos[i].QtdEstoque)
                {
                    produtosWithEstoque[i].QtdEstoque -= produtos[i].QtdEstoque;
                }
                else
                {
                    return DataResponseFactory<Produto>.CreateInstance().CreateFailureResponse($"Não é possivel vender mais do que o estoque! Produto: {produtosWithEstoque[i].Nome}, Estoque: {produtosWithEstoque[i].QtdEstoque}");
                }
            }
            return new DataResponse<Produto>("Calculo efetuado com sucesso", true, produtosWithEstoque);
        }
        public async Task<Response> UpdateValueAndInventory(Produto produto)
        {
            return await produtoDAL.UpdateValueAndInventory(produto);
        }

      
    }
}
