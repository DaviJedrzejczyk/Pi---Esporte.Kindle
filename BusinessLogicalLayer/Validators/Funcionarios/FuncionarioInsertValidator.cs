using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Funcionarios
{
    internal class FuncionarioInsertValidator : FuncionarioValidator
    {
        public FuncionarioInsertValidator()
        {
            ValidateID();
            ValidateNome();
            ValidateEmail();
            ValidateSenha();
            ValidateCpf();
            ValidateRG();
            ValidateDataNascimento();
            ValidateTelefone();
            ValidateIdEndereco();
            ValidateRua();
            ValidateBairro();
            ValidateCidade();
            ValidateCep();
            ValidatePontoReferencia();
            ValidateComplemento();
            ValidateNumero();
            ValidateNomeCompleto();
            ValidateNomeAbreviado();
            ValidateIdEstado();
        }
    }
}
