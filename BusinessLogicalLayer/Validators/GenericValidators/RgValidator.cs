using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.GenericValidators
{
    internal static class RgValidator
    {
        public static IRuleBuilderOptions<PessoaFisica, string> IsRgValid<PessoaFisica>(this IRuleBuilder<PessoaFisica, string> param)
        {
            return param.Must(c => ValidateRg(c));
        }
        public static bool ValidateRg(string rg)
        {
            return true;
           
        }
    }
}
