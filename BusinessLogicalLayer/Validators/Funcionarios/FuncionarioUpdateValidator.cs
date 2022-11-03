using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Funcionarios
{
    internal class FuncionarioUpdateValidator : FuncionarioValidator
    {
        public FuncionarioUpdateValidator()
        {
            ValidateNome();
            ValidateEmail();
            ValidateTelefone();
            ValidateRua();
            ValidateBairro();
            ValidateCidade();
            ValidateCep();
            ValidatePontoReferencia();
            ValidateComplemento();
            ValidateNumero();
            ValidateNomeCompleto();
            ValidateNomeAbreviado();
        }
    }
}
