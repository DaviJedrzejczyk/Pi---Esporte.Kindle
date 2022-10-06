using BusinessLogicalLayer.Constants;
using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Fornecedoras
{
    internal class FornecedorValidator : AbstractValidator<Fornecedor>
    {
        public void ValidateID()
        {
            RuleFor(x => x.ID).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_ID_VAZIO);
        }
        public void ValidateNome()
        {
            RuleFor(x => x.Nome_Contato).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_VAZIO)
                                        .MaximumLength(100).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MAIOR)
                                        .MinimumLength(2).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MENOR);
        }
        public void ValidateCnpj()
        {
            RuleFor(x => x.Cnpj).NotNull().WithMessage(FornecedorConstants.MENSAGEM_ERRO_CNPJ_VAZIO)
                                .MaximumLength(14).WithMessage(FornecedorConstants.MENSAGEM_ERRO_CNPJ_MAIOR)
                                .MinimumLength(13).WithMessage(FornecedorConstants.MENSAGEM_ERRO_CNPJ_MENOR);
        }
        public void ValidateEmail()
        {
            RuleFor(c => c.Email).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_EMAIL_VAZIO)
                               .MaximumLength(100).WithMessage(GenericConstants.MENSAGEM_ERRO_EMAIL_MAIOR)
                               .MinimumLength(9).WithMessage(GenericConstants.MENSAGEM_ERRO_EMAIL_MENOR)
                               .EmailAddress().WithMessage(GenericConstants.MENSAGEM_ERRO_EMAIL_FORMATO);
        }
        public void ValidateTelefone()
        {
            RuleFor(c => c.Telefone).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_TELEFONE_VAZIO)
                                    .MaximumLength(14).WithMessage(GenericConstants.MENSAGEM_ERRO_TELEFONE_MAIOR)
                                    .MinimumLength(9).WithMessage(GenericConstants.MENSAGEM_ERRO_TELEFONE_MENOR);
        }
    }
}
