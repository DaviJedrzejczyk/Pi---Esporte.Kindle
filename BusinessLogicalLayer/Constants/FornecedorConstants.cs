using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Constants
{
    internal static class FornecedorConstants
    {
        public const string MENSAGEM_ERRO_CNPJ_VAZIO = "CNPJ deve ser informado";
        public const string MENSAGEM_ERRO_CNPJ_MAIOR = "CNPJ não pode ter mais que 12 caracteres";
        public const string MENSAGEM_ERRO_CNPJ_MENOR = "CNPJ não pode ter menos que 12 caracteres";
        public const string MENSGAEM_ERRO_CNPJ_INVALIDO = "O CNPJ inserido não é válido";
    }
}
