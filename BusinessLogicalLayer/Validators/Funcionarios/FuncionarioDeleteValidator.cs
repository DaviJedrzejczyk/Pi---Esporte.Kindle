﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Funcionarios
{
    internal class FuncionarioDeleteValidator : FuncionarioValidator
    {
        public FuncionarioDeleteValidator()
        {
            ValidateID();
        }
    }
}
