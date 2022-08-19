using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validator.Clientes
{
    internal class ClienteValidator : AbstractValidator<Cliente>
    {
        public void ValidateID()
        {
            RuleFor(c => c.ID).NotNull();
        }
        public void ValidateNome()
        {
            RuleFor(c => c.Nome).NotNull().MinimumLength(3).MaximumLength(30);
        }
        public void ValidateSenha()
        {
            
        }
        public void ValidateEmail()
        {

        }
        public void ValidateIdade()
        {

        }
        public void ValidateDataNascimento()
        {

        }
        public void ValidateCpf()
        {

        }
        public void ValidateTelefone()
        {

        }
        public void ValidateRG()
        {

        }
    }
}
