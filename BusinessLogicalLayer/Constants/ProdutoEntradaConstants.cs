using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Constants
{
    internal static class ProdutoEntradaConstants
    {
        public const string MENSAGEM_ERRO_PRODUTO_ENTRADA_VALOR_VAZIO = "Valor não pode ser vazio ou nulo";
        public const string MENSAGEM_ERRO_PRODUTO_ENTRADA_VALOR_MENOR = "Valor não pode ser menor que 0";
        public const string MENSAGEM_ERRO_PRODUTO_ENTRADA_QUANTIDADE_VAZIA = "Quantidade não pode ser vazia ou nula";
        public const string MENSAGEM_ERRO_PRODUTO_ENTRADA_QUANTIDADE_MENOR = "Quantidade não pode ser menor que 1";
        public const string MENSAGEM_ERRO_PRODUTO_ENTRADA_QUANTIDADE_MAIOR = "Quantidade não pode ser maior que 3000";
    }
}
