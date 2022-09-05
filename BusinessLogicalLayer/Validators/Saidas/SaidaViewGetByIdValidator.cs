using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Saidas
{
    internal class SaidaViewGetByIdValidator : SaidaValidator
    {
        public SaidaViewGetByIdValidator()
        {
            ValidateID();
        }
    }
}
