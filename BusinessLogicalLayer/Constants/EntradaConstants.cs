using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BusinessLogicalLayer.Constants
{
    internal static class EntradaConstants
    {
        public const string MENSAGEM_ERRO_VALOR_VAZIO = "O valor da entrada do produto deve ser inserida";
        public const string MENSAGEM_ERRO_VALOR_MAIOR = "O valor não pode ultrapassar 999.999,99";
        public const string MENSAGEM_ERRO_VALOR_MENOR = "O valor não pode ser menor que 1";
        public const string MENSAGEM_ERRO_DATA_ENTRADA_VAZIO = "A data de entrada deve ser informada";
        
    }
}
