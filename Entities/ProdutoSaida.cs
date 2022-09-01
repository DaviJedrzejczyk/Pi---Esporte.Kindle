using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProdutoSaida
    {
        public int ID { get; set; }
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public Saida Saida { get; set; }
        public int SaidaId { get; set; }
        public double Quantidade { get; set; }
        public double ValorUnitario { get; set; }
    }
}
