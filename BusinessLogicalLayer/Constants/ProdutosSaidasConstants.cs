using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Constants
{
    internal static class ProdutosSaidasConstants
    {
        public const string MENSAGEM_ERRO_PRODUTO_SAIDA_QUANTIDADE_VAZIO = "A quantidade não pode ser vazia ou nula";
        public const string MENSAGEM_ERRO_PRODUTO_SAIDA_QUANTIDADE_MENOR = "A quantidade não pode ser menor que 1";
        public const string MENSAGEM_ERRO_PRODUTO_SAIDA_QUANTIDADE_MAIOR = "A quantidade não pode ser maior que 999";
        public const string MENSAGEM_ERRO_PRODUTO_SAIDA_VALOR_VAZIO = "O valor não pode ser vazio ou nulo";
        public const string MENSAGEM_ERRO_PRODUTO_SAIDA_VALOR_MENOR = "O valor não pode ser menor que 0";

    }
}
