using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.ProdutosEntradas
{
    internal class ProdutoEntradaGetAllValidator : ProdutoEntradaValidator
    {
        public ProdutoEntradaGetAllValidator()
        {
            ValidateID();
        }
    }
}
