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
            StyleDatagridview();
        }
        private void DrawFormWithObject(Fornecedor fornecedor)
        {
            this.txtID.Text = fornecedor.ID.ToString();
            this.txtRazao.Text = fornecedor.Razao_Social;
            this.txtNome.Text = fornecedor.Nome_Contato;
            this.mskCNPJ.Text = fornecedor.Cnpj;
            this.txtEmail.Text = fornecedor.Email;
            this.mskTelefone.Text = fornecedor.Telefone;

        }
        private Fornecedor CreateObjectWithForm()
        {
            int.TryParse(txtID.Text, out int temp);
            Fornecedor f = new()
            {
                ID = temp,
                Cnpj = mskCNPJ.Text,
                Razao_Social = txtRazao.Text,
                Nome_Contato = txtNome.Text,
                Telefone = mskTelefone.Text,
                Email = txtEmail.Text,
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
            };
            DrawFormWithObject(fornecedorSelecionado);
        }
        private void LimparCampos()
        {
            mskCNPJ.Clear();
            mskTelefone.Clear();
            txtNome.Clear();
            txtID.Clear();
            txtEmail.Clear();
            txtRazao.Clear();
        }

        void StyleDatagridview()
        {
            dtFornecedor.BorderStyle = BorderStyle.None;
            dtFornecedor.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtFornecedor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtFornecedor.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dtFornecedor.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dtFornecedor.BackgroundColor = Color.FromArgb(30, 30, 30);
            dtFornecedor.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtFornecedor.EnableHeadersVisualStyles = false;
            dtFornecedor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtFornecedor.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI", 12);
            dtFornecedor.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 37, 38);
            dtFornecedor.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dtFornecedor.AutoSize = true;
        }

        private async void btnCadastrar_Click_1(object sender, EventArgs e)
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

        private async void btnUpdate_Click_1(object sender, EventArgs e)
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

        private async void btnDelete_Click_1(object sender, EventArgs e)
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
    }
}
