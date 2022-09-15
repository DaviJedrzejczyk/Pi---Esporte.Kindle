namespace Entities
{
    public class ProdutoSaidaView
    {
        public Saida Saida { get; set; }
        public int SaidaID { get; set; }
        public ProdutoView ProdutoView { get; set; }
        public int ProdutoViewID { get; set; }
        public double Quantidade { get; set; }
        public double ValorUnitario { get; set; }
    }
}