using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Estados
{
    internal class EstadoDeleteValidator : EstadoValidator
    {
        public EstadoDeleteValidator()
        {
            ValidateId();
        }
    }
}
