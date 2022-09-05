using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Saidas
{
    internal class SaidaInsertValidator : SaidaValidator
    {
        public SaidaInsertValidator()
        {
            ValidateID();
            ValidateDataSaida();
            ValidateValorTotal();
        }
    }
}
