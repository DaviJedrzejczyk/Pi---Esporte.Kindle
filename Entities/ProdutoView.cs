﻿namespace Entities
{
    public class ProdutoView
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int FornecedorID { get; set; }
        public double QtdEstoque { get; set; }
        public double Valor { get; set; }
    }
}