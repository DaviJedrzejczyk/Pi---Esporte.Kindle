using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Enderecos
{
    internal class EnderecoUpdateValidator : EnderecoValidator
    {
        public EnderecoUpdateValidator()
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
