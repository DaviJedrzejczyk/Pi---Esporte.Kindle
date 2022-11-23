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
        private readonly ICategoriaService categoriaService;
        private Form currentChildForm;
        [Inject()]
        public TelaProduto(IProdutoService produto, IFornecedoraService fornecedoraService2, ICategoriaService categoriaService)
        {
            InitializeComponent();
            produtoBLL = produto;
            fornecedoraService = fornecedoraService2;
            this.categoriaService = categoriaService;
            this.dtProduto.DoubleClick += dataGridView1_DoubleClick;
            this.dtProduto.DefaultCellStyle.ForeColor = Color.Black;
          
        }
        private void TelaProduto_Load(object sender, EventArgs e)
        {
            cbFornecedora.DataSource = fornecedoraService.GetAll().Itens;
            cbFornecedora.DisplayMember = "Nome_Contato";
            cbFornecedora.ValueMember = "ID";
            cbCategoria.DataSource = categoriaService.GetAll().Itens;
            cbCategoria.DisplayMember = "Nome";
            cbCategoria.ValueMember = "Id";
            SincronizarGrid();
          
        }

        private Produto CreateObjectWithForm()
        {
            int.TryParse(txtID.Text, out int temp);
            int.TryParse(txtQtdEstoque.Text, out int qtd);
            double.TryParse(txtValor.Text, out double valor);
            Produto c = new()
            {
                ID = temp,
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                QtdEstoque = qtd,
                Valor_Unitario = valor,
                Fornecedor = (Fornecedor)cbFornecedora.SelectedItem,
                Categoria = (Categoria)cbCategoria.SelectedItem
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
                dtProduto.Rows[i].Cells["ProdutoValor"].Value = dataResponse.Itens[i].Valor_Unitario.ToString("C2");
                dtProduto.Rows[i].Cells["ProdutoFornecedora"].Value = dataResponse.Itens[i].Fornecedor.Nome_Contato;
                dtProduto.Rows[i].Cells["CatProduto"].Value = dataResponse.Itens[i].Categoria.Nome;
            }
        }
        private void DrawFormWithObject(Produto produto)
        {
            this.txtID.Text = produto.ID.ToString();
            this.txtNome.Text = produto.Nome;
            this.txtDescricao.Text = produto.Descricao;
            this.txtQtdEstoque.Text = produto.QtdEstoque.ToString();
            this.txtValor.Text = produto.Valor_Unitario.ToString("C2");
            this.cbFornecedora.Text = produto.Fornecedor.ID.ToString();

        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int rowindex = dtProduto.CurrentCell.RowIndex;
            Fornecedor fornecedor = new()
            {
                Nome_Contato = Convert.ToString(this.dtProduto.Rows[rowindex].Cells[3].Value)
            };
            Categoria categoria = new()
            {
                Nome = Convert.ToString(this.dtProduto.Rows[rowindex].Cells[3].Value),
            };
            Produto produtoSelecionado = new()
            {
                ID = Convert.ToInt32(this.dtProduto.Rows[rowindex].Cells[0].Value),
                Nome = Convert.ToString(this.dtProduto.Rows[rowindex].Cells[1].Value),
                Descricao = Convert.ToString(this.dtProduto.Rows[rowindex].Cells[2].Value),
                Fornecedor = fornecedor,
                Categoria = categoria,
                QtdEstoque = Convert.ToInt32(this.dtProduto.Rows[rowindex].Cells[5].Value),
                Valor_Unitario = Convert.ToDouble(dtProduto.Rows[rowindex].Cells[6].Value)
            };
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
            Response response = await produtoBLL.Delete(produto);
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
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            TelaCategoria telaCategoria = new(categoriaService);
            telaCategoria.ShowDialog();
        }
    }
}
