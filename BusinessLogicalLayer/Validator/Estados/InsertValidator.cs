using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validator.Estados
{
    internal class InsertValidator : EstadoValidator
    {
        public InsertValidator()
        {
            ValidateId();
            ValidateNomeAbreviado();
            ValidateNomeCompleto();
        }
    }
}
