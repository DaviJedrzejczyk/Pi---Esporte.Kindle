namespace Entities
{
    public class ProdutoView : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int FornecedorID { get; set; }
        public double QtdEstoque { get; set; }
        public double Valor { get; set; }
    }
}