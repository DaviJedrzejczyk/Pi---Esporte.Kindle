using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Saida : Entity
    {
        public int ClienteID { get; set; }
        public int FuncionarioID { get; set; }
        public DateTime DataSaida { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public double Valor_Total { get; set; }
        public double Valor { get; set; }
        public List<ProdutoSaida> produtoSaidas { get; set; }
    }
}
