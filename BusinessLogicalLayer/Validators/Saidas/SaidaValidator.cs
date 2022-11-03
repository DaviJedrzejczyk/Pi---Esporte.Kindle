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
            RuleFor(x => x.DataSaida).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_DATA_VAZIO);
        }
        public void ValidateValorTotal()
        {
            RuleFor(x => x.Valor_Total).NotNull().WithMessage(SaidaConstants.MENSAGEM_ERRO_VALOR_TOTAL_VAZIO)
                                       .LessThan(0).WithMessage(SaidaConstants.MENSAGEM_ERRO_VALOR_TOTAL_MENOR);
        }
        public void ValidateValor()
        {
            RuleFor(x => x.Valor).NotNull().WithMessage(SaidaConstants.MENSAGEM_ERRO_VALOR_VAZIO)
                                 .LessThan(0).WithMessage(SaidaConstants.MENSAGEM_ERRO_VALOR_MENOR);
        }
    }
}
