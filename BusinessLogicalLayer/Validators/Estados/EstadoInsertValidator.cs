using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Estados
{
    internal class EstadoInsertValidator : EstadoValidator
    {
        public EstadoInsertValidator()
        {
            ValidateId();
            ValidateNomeAbreviado();
            ValidateNomeCompleto();
        }
    }
}
