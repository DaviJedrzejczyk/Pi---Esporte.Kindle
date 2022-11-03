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
            RuleFor(c => c.Quantidade).NotNull().WithMessage(ProdutosSaidasConstants.MENSAGEM_ERRO_PRODUTO_SAIDA_QUANTIDADE_VAZIO)
                                     .LessThan(0).WithMessage(ProdutosSaidasConstants.MENSAGEM_ERRO_PRODUTO_SAIDA_VALOR_MENOR)
                                     .GreaterThan(9999).WithMessage(ProdutosSaidasConstants.MENSAGEM_ERRO_PRODUTO_SAIDA_QUANTIDADE_MAIOR);
        }
        public void ValidateValorUnitario()
        {
            RuleFor(c => c.ValorUnitario).NotNull().WithMessage(ProdutosSaidasConstants.MENSAGEM_ERRO_PRODUTO_SAIDA_VALOR_VAZIO)
                                        .LessThan(0).WithMessage(ProdutosSaidasConstants.MENSAGEM_ERRO_PRODUTO_SAIDA_VALOR_MENOR);
        }
    }
}
