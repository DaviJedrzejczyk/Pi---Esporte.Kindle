﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Clientes
{
    internal class ClienteDeleteValidator : ClienteValidator
    {
        public ClienteDeleteValidator()
        {
            ValidateID();
        }
    }
}
