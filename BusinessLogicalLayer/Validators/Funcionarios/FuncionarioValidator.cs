using BusinessLogicalLayer.Constants;
using Entities;
using FluentValidation;
using BusinessLogicalLayer.Validators.GenericValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Validators.Funcionarios
{
    internal class FuncionarioValidator : AbstractValidator<Funcionario>
    {
        public void ValidateID()
        {
            RuleFor(c => c.ID).NotNull();
        }
        public void ValidateNome()
        {
            RuleFor(c => c.Nome).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_VAZIO)
                                .MaximumLength(30).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MAIOR)
                                .MinimumLength(3).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MENOR);
        }
        public void ValidateSenha()
        {
            RuleFor(x => x.Senha).NotNull().WithMessage(FuncionarioConstants.MENSAGEM_ERRO_SENHA_VAZIA)
                                .MaximumLength(20).WithMessage(FuncionarioConstants.MENSAGEM_ERRO_SENHA_MAIOR)
                                .MinimumLength(6).WithMessage(FuncionarioConstants.MENSAGEM_ERRO_SENHA_MENOR);

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
                             .MinimumLength(11).WithMessage(GenericConstants.MENSAGEM_ERRO_CPF_MENOR)
                             .IsCpfValid().WithMessage(GenericConstants.MENSAGEM_ERRO_CPF_FORMATO_INVALIDO);
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
                                  .MinimumLength(9).WithMessage(GenericConstants.MENSAGEM_ERRO_RG_MENOR)
                                  .IsRgValid().WithMessage(GenericConstants.MENSAGEM_ERRO_RG_FORMATO_INVALIDO);
        }
        public void ValidateIdEndereco()
        {
            RuleFor(e => e.Endereco.ID).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_ID_VAZIO);
        }
        public void ValidateCidade()
        {
            RuleFor(e => e.Endereco.Cidade).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_VAZIO)
                                  .MaximumLength(30).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MAIOR)
                                  .MinimumLength(3).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MENOR);
        }
        public void ValidateBairro()
        {
            RuleFor(e => e.Endereco.Bairro).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_VAZIO)
                                  .MaximumLength(30).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MAIOR)
                                  .MinimumLength(3).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MENOR);

        }
        public void ValidateRua()
        {
            RuleFor(e => e.Endereco.Rua).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_VAZIO)
                                .MaximumLength(30).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MAIOR)
                                .MinimumLength(5).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MENOR);
        }
        public void ValidateCep()
        {
            RuleFor(e => e.Endereco.CEP).NotNull().WithMessage(EnderecoConstants.MENSAGEM_ERRO_CEP_VAZIO)
                               .MaximumLength(9).WithMessage(EnderecoConstants.MENSAGEM_ERRO_CEP_MAIOR)
                               .MinimumLength(9).WithMessage(EnderecoConstants.MENSAGEM_ERRO_CEP_MENOR);
        }
        public void ValidateNumero()
        {
            RuleFor(e => e.Endereco.Numero).NotNull().WithMessage(EnderecoConstants.MENSAGEM_ERRO_NUMERO_VAZIO)
                                  .MaximumLength(4).WithMessage(EnderecoConstants.MENSAGEM_ERRO_NUMERO_MAIOR)
                                  .MinimumLength(2).WithMessage(EnderecoConstants.MENSAGEM_ERRO_NUMERO_MENOR);
        }
        public void ValidateComplemento()
        {
            RuleFor(e => e.Endereco.Complemento).MaximumLength(30).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MAIOR)
                                                .MinimumLength(5).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MENOR);
        }
        public void ValidatePontoReferencia()
        {
            RuleFor(e => e.Endereco.PontoReferencia).MaximumLength(30).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MAIOR)
                                                    .MinimumLength(5).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MENOR);
        }
        public void ValidateIdEstado()
        {
            RuleFor(e => e.Endereco.Estado.Id).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_ID_VAZIO);
        }
        public void ValidateNomeAbreviado()
        {
            RuleFor(e => e.Endereco.Estado.Unidade_Federal).NotNull().WithMessage               (EstadoConstants.MENSAGEM_ERRO_UNIDADE_FEDERAL_VAZIA)
                                           .MaximumLength(2).WithMessage(EstadoConstants.MENSAGEM_ERRO_UNIDADE_FEDERAL_MAIOR)
                                           .MinimumLength(2).WithMessage(EstadoConstants.MENSAGEM_ERRO_UNIDADE_FEDERAL_MENOR);
        }
        public void ValidateNomeCompleto()
        {
            RuleFor(e => e.Endereco.Estado.NomeCompleto).NotNull().WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_VAZIO)
                                        .MaximumLength(20).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MAIOR)
                                        .MinimumLength(3).WithMessage(GenericConstants.MENSAGEM_ERRO_NOME_MENOR);
        }
    }
}
