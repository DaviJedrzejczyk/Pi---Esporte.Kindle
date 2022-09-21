using BusinessLogicalLayer.Interfaces;
using Entities.Enums;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared;
using Ninject;

namespace WFPresentationLayer
{
    public partial class TelaProduto : Form
    {
        private readonly IProdutoService produtoBLL;
        private readonly IFornecedoraService fornecedoraService;
        [Inject()]
        public TelaProduto(IProdutoService produto, IFornecedoraService fornecedoraService)
        {
            InitializeComponent();
            produtoBLL = produto;
            this.fornecedoraService = fornecedoraService;
            this.dtProduto.DoubleClick += dataGridView1_DoubleClick;

        }
        public TelaProduto()
        {
            InitializeComponent();
        }
        private void TelaProduto_Load(object sender, EventArgs e)
        {
            SincronizarGrid();
            cbFornecedora.DataSource = fornecedoraService.GetAll().Result.Itens;
            cbFornecedora.DisplayMember = "Nome_Contato";
            cbFornecedora.ValueMember = "ID";
        }

        private Produto CreateObjectWithForm()
        {
            int temp;
            double valor;
            int qtd;
            int.TryParse(txtID.Text, out temp);
            int.TryParse(txtQtdEstoque.Text, out qtd);
            double.TryParse(txtValor.Text, out valor);
            Produto c = new()
            {
                ID = temp,
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                QtdEstoque = qtd,
                Valor_Unitario = valor,
                
            };
            return c;
        }
        private async void SincronizarGrid()
        {
            dtProduto.DataSource = null;
            DataResponse<Produto> dataResponse = await produtoBLL.GetAll();
            dtProduto.Rows.Clear();
            for (int i = 0; i < dataResponse.Itens.Count; i++)
            {
                dtProduto.Rows.Add();
                dtProduto.Rows[i].Cells["ProdutoID"].Value = dataResponse.Itens[i].ID;
                dtProduto.Rows[i].Cells["ProdutoNome"].Value = dataResponse.Itens[i].Nome;
                dtProduto.Rows[i].Cells["ProdutoDescricao"].Value = dataResponse.Itens[i].Descricao;
                dtProduto.Rows[i].Cells["ProdutoQtdEstoque"].Value = dataResponse.Itens[i].QtdEstoque;
                dtProduto.Rows[i].Cells["ProdutoValor"].Value = dataResponse.Itens[i].Valor_Unitario;
                dtProduto.Rows[i].Cells["ProdutoFornecedora"].Value = dataResponse.Itens[i].Fornecedor;
            }
        }
        private void DrawFormWithObject(Produto produto)
        {
            this.txtID.Text = produto.ID.ToString();
            this.txtNome.Text = produto.Nome;
            this.txtDescricao.Text = produto.Descricao;
            this.txtQtdEstoque.Text = produto.QtdEstoque.ToString();
            this.txtValor.Text = produto.Valor_Unitario.ToString();
            this.cbFornecedora.Text = produto.Fornecedor.ToString();

        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int rowindex = dtProduto.CurrentCell.RowIndex;
            Produto produtoSelecionado = new();
            produtoSelecionado.ID = Convert.ToInt32(this.dtProduto.Rows[rowindex].Cells[0].Value);
            produtoSelecionado.Nome = Convert.ToString(this.dtProduto.Rows[rowindex].Cells[1].Value);
            produtoSelecionado.Descricao = Convert.ToString(this.dtProduto.Rows[rowindex].Cells[2].Value);
            produtoSelecionado.Fornecedor = (Fornecedor)this.dtProduto.Rows[rowindex].Cells[3].Value;
            produtoSelecionado.QtdEstoque = Convert.ToInt32(this.dtProduto.Rows[rowindex].Cells[4].Value);
            produtoSelecionado.Valor_Unitario = Convert.ToDouble(dtProduto.Rows[rowindex].Cells[5].Value);
            DrawFormWithObject(produtoSelecionado);
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produto produto = CreateObjectWithForm();
            Response response = await produtoBLL.Insert(produto);
            if (response.HasSuccess)
            {
                MessageBox.Show("Sucesso");
                SincronizarGrid();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            Produto produto = CreateObjectWithForm();
            Response response = await produtoBLL.Update(produto);
            if (response.HasSuccess)
            {
                MessageBox.Show("Sucesso");
                SincronizarGrid();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            Produto produto = CreateObjectWithForm();
            Response response = await produtoBLL.Insert(produto);
            if (response.HasSuccess)
            {
                MessageBox.Show("Sucesso");
                SincronizarGrid();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }

        private void LimparCampos()
        {
            txtQtdEstoque.Clear();
            txtNome.Clear();
            txtValor.Clear();
            txtDescricao.Clear();
            txtID.Clear();
        }
    }
}
