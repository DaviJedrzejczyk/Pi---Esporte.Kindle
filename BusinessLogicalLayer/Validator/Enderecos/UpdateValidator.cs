using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validator.Enderecos
{
    internal class UpdateValidator : EnderecoValidator
    {
        public UpdateValidator()
        {
            ValidateComplemento();
            ValidateRua();
            ValidateBairro();
            ValidateCep();
            ValidateCidade();
            ValidateNumero();
            ValidatePontoReferencia();
        }
    }
}
