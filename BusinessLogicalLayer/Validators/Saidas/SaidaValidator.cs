using BusinessLogicalLayer.Constants;
using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Saidas
{
    internal class SaidaValidator : AbstractValidator<Saida>
    {
        public void ValidateID()
        {
            RuleFor(s => s.ID).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_ID_VAZIO);
        }
        public void ValidateDataSaida()
        {

        }
        public void ValidateValorTotal()
        {

        }
    }
}
