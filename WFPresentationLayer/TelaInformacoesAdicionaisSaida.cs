using BusinessLogicalLayer.Interfaces;
using Entities;

namespace WFPresentationLayer
{
    public partial class TelaInformacoesAdicionaisSaida : Form
    {
        SaidaView view = new();
        private readonly ISaidaService saida;
        public TelaInformacoesAdicionaisSaida(ISaidaService saida, SaidaView saidaView)
        {
            view = saidaView;
            this.saida = saida;
            InitializeComponent();
        }

        private void TelaInformacoesAdicionais_Load(object sender, EventArgs e)
        {
          
            view.produtosSaidas = saida.GetAllBySaidaId(view.ID).Result.Itens;
            txtCliente.Text = view.Cliente;
            txtData.Text = view.DataSaida.ToString();
            txtFormaPagamento.Text = view.FormaPagamento.ToString();
            txtFuncionario.Text = view.Funcionario;
            txtID.Text = view.ID.ToString();
            txtValorTotal.Text = view.ValorTotal.ToString();

            for (int i = 0; i < view.produtosSaidas.Count; i++)
            {
                dtInfoSaida.Rows.Add();
                dtInfoSaida.Rows[i].Cells["dtProduto"].Value = view.produtosSaidas[i].ProdutoView.Nome;
                dtInfoSaida.Rows[i].Cells["dtQuantidade"].Value = view.produtosSaidas[i].Quantidade;
                dtInfoSaida.Rows[i].Cells["dtValorUnitario"].Value = view.produtosSaidas[i].ValorUnitario;
            }
        }
    }
}
