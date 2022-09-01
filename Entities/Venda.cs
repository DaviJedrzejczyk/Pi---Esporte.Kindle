﻿using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Venda
    {
        public int ID { get; set; }
        public DateTime DataVenda { get; set; }
        public double Valor { get; set; }
        public Funcionario Funcionario { get; set; }
        public int FuncionarioId { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public FormaPagamento FormaPagamento{ get; set; }
        public List<Produto> Produtos { get; set; }

    }
}
