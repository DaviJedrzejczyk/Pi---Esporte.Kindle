using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validator.Fornecedoras
{
    internal class InsertValidator : FornecedoraValidator
    {
        public InsertValidator()
        {
            ValidateCnpj();
            ValidateEmail();
            ValidateNome();
            ValidateTelefone();
            ValidateID();
        }
    }
}
