using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Fornecedoras
{
    internal class FornecedoraInsertValidator : FornecedorValidator
    {
        public FornecedoraInsertValidator()
        {
            ValidateCnpj();
            ValidateEmail();
            ValidateNome();
            ValidateTelefone();
            ValidateID();
        }
    }
}
