using BusinessLogicalLayer.Constants;
using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validator.Logins
{
    internal class LoginValidator : AbstractValidator<Login>
    {
        public void ValidateEmail()
        {
            RuleFor(x => x.Email).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_EMAIL_VAZIO)
                                 .MaximumLength(100).WithMessage(GenericConstants.MENSAGEM_ERRO_EMAIL_MAIOR)
                                 .MinimumLength(10).WithMessage(GenericConstants.MENSAGEM_ERRO_EMAIL_MENOR)
                                 .EmailAddress().WithMessage(GenericConstants.MENSAGEM_ERRO_EMAIL_FORMATO);
        }
        public void ValidateSenha()
        {
            RuleFor(x => x.Senha).NotNull().WithMessage(FuncionarioConstants.MENSAGEM_ERRO_SENHA_VAZIA)
                                 .MaximumLength(20).WithMessage(FuncionarioConstants.MENSAGEM_ERRO_SENHA_MAIOR)
                                 .MinimumLength(6).WithMessage(FuncionarioConstants.MENSAGEM_ERRO_SENHA_MENOR);
        }
    }
}
