using BusinessLogicalLayer.Constants;
using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Produtos
{
    internal class ProdutoValidator : AbstractValidator<Produto>
    {
        public void ValidateID()
        {
            RuleFor(x => x.ID).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_ID_VAZIO);
        }
        public void ValidateNome()
        {
            RuleFor(x => x.Nome).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_VAZIO)
                                       .MaximumLength(100).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MAIOR)
                                       .MinimumLength(3).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MENOR);
        }
        public void ValidateQuantidadeEstoq()
        {
            RuleFor(c => c.QtdEstoque).NotNull().WithMessage("")
                                      .LessThan(0).WithMessage("")
                                      .GreaterThan(9999).WithMessage("");
        }
        public void ValidateDescricao()
        {
            RuleFor(c => c.Descricao).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_DESCRICAO_VAZIA)
                                     .MinimumLength(10).WithMessage(GenericConstants.MENSAGEM_ERRO_DESCRICAO_MENOR)
                                     .MaximumLength(50).WithMessage(GenericConstants.MENSAGEM_ERRO_DESCRICAO_MAIOR);
        }
    
        public void ValidateValor()
        {
            RuleFor(c => c.Valor_Unitario).NotNull().WithMessage(ProdutoConstants.MENSAGEM_ERRO_VALOR_VAZIO)
                                          .LessThan(0).WithMessage(ProdutoConstants.MENSAGEM_ERRO_VALOR_MAIOR);
        }
    }
}
