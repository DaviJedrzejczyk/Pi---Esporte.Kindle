using BusinessLogicalLayer.Interfaces;
using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            TelaCliente telaCliente  = new(clienteService);
            telaCliente.ShowDialog();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            Produto produto = produtoService.GetById((Produto)cbProduto.SelectedValue).Result.Item;
            bool hasFound = false;
            if (produto != null)
            {
                produto.QtdEstoque = (int)numericUpDown1.Value;
                produto.Valor_Unitario = Convert.ToDouble(textBox7.Text); 
                for (int i = 0; i < produtos.Count; i++)
                {
                    if (produto.ID == produtos[i].ID)
                    {

                    }
                }
            }
        }
    }
}
