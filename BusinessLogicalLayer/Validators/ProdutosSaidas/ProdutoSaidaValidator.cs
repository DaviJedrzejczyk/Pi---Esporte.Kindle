using BusinessLogicalLayer.Constants;
using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.ProdutosSaidas
{
    internal class ProdutoSaidaValidator : AbstractValidator<ProdutoSaida>
    {
        public void ValidateID()
        {
            RuleFor(p => p.ID).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_ID_VAZIO);
        }
        public void ValidateQuantidade()
        {

        }
        public void ValidateValorUnitario()
        {

        }
    }
}
