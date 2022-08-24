using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validator.Clientes
{
    internal class InsertValidator : ClienteValidator
    {
        public InsertValidator()
        {
            ValidateCpf();
            ValidateEmail();
            ValidateID();
            ValidateNome();
            ValidateRG();
            ValidateTelefone();
            ValidateDataNascimento();
        }
    }
}
