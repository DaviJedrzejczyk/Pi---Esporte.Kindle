using BusinessLogicalLayer.Interfaces;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPresentationLayer
{
    public partial class TelaEntrada : Form
    {
        private readonly IFornecedoraService fornecedoraService;
        private readonly IProdutoService produtoService;
        private readonly IEntradaService entradaService;
        private readonly ICategoriaService categoriaService;
        List<Produto> produtos = new();
        public TelaEntrada(IFornecedoraService fornecedoraService, IProdutoService produtoService, IEntradaService entrada, ICategoriaService categoriaService)
        {
            InitializeComponent();
            this.fornecedoraService = fornecedoraService;
            this.produtoService = produtoService;
            this.entradaService = entrada;
            this.categoriaService = categoriaService;
        }



        private void TelaEntrada_Load(object sender, EventArgs e)
        {
            cbFornecedor.DataSource = fornecedoraService.GetAll().Itens;
            cbFornecedor.DisplayMember = "Nome_Contato";
            cbFornecedor.ValueMember = "ID";
            cbProduto.DataSource = produtoService.GetAll().Result.Itens;
            cbProduto.DisplayMember = "Nome";
            cbProduto.ValueMember = "ID";
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            TelaFornecedor telaFornecedor = new(fornecedoraService);
            telaFornecedor.ShowDialog();
            cbFornecedor.DataSource = fornecedoraService.GetAll().Itens;
            cbFornecedor.DisplayMember = "Nome_Contato";
            cbFornecedor.ValueMember = "ID";

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            TelaProduto telaProduto = new(produtoService, fornecedoraService, categoriaService);
            telaProduto.ShowDialog();
            cbProduto.DataSource = produtoService.GetAll().Result.Itens;
            cbProduto.DisplayMember = "Nome";
            cbProduto.ValueMember = "ID";
        }
        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            Produto produto = produtoService.GetById(Convert.ToInt32(cbProduto.SelectedValue)).Result.Item;
            bool hasFound = false;
            if (produto != null)
            {
                produto.QtdEstoque = (int)nudQtd.Value;
                produto.Valor_Unitario = (double)nudValor.Value;
                for (int i = 0; i < produtos.Count; i++)
                {
                    if (produto.ID == produtos[i].ID)
                    {
                        hasFound = true;
                        produtos[i].QtdEstoque += produto.QtdEstoque;
                        if (produtos[i].Valor_Unitario != produto.Valor_Unitario)
                            produtos[i].Valor_Unitario = produtoService.CalculateNewValueWihtProducts(produtos[i], produto);
                        break;
                    }
                }
                if (!hasFound)
                {
                    produtos.Add(produto);
                    dtDataEntrada.Rows.Add();
                }
                double valor = 0;
                for (int i = 0; i < produtos.Count; i++)
                {
                    valor += Math.Round((produtos[i].QtdEstoque * produtos[i].Valor_Unitario), 2);
                    dtDataEntrada.Rows[i].Cells["EntradaID"].Value = produtos[i].ID;
                    dtDataEntrada.Rows[i].Cells["EntradaNome"].Value = produtos[i].Nome;
                    dtDataEntrada.Rows[i].Cells["EntradaQuantidade"].Value = produtos[i].QtdEstoque;
                    dtDataEntrada.Rows[i].Cells["EntradaValor"].Value = Math.Round(produtos[i].Valor_Unitario, 2);
                    dtDataEntrada.Rows[i].Cells["EntradaTotal"].Value = Math.Round(produtos[i].QtdEstoque * produtos[i].Valor_Unitario, 2);
                }
                txtNitens.Text = produtos.Count().ToString();
                txtTotalPago.Text = valor.ToString();
            }
        }

        private void btnDelProduto_Click(object sender, EventArgs e)
        {
            if (dtDataEntrada.CurrentCell == null)
            {
                MessageBox.Show("Você precisa selecionar uma célular para excluir");
                return;
            }
            int rowindex = dtDataEntrada.CurrentCell.RowIndex;
            produtos.RemoveAt(rowindex);
            double valor = 0;
            dtDataEntrada.Rows.RemoveAt(rowindex);
            for (int i = 0; i < produtos.Count; i++)
            {
                dtDataEntrada.Rows[i].Cells["EntradaID"].Value = produtos[i].ID;
                dtDataEntrada.Rows[i].Cells["EntradaNome"].Value = produtos[i].Nome;
                dtDataEntrada.Rows[i].Cells["EntradaQuantidade"].Value = produtos[i].QtdEstoque;
                dtDataEntrada.Rows[i].Cells["EntradaValor"].Value = Math.Round(produtos[i].Valor_Unitario, 2);
                dtDataEntrada.Rows[i].Cells["EntradaTotal"].Value = Math.Round(produtos[i].QtdEstoque * produtos[i].Valor_Unitario, 2);
                valor += produtos[i].Valor_Unitario * produtos[i].QtdEstoque;
            }
            txtNitens.Text = produtos.Count.ToString();
            txtTotalPago.Text = valor.ToString();
        }
        private async void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (cbFornecedor.SelectedIndex <= -1)
            {
                if (produtos.Count != 0)
                {
                    List<ProdutoEntrada> produtoEntradas = new();
                    double valor = 0;
                    for (int i = 0; i < produtos.Count; i++)
                    {
                        ProdutoEntrada produtoEntrada = new();
                        produtoEntrada.ProdutoId = produtos[i].ID;
                        produtoEntrada.Quantidade = produtos[i].QtdEstoque;
                        produtoEntrada.ValorUnitario = produtos[i].Valor_Unitario;
                        produtoEntradas.Add(produtoEntrada);
                        valor += produtos[i].QtdEstoque * produtos[i].Valor_Unitario;
                    }
                    Entrada entrada = new()
                    {
                        produtosEntradas = produtoEntradas,
                        DataEntrada = dtEntrada.Value,
                        Valor = valor,
                        Fornecedor = (Fornecedor)cbFornecedor.SelectedValue,
                        //Pegar o id do funcionario
                    };
                    List<Produto> produtosWithValueAndInventory = new();
                    for (int i = 0; i < produtos.Count; i++)
                    {
                        produtosWithValueAndInventory.Add(produtoService.GetById(produtos[i].ID).Result.Item);
                        produtosWithValueAndInventory[i].QtdEstoque = produtos[i].QtdEstoque;
                    }
                    DataResponse<Produto> dataResponse = await produtoService.CalculateNewValue(produtos);
                    Response response = await entradaService.Insert(entrada);
                    if (response.HasSuccess)
                    {
                        for (int i = 0; i < dataResponse.Itens.Count; i++)
                        {
                            produtosWithValueAndInventory[i].Valor_Unitario = Math.Round(dataResponse.Itens[i].Valor_Unitario, 2);
                            await produtoService.UpdateValueAndInventory(produtosWithValueAndInventory[i]);
                        }
                    }
                    MessageBox.Show(response.Message);
                    dtDataEntrada.Rows.Clear();
                    produtos.Clear();
                }
                else
                {
                    MessageBox.Show("Não foi possível registrar a entrada, pois não há produtos selecionados");
                }
            }
            else
            {
                MessageBox.Show("Não é possível registrar entrada se não há Fornecedor");
            }
        }
    }


}

