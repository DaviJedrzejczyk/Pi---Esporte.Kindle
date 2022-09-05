using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.ProdutosSaidas
{
    internal class ProdutoSaidaInsertValidator : ProdutoSaidaValidator
    {
        public ProdutoSaidaInsertValidator()
        {
            ValidateID();
            ValidateQuantidade();
            ValidateValorUnitario();
        }
    }
}
