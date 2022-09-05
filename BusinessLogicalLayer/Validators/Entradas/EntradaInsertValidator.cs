using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Entradas
{
    internal class EntradaInsertValidator : EntradaValidator
    {
        public EntradaInsertValidator()
        {
            ValidateID();
            ValidateData();
            ValidateValor();
        }
    }
}
