using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Venda
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public Funcionario Funcionario { get; set; }
        public int FuncionarioId { get; set; }
        public FormaPagamento FormaPaga { get; set; }
        public double ValorTotal { get; set; }
        public List<ItensVendas> Itens { get; set; }

    }
}
