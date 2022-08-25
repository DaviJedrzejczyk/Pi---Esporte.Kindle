using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validator.Funcionarios
{
    internal class DeleteValidator : FuncionarioValidator
    {
        public DeleteValidator()
        {
            ValidateID();
        }
    }
}
