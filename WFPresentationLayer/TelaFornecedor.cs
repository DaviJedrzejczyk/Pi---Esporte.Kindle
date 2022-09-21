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

namespace WFPresentationLayer
{
    public partial class TelaFornecedor : Form
    {
        private readonly IFornecedoraService fornecedoraBLL;
        public TelaFornecedor(IFornecedoraService service)
        {
            InitializeComponent();
            fornecedoraBLL = service;
            this.dtFornecedor.DoubleClick += dtFornecedor_DoubleClick;

        }
        public TelaFornecedor()
        {
            InitializeComponent();
        }
        private void TelaFornecedor_Load(object sender, EventArgs e)
        {
            SincronizarGrid();
        }
        private void DrawFormWithObject(Fornecedor fornecedor)
        {
            this.txtID.Text = fornecedor.ID.ToString();
            this.txtNome.Text = fornecedor.Nome_Contato;
            this.txtCNPJ.Text = fornecedor.Cnpj;
            this.txtEmail.Text = fornecedor.Email;
            this.txtTelefone.Text = fornecedor.Telefone;
            this.ckIsAtivo.Checked = fornecedor.IsAtivo;

        }
        private Fornecedor CreateObjectWithForm()
        {
            int temp;
            int.TryParse(txtID.Text, out temp);
            Fornecedor f = new()
            {
                ID = temp,
                Cnpj = txtCNPJ.Text,
                Nome_Contato = txtNome.Text,
                Telefone = txtTelefone.Text,
                Email = txtEmail.Text,
                IsAtivo = ckIsAtivo.Checked,
            };
            return f;
        }

        private async void SincronizarGrid()
        {
            dtFornecedor.DataSource = null;
            DataResponse<Fornecedor> dataResponse = await fornecedoraBLL.GetAll();
            dtFornecedor.Rows.Clear();
            for (int i = 0; i < dataResponse.Itens.Count; i++)
            {
                dtFornecedor.Rows.Add();
                dtFornecedor.Rows[i].Cells["ForneID"].Value = dataResponse.Itens[i].ID;
                dtFornecedor.Rows[i].Cells["ForneNome"].Value = dataResponse.Itens[i].Nome_Contato;
                dtFornecedor.Rows[i].Cells["ForneCNPJ"].Value = dataResponse.Itens[i].Cnpj;
                dtFornecedor.Rows[i].Cells["ForneIsAtivo"].Value = dataResponse.Itens[i].IsAtivo;
                dtFornecedor.Rows[i].Cells["ForneEmail"].Value = dataResponse.Itens[i].Email;
                dtFornecedor.Rows[i].Cells["ForneTelefone"].Value = dataResponse.Itens[i].Telefone;
            }
        }

        private void dtFornecedor_DoubleClick(object sender, EventArgs e)
        {
            int rowindex = dtFornecedor.CurrentCell.RowIndex;
            Fornecedor fornecedorSelecionado = new();
            fornecedorSelecionado.ID = Convert.ToInt32(this.dtFornecedor.Rows[rowindex].Cells[0].Value);
            fornecedorSelecionado.Nome_Contato = Convert.ToString(this.dtFornecedor.Rows[rowindex].Cells[1].Value);
            fornecedorSelecionado.Cnpj = Convert.ToString(this.dtFornecedor.Rows[rowindex].Cells[2].Value);
            fornecedorSelecionado.Email = Convert.ToString(dtFornecedor.Rows[rowindex].Cells[3].Value);
            fornecedorSelecionado.Telefone = Convert.ToString(this.dtFornecedor.Rows[rowindex].Cells[4].Value);
            fornecedorSelecionado.IsAtivo = (bool)this.dtFornecedor.Rows[rowindex].Cells[5].Value;
            DrawFormWithObject(fornecedorSelecionado);
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = CreateObjectWithForm();
            Response response = await fornecedoraBLL.Insert(fornecedor);
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
            Fornecedor fornecedor = CreateObjectWithForm();
            Response response = await fornecedoraBLL.Update(fornecedor);
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
            Fornecedor fornecedor = CreateObjectWithForm();
            Response response = await fornecedoraBLL.Delete(fornecedor);
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
            txtCNPJ.Clear();
            txtTelefone.Clear();
            txtNome.Clear();
            txtID.Clear();
            txtEmail.Clear();
        }
    }
}
