using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Clientes
{
    internal class ClienteInsertValidator : ClienteValidator
    {
        public ClienteInsertValidator()
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
