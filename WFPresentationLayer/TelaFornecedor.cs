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
    public partial class TelaFornecedor : Form
    {
        private readonly IFornecedoraService fornecedoraBLL;
        [Inject()]
        public TelaFornecedor(IFornecedoraService service)
        {
            InitializeComponent();
            fornecedoraBLL = service;
            this.dtFornecedor.DoubleClick += dtFornecedor_DoubleClick;
        }
        private void TelaFornecedor_Load(object sender, EventArgs e)
        {
            SincronizarGrid();
        }
        private void DrawFormWithObject(Fornecedor fornecedor)
        {
            this.txtID.Text = fornecedor.ID.ToString();
            this.txtRazao.Text = fornecedor.Razao_Social;
            this.txtNome.Text = fornecedor.Nome_Contato;
            this.txtCNPJ.Text = fornecedor.Cnpj;
            this.txtEmail.Text = fornecedor.Email;
            this.txtTelefone.Text = fornecedor.Telefone;
            this.ckIsAtivo.Checked = fornecedor.IsAtivo;

        }
        private Fornecedor CreateObjectWithForm()
        {
            int.TryParse(txtID.Text, out int temp);
            Fornecedor f = new()
            {
                ID = temp,
                Cnpj = txtCNPJ.Text,
                Razao_Social = txtRazao.Text,
                Nome_Contato = txtNome.Text,
                Telefone = txtTelefone.Text,
                Email = txtEmail.Text,
                IsAtivo = ckIsAtivo.Checked
            };
            return f;
        }

        private async void SincronizarGrid()
        {
            dtFornecedor.DataSource = null;
            DataResponse<Fornecedor> dataResponse = fornecedoraBLL.GetAll();
            dtFornecedor.Rows.Clear();
            for (int i = 0; i < dataResponse.Itens.Count; i++)
            {
                dtFornecedor.Rows.Add();
                dtFornecedor.Rows[i].Cells["ForneID"].Value = dataResponse.Itens[i].ID;
                dtFornecedor.Rows[i].Cells["ForneRazao"].Value = dataResponse.Itens[i].Razao_Social;
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
            Fornecedor fornecedorSelecionado = new()
            {
                ID = Convert.ToInt32(this.dtFornecedor.Rows[rowindex].Cells[0].Value),
                Razao_Social = Convert.ToString(this.dtFornecedor.Rows[rowindex].Cells[1].Value),
                Nome_Contato = Convert.ToString(this.dtFornecedor.Rows[rowindex].Cells[2].Value),
                Cnpj = Convert.ToString(this.dtFornecedor.Rows[rowindex].Cells[3].Value),
                Email = Convert.ToString(dtFornecedor.Rows[rowindex].Cells[4].Value),
                Telefone = Convert.ToString(this.dtFornecedor.Rows[rowindex].Cells[5].Value),
                IsAtivo = (bool)this.dtFornecedor.Rows[rowindex].Cells[6].Value
            };
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
            Response response = await fornecedoraBLL.Delete(fornecedor.ID);
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
