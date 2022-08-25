using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validator.Logins
{
    internal class LoginEntradaValidator : LoginValidator
    {
        public LoginEntradaValidator()
        {
            ValidateEmail();
            ValidateSenha();
        }
    }
}
