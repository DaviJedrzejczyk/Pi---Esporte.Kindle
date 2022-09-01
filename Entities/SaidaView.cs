﻿using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SaidaView
    {
        public int ID { get; set; }
        public DateTime DataSaida { get; set; }
        public double Valor { get; set; }
        public Funcionario Funcionario { get; set; }
        public int FuncionarioID { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteID { get; set; }
        public FormaPagamento FormaPagamento{ get; set; }
        public double ValorTotal { get; set; }
        public List<ProdutosSaidaView> produtosSaidas { get; set; }
    }
}
