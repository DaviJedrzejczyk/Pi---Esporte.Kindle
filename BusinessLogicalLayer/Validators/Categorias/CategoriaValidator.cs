using BusinessLogicalLayer.Constants;
using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Categorias
{
    internal class CategoriaValidator : AbstractValidator<Categoria>
    {
        public void ValidateID()
        {
            RuleFor(c => c.Id).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_ID_VAZIO);
        }
        public void ValidateNome()
        {
            RuleFor(c => c.Nome).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_VAZIO)
                                .MinimumLength(3).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MENOR)
                                .MaximumLength(30).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MAIOR);
        }
        public void ValidateDescricao()
        {
            RuleFor(c => c.Descricao).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_DESCRICAO_VAZIA)
                                     .MinimumLength(10).WithMessage(GenericConstants.MENSAGEM_ERRO_DESCRICAO_MENOR)
                                     .MaximumLength(50).WithMessage(GenericConstants.MENSAGEM_ERRO_DESCRICAO_MAIOR);
        }
    }
}
