using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validator.Estados
{
    internal class UpdateValidator : EstadoValidator
    {
        public UpdateValidator()
        {
            ValidateNomeAbreviado();
            ValidateNomeCompleto();
        }
    }
}
