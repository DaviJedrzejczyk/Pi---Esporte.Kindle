using BusinessLogicalLayer.Constants;
using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Entradas
{
    internal class EntradaValidator : AbstractValidator<Entrada>
    {
        public void ValidateID()
        {
            RuleFor(x => x.ID).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_ID_VAZIO);
        }
        public void ValidateData()
        {
            RuleFor(x => x.DataEntrada).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_DATA_VAZIO);
        }
        public void ValidateValor()
        {
            RuleFor(x => x.Valor).NotNull().WithMessage(EntradaConstants.MENSAGEM_ERRO_VALOR_VAZIO)
                                 .LessThan(0).WithMessage(EntradaConstants.MENSAGEM_ERRO_VALOR_MENOR);
        }
    }
}
