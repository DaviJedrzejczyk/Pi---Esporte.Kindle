﻿using DataAccessLayer.Interfaces;
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
    public class ProdutoDAL : IProdutoDALService
    {
        private readonly PIKindleDB _kindleDB;
        public ProdutoDAL(PIKindleDB kindleDB)
        {
            _kindleDB = kindleDB;
        }

        public async Task<Response> Insert(Produto produto)
        {
            _kindleDB.Produtos.Add(produto);
            try
            {
                await _kindleDB.SaveChangesAsync();
                return ResponseFactory.CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateFailureResponse(ex);
            }
        }

        public async Task<Response> Update(Produto produto)
        {
            Produto produto1 = _kindleDB.Produtos.Find(produto.ID);
            produto1.Nome = produto.Nome;
            produto1.Descricao = produto.Descricao;
            produto1.Valor_Unitario = produto.Valor_Unitario;
            produto1.Fornecedor = produto.Fornecedor;
            produto1.QtdEstoque = produto.QtdEstoque;
            try
            {
                await _kindleDB.SaveChangesAsync();
                return ResponseFactory.CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateFailureResponse(ex);
            }
        }
        public async Task<Response> Delete(Produto produto)
        {
            Produto produto1 = _kindleDB.Produtos.Find(produto.ID);
            _kindleDB.Produtos.Remove(produto1);
            try
            {
                await _kindleDB.SaveChangesAsync();
                return ResponseFactory.CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateFailureResponse(ex);
            }
        }

        public async Task<DataResponse<Produto>> GetAll()
        {
            try
            {
                List<Produto> produtos = await _kindleDB.Produtos.ToListAsync();
                return DataResponseFactory<Produto>.CreateSuccessResponse(produtos);
            }
            catch (Exception ex)
            {
                return DataResponseFactory<Produto>.CreateFailureResponse(ex);
            }
        }

        public async Task<SingleResponse<Produto>> GetById(Produto produto)
        {
            try
            {
                Produto produto1 = await _kindleDB.Produtos.FindAsync(produto.ID);
                return SingleResponseFactory<Produto>.CreateSuccessSingleResponse(produto1);
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<Produto>.CreateFailureSingleResponse(ex);
            }
        }

      
    }
}