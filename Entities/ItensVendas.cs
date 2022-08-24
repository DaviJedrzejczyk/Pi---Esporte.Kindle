using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ItensVendas
    {
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public Venda Venda { get; set; }
        public int VendaId { get; set; }
        public double Preco { get; set; }
        public int QtdProdutos { get; set; }

    }
}
