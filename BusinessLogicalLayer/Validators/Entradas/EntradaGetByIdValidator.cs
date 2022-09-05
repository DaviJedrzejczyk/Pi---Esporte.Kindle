using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Entradas
{
    internal class EntradaGetByIdValidator : EntradaValidator
    {
        public EntradaGetByIdValidator()
        {
            ValidateID();
        }
    }
}
