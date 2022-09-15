using BusinessLogicalLayer.Constants;
using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Estados
{
    internal class EstadoValidator : AbstractValidator<Estado>
    {
        public void ValidateId()
        {
            RuleFor(e => e.ID).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_ID_VAZIO);
        }
        public void ValidateNomeAbreviado()
        {
            RuleFor(e => e.Unidade_Federal).NotNull().WithMessage(EstadoConstants.MENSAGEM_ERRO_UNIDADE_FEDERAL_VAZIA)
                                           .MaximumLength(2).WithMessage(EstadoConstants.MENSAGEM_ERRO_UNIDADE_FEDERAL_MAIOR)
                                           .MinimumLength(2).WithMessage(EstadoConstants.MENSAGEM_ERRO_UNIDADE_FEDERAL_MENOR);
        }
        public void ValidateNomeCompleto()
        {
            RuleFor(e => e.NomeCompleto).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_VAZIO)
                                        .MaximumLength(20).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MAIOR)
                                        .MinimumLength(3).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MENOR);
        }
    }
}
