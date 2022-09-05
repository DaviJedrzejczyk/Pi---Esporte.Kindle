namespace Entities
{
    public class ProdutoSaidaView
    {
        public int ID { get; set; }
        public Saida Saida { get; set; }
        public int SaidaID { get; set; }
        public ProdutoView Produto { get; set; }
        public double Quantidade { get; set; }
        public double ValorUnitario { get; set; }
    }
}