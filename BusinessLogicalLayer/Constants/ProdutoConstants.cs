﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Constants
{
    internal class ProdutoConstants
    {
        public const string MENSAGEM_ERRO_VALOR_VAZIO = "O valor não pode ser nulo";
        public const string MENSAGEM_ERRO_VALOR_MAIOR = "O valor não pode ser menor que 1";
        public const string MENSAGEM_ERRO_QUANTIDADE_ESTOQUE_MENOR = "A quantidade do estoque não pode ser menor que 1";
        public const string MENSAGEM_ERRO_QUANTIDADE_ESTOQUE_MAIOR = "A quantidade do estoque não pode ser maior que 9999";
        public const string MENSAGEM_ERRO_QUANTIDADE_ESTOQUE_VAZIO = "A quantidade do estoque não pode ser nula";
    }
}
