using BusinessLogicalLayer.Constants;
using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.ProdutoEntradaValidators
{
    internal class ProdutoEntradaValidator : AbstractValidator<ProdutoEntrada>
    {
        public void ValidateId()
        {
            RuleFor(x => x.ID).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_ID_VAZIO);
        }
    }
}
