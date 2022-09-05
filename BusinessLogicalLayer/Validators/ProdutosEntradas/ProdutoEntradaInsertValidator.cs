using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.ProdutosEntradas
{
    internal class ProdutoEntradaInsertValidator : ProdutoEntradaValidator
    {
        public ProdutoEntradaInsertValidator()
        {
            ValidateID();
            ValidateQuantidade();
            ValidateValorUnitario();
        }
    }
}
