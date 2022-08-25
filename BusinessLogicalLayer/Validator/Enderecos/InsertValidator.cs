using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validator.Enderecos
{
    internal class InsertValidator : EnderecoValidator
    {
        public InsertValidator()
        {
            ValidateId();
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
