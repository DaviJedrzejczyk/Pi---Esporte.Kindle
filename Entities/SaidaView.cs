﻿using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SaidaView : Entity
    {
        public DateTime DataSaida { get; set; }
        public double Valor { get; set; }
        public string Funcionario { get; set; }
        public string Cliente { get; set; }
        public FormaPagamento FormaPagamento{ get; set; }
        public double ValorTotal { get; set; }
        public List<ProdutoSaidaView> produtosSaidas { get; set; }
    }
}
