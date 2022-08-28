using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Enderecos
{
    internal class EnderecoInsertValidator : EnderecoValidator
    {
        public EnderecoInsertValidator()
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
