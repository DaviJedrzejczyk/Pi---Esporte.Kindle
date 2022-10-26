using BusinessLogicalLayer.Interfaces;
using Entities;
using Entities.Enums;
using Shared;
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
        ISaidaService saidaService;
        List<Produto> produtos = new();

        public TelaVenda(IClienteService clienteService, IFuncionarioService funcionarioService, IFornecedoraService fornecedoraService, IProdutoService produtoService,ISaidaService saida)
        {
            this.clienteService = clienteService;
            this.funcionarioService = funcionarioService;
            this.fornecedoraService = fornecedoraService;
            this.produtoService = produtoService;
            this.saidaService = saida;
            InitializeComponent();
        }
        private void TelaVenda_Load(object sender, EventArgs e)
        {
            cbProduto.DataSource = produtoService.GetAll().Result.Itens;
            cbProduto.DisplayMember = "Nome";
            cbProduto.ValueMember = "ID";
            cbFormaPag.DataSource = Enum.GetNames(typeof(FormaPagamento));
        }
        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            Produto produto = produtoService.GetById((Produto)cbProduto.SelectedValue).Result.Item;
            bool hasFound = false;
            if (produto != null)
            {
                produto.QtdEstoque = (int)nudQtd.Value;
                for (int i = 0; i < produtos.Count; i++)
                {
                    if (produto.ID == produtos[i].ID)
                    {
                        hasFound = true;
                        produtos[i].QtdEstoque += produto.QtdEstoque;
                        break;
                    }
                }
                if (!hasFound)
                {
                    produtos.Add(produto);
                    dtTelaVenda.Rows.Add();
                }
                double valor = 0;
                for (int i = 0; i < produtos.Count; i++)
                {
                    valor += Math.Round((produtos[i].QtdEstoque * produtos[i].Valor_Unitario), 2);
                    dtTelaVenda.Rows[i].Cells["IDVenda"].Value = produtos[i].ID;
                    dtTelaVenda.Rows[i].Cells["NomeVenda"].Value = produtos[i].Nome;
                    dtTelaVenda.Rows[i].Cells["QtdeVenda"].Value = produtos[i].QtdEstoque;
                    dtTelaVenda.Rows[i].Cells["ValorVenda"].Value = Math.Round(produtos[i].Valor_Unitario, 2);
                    dtTelaVenda.Rows[i].Cells["TotalVenda"].Value = Math.Round(produtos[i].QtdEstoque * produtos[i].Valor_Unitario, 2);

                }
                txtQtdItens.Text = produtos.Count.ToString();
                txtTotPag.Text = valor.ToString();
                txtValor.Text = valor.ToString();
            }
        }

        private void btnRetirarProduto_Click(object sender, EventArgs e)
        {
            if (dtTelaVenda.CurrentCell == null)
            {
                MessageBox.Show("Não é possivel retirar um produto não selecionado");
                return;
            }
            int rowindex = dtTelaVenda.CurrentCell.RowIndex;
            produtos.RemoveAt(rowindex);
            dtTelaVenda.Rows.RemoveAt(rowindex);
            double valor = 0;
            for (int i = 0; i < produtos.Count; i++)
            {
                dtTelaVenda.Rows[i].Cells["IDVenda"].Value = produtos[i].ID;
                dtTelaVenda.Rows[i].Cells["NomeVenda"].Value = produtos[i].Nome;
                dtTelaVenda.Rows[i].Cells["QtdeVenda"].Value = produtos[i].QtdEstoque;
                dtTelaVenda.Rows[i].Cells["ValorVenda"].Value = Math.Round(produtos[i].Valor_Unitario, 2);
                dtTelaVenda.Rows[i].Cells["TotalVenda"].Value = Math.Round(produtos[i].QtdEstoque * produtos[i].Valor_Unitario, 2);
                valor += (produtos[i].QtdEstoque * produtos[i].Valor_Unitario);
            }
            txtQtdItens.Text = produtos.Count.ToString();
            txtTotPag.Text = valor.ToString();
            txtValor.Text = valor.ToString();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            TelaCliente telaCliente = new(clienteService);
            telaCliente.ShowDialog();
        }

        private async void btnRegistrarVenda_Click(object sender, EventArgs e)
        {
            Cliente cliente = new();
            if (cliente != null && cliente.ID != 0)
            {
                if (produtos.Count != 0)
                {
                    List<ProdutoSaida> produtoSaidas = new();
                    double valor = 0;
                    for (int i = 0; i < produtos.Count; i++)
                    {
                        ProdutoSaida produtoSaida = new()
                        {
                            ProdutoId = produtos[i].ID,
                            Quantidade = produtos[i].QtdEstoque,
                            ValorUnitario = produtos[i].Valor_Unitario
                        };
                        produtoSaidas.Add(produtoSaida);
                        valor += Math.Round((produtos[i].QtdEstoque * produtos[i].Valor_Unitario), 2);
                    }
                    Saida saida = new();
                    saida.produtoSaidas = produtoSaidas;
                    saida.DataSaida = dateTelaVenda.Value;
                    saida.Valor = valor;
                    saida.FormaPagamento = (FormaPagamento)cbFormaPag.SelectedValue;
                    saida.Valor = valor;
                    saida.ClienteID = cliente.ID;
                    saida.FuncionarioID = FuncionarioLogin.id;
                    StringBuilder stringBuilder = new();
                    DataResponse<Produto> dataResponse = produtoService.CalculateInventory(produtos);
                    if (dataResponse.HasSuccess)
                    {
                        Response response = await saidaService.Insert(saida);
                        if (response.HasSuccess)
                        {
                            for (int i = 0; i < produtos.Count; i++)
                            {
                              await produtoService.UpdateValueAndInventory(dataResponse.Itens[i]);
                            }
                            dtTelaVenda.Rows.Clear();
                            produtos.Clear();
                            cliente = null;
                            txtQtdItens.Text = "";
                            txtTotPag.Text = "";
                            txtValor.Text = "";
                            txtCliente.Text = "";
                            txtCpf.Text = "";
                        }
                        MessageBox.Show(response.Message);
                    }
                    else
                    {
                        MessageBox.Show(dataResponse.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Não é possivel fazer a venda se não há Produtos");
                }
            }
            else
            {
                MessageBox.Show("Não é possivel fazer uma venda se não há Cliente");

            }
        }
    }
}
