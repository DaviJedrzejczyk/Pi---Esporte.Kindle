using BusinessLogicalLayer.Constants;
using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.ProdutosEntradas
{
    internal class ProdutoEntradaValidator : AbstractValidator<ProdutoEntrada>
    {
        public void ValidateID()
        {
            RuleFor(p => p.ID).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_ID_VAZIO);
        }
        public void ValidateQuantidade()
        {
            RuleFor(c => c.Quantidade).NotNull().WithMessage(ProdutoEntradaConstants.MENSAGEM_ERRO_PRODUTO_ENTRADA_QUANTIDADE_VAZIA)
                                     .LessThan(0).WithMessage(ProdutoEntradaConstants.MENSAGEM_ERRO_PRODUTO_ENTRADA_QUANTIDADE_MENOR)
                                     .GreaterThan(9999).WithMessage(ProdutoEntradaConstants.MENSAGEM_ERRO_PRODUTO_ENTRADA_QUANTIDADE_MAIOR);
        }
        public void ValidateValorUnitario()
        {
            RuleFor(c => c.ValorUnitario).NotNull().WithMessage(ProdutoEntradaConstants.MENSAGEM_ERRO_PRODUTO_ENTRADA_VALOR_VAZIO)
                                        .LessThan(0).WithMessage(ProdutoEntradaConstants.MENSAGEM_ERRO_PRODUTO_ENTRADA_VALOR_MENOR);
        }
    }
}
