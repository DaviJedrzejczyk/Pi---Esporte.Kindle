using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validator.Funcionarios
{
    internal class InsertValidator : FuncionarioValidator
    {
        public InsertValidator()
        {
            ValidateID();
            ValidateNome();
            ValidateEmail();
            ValidateSenha();
            ValidateCpf();
            ValidateRG();
            ValidateDataNascimento();
            ValidateTelefone();
        }
    }
}
