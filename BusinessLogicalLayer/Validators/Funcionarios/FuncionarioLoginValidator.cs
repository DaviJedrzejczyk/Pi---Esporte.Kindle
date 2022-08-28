using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Funcionarios
{
    internal class FuncionarioLoginValidator : FuncionarioValidator
    {
        public FuncionarioLoginValidator()
        {
            ValidateEmail();
            ValidateSenha();
        }
    }
}
