﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Produto : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int FornecedorId { get; set; }
        public int QtdEstoque { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }  
        public double Valor_Unitario { get; set; }
    }
}
