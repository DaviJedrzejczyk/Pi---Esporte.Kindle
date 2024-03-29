﻿using BusinessLogicalLayer.Interfaces;
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
    public class ProdutoEntradaBLL : IProdutoEntradaService
    {
        private readonly IProdutoEntradaDALService produtoEntradaDAL;
        public ProdutoEntradaBLL(IProdutoEntradaDALService produtoEntradaDAL)
        {
            this.produtoEntradaDAL = produtoEntradaDAL;
        }

        public DataResponse<ProdutoEntradaView> GetAllByEntradaID(ProdutoEntrada produtosEntrada)
        {
            return produtoEntradaDAL.GetAllByEntradaID(produtosEntrada.ID);
        }

        public async Task<Response> Insert(ProdutoEntrada produtosEntrada)
        {
            return await produtoEntradaDAL.Insert(produtosEntrada);
        }
    }
}
