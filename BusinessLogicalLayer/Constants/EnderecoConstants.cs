using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Constants
{
    internal static class EnderecoConstants
    {
        public const string MENSAGEM_ERRO_CEP_VAZIO = "CEP deve ser informado";
        public const string MENSAGEM_ERRO_CEP_MAIOR = "CEP deve conter 9 caracteres";
        public const string MENSAGEM_ERRO_CEP_MENOR = "CEP deve conter 9 caracteres";
        public const string MENSAGEM_ERRO_NUMERO_VAZIO = "Número da sua casa deve ser informada";
        public const string MENSAGEM_ERRO_NUMERO_MAIOR = "Número deve conter no mámixo 4 dígitos";
        public const string MENSAGEM_ERRO_NUMERO_MENOR = "Número deve conter no mínimo 2 dígitos";
    }
}
