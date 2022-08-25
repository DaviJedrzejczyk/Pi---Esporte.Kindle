using BusinessLogicalLayer.Constants;
using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validator.Clientes
{
    internal class ClienteValidator : AbstractValidator<Cliente>
    {
        public void ValidateID()
        {
            RuleFor(c => c.ID).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_ID_VAZIO);
        }
        public void ValidateNome()
        {
            RuleFor(c => c.Nome).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_VAZIO)
                                .MinimumLength(3).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MENOR)
                                .MaximumLength(30).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MAIOR);
        }
   
        public void ValidateEmail()
        {
            RuleFor(c => c.Email).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_EMAIL_VAZIO)
                                 .MaximumLength(100).WithMessage(GenericConstants.MENSAGEM_ERRO_EMAIL_MAIOR)
                                 .MinimumLength(9).WithMessage(GenericConstants.MENSAGEM_ERRO_EMAIL_MENOR)
                                 .EmailAddress().WithMessage(GenericConstants.MENSAGEM_ERRO_EMAIL_FORMATO);
        }
        public void ValidateDataNascimento()
        {
            RuleFor(c => c.DataNascimento).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_DATA_VAZIO);
        }
        public void ValidateCpf()
        {
            RuleFor(c => c.CPF).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_CPF_VAZIO)
                               .MaximumLength(14).WithMessage(GenericConstants.MENSAGEM_ERRO_CPF_MAIOR)
                               .MinimumLength(11).WithMessage(GenericConstants.MENSAGEM_ERRO_CPF_MENOR);
        }
        public void ValidateTelefone()
        {
            RuleFor(c => c.Telefone).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_TELEFONE_VAZIO)
                                    .MaximumLength(14).WithMessage(GenericConstants.MENSAGEM_ERRO_TELEFONE_MAIOR)
                                    .MinimumLength(9).WithMessage(GenericConstants.MENSAGEM_ERRO_TELEFONE_MENOR);
        }
        public void ValidateRG()
        {
            RuleFor(c => c.RG).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_RG_VAZIO)
                              .MaximumLength(9).WithMessage(GenericConstants.MENSAGEM_ERRO_RG_MAIOR)
                              .MinimumLength(9).WithMessage(GenericConstants.MENSAGEM_ERRO_RG_MENOR);
        }
    }
}
