using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Produtos
{
    internal class ProdutoDeleteValidator : ProdutoValidator
    {
        public ProdutoDeleteValidator()
        {
            ValidateID();
        }
    }
}
