using BusinessLogicalLayer.Constants;
using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Enderecos
{
    internal class EnderecoValidator : AbstractValidator<Endereco>
    {
        public void ValidateId()
        {
            RuleFor(e => e.ID).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_ID_VAZIO);
        }
        public void ValidateCidade()
        {
            RuleFor(e => e.Cidade).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_VAZIO)
                                  .MaximumLength(30).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MAIOR)
                                  .MinimumLength(3).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MENOR);
        }
        public void ValidateBairro()
        {
            RuleFor(e => e.Bairro).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_VAZIO)
                                  .MaximumLength(30).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MAIOR)
                                  .MinimumLength(3).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MENOR);

        }
        public void ValidateRua()
        {
            RuleFor(e => e.Rua).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_VAZIO)
                                .MaximumLength(30).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MAIOR)
                                .MinimumLength(5).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MENOR);
        }
        public void ValidateCep()
        {
            RuleFor(e => e.CEP).NotNull().WithMessage(EnderecoConstants.MENSAGEM_ERRO_CEP_VAZIO)
                               .MaximumLength(9).WithMessage(EnderecoConstants.MENSAGEM_ERRO_CEP_MAIOR)
                               .MinimumLength(9).WithMessage(EnderecoConstants.MENSAGEM_ERRO_CEP_MENOR);
        }
        public void ValidateNumero()
        {
            RuleFor(e => e.Numero).NotNull().WithMessage(EnderecoConstants.MENSAGEM_ERRO_NUMERO_VAZIO)
                                  .MaximumLength(4).WithMessage(EnderecoConstants.MENSAGEM_ERRO_NUMERO_MAIOR)
                                  .MinimumLength(2).WithMessage(EnderecoConstants.MENSAGEM_ERRO_NUMERO_MENOR);
        }
        public void ValidateComplemento()
        {
            RuleFor(e => e.Rua).MaximumLength(30).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MAIOR)
                               .MinimumLength(5).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MENOR);
        }
        public void ValidatePontoReferencia()
        {
            RuleFor(e => e.Rua).MaximumLength(30).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MAIOR)
                               .MinimumLength(5).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MENOR);
        }
    }
}
