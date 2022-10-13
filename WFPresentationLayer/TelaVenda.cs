using BusinessLogicalLayer.Interfaces;
using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPresentationLayer
{
    public partial class TelaVenda : Form
    {
        IClienteService clienteService;
        IFuncionarioService funcionarioService;
        IProdutoService produtoService;
        IFornecedoraService fornecedoraService;
        List<Produto> produtos = new();

        public TelaVenda(IClienteService clienteService, IFuncionarioService funcionarioService, IFornecedoraService fornecedoraService, IProdutoService produtoService)
        {
            this.clienteService = clienteService;
            this.funcionarioService = funcionarioService;
            this.fornecedoraService = fornecedoraService;
            this.produtoService = produtoService;
            InitializeComponent();
        }
        private void TelaVenda_Load(object sender, EventArgs e)
        {
            cbProduto.DataSource = produtoService.GetAll().Result.Itens;
            cbProduto.DisplayMember = "Nome";
            cbProduto.ValueMember = "ID";
            cbFormaPag.DataSource = Enum.GetNames(typeof(FormaPagamento));
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
    }
}
