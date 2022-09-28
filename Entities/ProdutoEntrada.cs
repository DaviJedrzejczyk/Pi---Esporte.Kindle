namespace Entities
{
    public class ProdutoEntrada : Entity
    {
        public Entrada Entrada { get; set; }
        public int EntradaID { get; set; }
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public double Quantidade { get; set; }
        public double ValorUnitario { get; set; }
    }
}