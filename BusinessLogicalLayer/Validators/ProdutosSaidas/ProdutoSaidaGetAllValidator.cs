using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.ProdutosSaidas
{
    internal class ProdutoSaidaGetAllValidator : ProdutoSaidaValidator
    {
        public ProdutoSaidaGetAllValidator()
        {
            ValidateID();
        }
    }
}
