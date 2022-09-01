﻿using BusinessLogicalLayer.Constants;
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

        }
        public void ValidateNome()
        {

        }
        public void ValidateQuantidadeEstoq()
        {

        }
        public void ValidateDescricao()
        {
            RuleFor(c => c.Descricao).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_DESCRICAO_VAZIA)
                                     .MinimumLength(10).WithMessage(GenericConstants.MENSAGEM_ERRO_DESCRICAO_MENOR)
                                     .MaximumLength(50).WithMessage(GenericConstants.MENSAGEM_ERRO_DESCRICAO_MAIOR);
        }
    
        public void ValidateValor()
        {

        }
    }
}
