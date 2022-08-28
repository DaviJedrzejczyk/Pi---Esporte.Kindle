using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Constants
{
    internal static class GenericConstants
    {
        public const string MENSAGEM_ERRO_ID_VAZIO = "Id não pode ser vazio";
        public const string MENSAGEM_ERRO_EMAIL_FORMATO = "Formato do email incorreto";
        public const string MENSAGEM_ERRO_EMAIL_VAZIO = "Email deve ser informado";
        public const string MENSAGEM_ERRO_EMAIL_MAIOR = "Email deve conter no máximo 100 caracteres";
        public const string MENSAGEM_ERRO_EMAIL_MENOR = "Email deve conter no mínimo 3 caracteres";
        public const string MENSAGEM_ERRO_TELEFONE_VAZIO = "Telefone deve ser informado";
        public const string MENSAGEM_ERRO_TELEFONE_MAIOR = "Telfone deve conter no maximo 9 digitos";
        public const string MENSAGEM_ERRO_TELEFONE_MENOR = "Telefone deve conter no mínimo 8 dígitos";
        public const string MENSAGEM_ERRO_CPF_VAZIO = "CPF deve ser informado";
        public const string MENSAGEM_ERRO_CPF_MAIOR = "CPF deve conter no máximo 11 caracteres";
        public const string MENSAGEM_ERRO_CPF_MENOR = "CPF deve conter no mínimo 11 caracteres";
        public const string MENSAGEM_ERRO_RG_VAZIO = "RG deve ser informado";
        public const string MENSAGEM_ERRO_RG_MAIOR = "RG deve conter no máximo 10 digitos";
        public const string MENSAGEM_ERRO_RG_MENOR = "RG deve conter no mínimo 7 digitos";
        public const string MENSAGEM_ERRO_NOME_VAZIO = "Nome deve ser informado";
        public const string MENSAGEM_ERRO_NOME_MAIOR = "Nome deve ter no máximo 50 caracteres";
        public const string MENSAGEM_ERRO_NOME_MENOR = "Nome deve ter no mínimo 5 caracteres";
        public const string MENSGEM_ERRO_SOBRENOME_VAZIO = "Sobrenome deve ser informado";
        public const string MENSAGEM_ERRO_DATA_VAZIO = "Data de Nascimento deve ser informada";
    }
}
