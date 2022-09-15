using BusinessLogicalLayer.BLL;
using BusinessLogicalLayer.Interfaces;
using Entities;
using Entities.Enums;
using Ninject;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WFPresentationLayer
{
    public partial class TelaCliente : Form
    {
        private readonly IClienteService _cliente;
        public TelaCliente(IClienteService service)
        {
            InitializeComponent();
            _cliente = service;
            this.dtCliente.DoubleClick += dtCliente_DoubleClick;
        }



        private void TelaCliente_Load(object sender, EventArgs e)
        {
            SincronizarGrid();
            cbGenero.DataSource = Enum.GetNames(typeof(Genero));
        }

        private Cliente CreateObjectWithForm()
        {
            int temp;
            DateTime dt;
            Genero genero;
            DateTime.TryParse(txtDataNasc.Text, out dt);
            Genero.TryParse(cbGenero.Text, out genero);
            int.TryParse(txtID.Text, out temp);
            Cliente c = new()
            {
                ID = temp,
                Nome = txtNome.Text,
                Sobrenome = txtSobrenome.Text,
                CPF = mskdCPF.Text,
                Telefone = txtTelefone.Text,
                Email = txtEmail.Text,
                RG = txtRG.Text,
                Genero = genero,
                DataNascimento = dt,
            };
            return c;
        }
        private void SincronizarGrid()
        {
            dtCliente.DataSource = null;
            DataResponse<Cliente> dataResponse = _cliente.GetAll();
            dtCliente.Rows.Clear();
            for (int i = 0; i < dataResponse.Itens.Count; i++)
            {
                dtCliente.Rows.Add();
                dtCliente.Rows[i].Cells["ClienteID"].Value = dataResponse.Itens[i].ID;
                dtCliente.Rows[i].Cells["ClienteNome"].Value = dataResponse.Itens[i].Nome;
                dtCliente.Rows[i].Cells["ClienteSobrenome"].Value = dataResponse.Itens[i].Sobrenome;
                dtCliente.Rows[i].Cells["ClienteCPF"].Value = dataResponse.Itens[i].CPF;
                dtCliente.Rows[i].Cells["ClienteRG"].Value = dataResponse.Itens[i].RG;
                dtCliente.Rows[i].Cells["ClienteData"].Value = dataResponse.Itens[i].DataNascimento;
                dtCliente.Rows[i].Cells["ClienteIdade"].Value = dataResponse.Itens[i].Idade;
                dtCliente.Rows[i].Cells["ClienteEmail"].Value = dataResponse.Itens[i].Email;
                dtCliente.Rows[i].Cells["ClienteTelefone"].Value = dataResponse.Itens[i].Telefone;
                dtCliente.Rows[i].Cells["ClienteGenero"].Value = dataResponse.Itens[i].Genero;
            }
        }
        private void DrawFormWithObject(Cliente cliente)
        {
            this.txtID.Text = cliente.ID.ToString();
            this.txtNome.Text = cliente.Nome;
            this.txtSobrenome.Text = cliente.Sobrenome;
            this.mskdCPF.Text = cliente.CPF;
            this.txtRG.Text = cliente.RG;
            this.txtEmail.Text = cliente.Email;
            this.txtIdade.Text = cliente.Idade.ToString();
            this.txtTelefone.Text = cliente.Telefone;
            this.txtDataNasc.Text = cliente.DataNascimento.ToString();
            this.cbGenero.Text = cliente.Genero.ToString();

        }
        private void dtCliente_DoubleClick(object sender, EventArgs e)
        {
            int rowindex = dtCliente.CurrentCell.RowIndex;
            Cliente clienteSelecionado = new();
            clienteSelecionado.ID = Convert.ToInt32(this.dtCliente.Rows[rowindex].Cells[0].Value);
            clienteSelecionado.Nome = Convert.ToString(this.dtCliente.Rows[rowindex].Cells[1].Value);
            clienteSelecionado.Sobrenome = Convert.ToString(this.dtCliente.Rows[rowindex].Cells[2].Value);
            clienteSelecionado.CPF = Convert.ToString(this.dtCliente.Rows[rowindex].Cells[3].Value);
            clienteSelecionado.RG = Convert.ToString(this.dtCliente.Rows[rowindex].Cells[4].Value);
            clienteSelecionado.Email = Convert.ToString(dtCliente.Rows[rowindex].Cells[5].Value);
            clienteSelecionado.Idade = Convert.ToInt32(dtCliente.Rows[rowindex].Cells[6].Value);
            clienteSelecionado.DataNascimento = Convert.ToDateTime(dtCliente.Rows[rowindex].Cells[7].Value);
            clienteSelecionado.Telefone = Convert.ToString(this.dtCliente.Rows[rowindex].Cells[8].Value);
            clienteSelecionado.Genero = (Genero)this.dtCliente.Rows[rowindex].Cells[9].Value;
            DrawFormWithObject(clienteSelecionado);

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = CreateObjectWithForm();
            Response response = _cliente.Insert(cliente);
            if (response.HasSuccess)
            {
                MessageBox.Show("Sucesso");
                SincronizarGrid();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Falha");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Cliente cliente = CreateObjectWithForm();
            Response response = _cliente.Update(cliente);
            if (response.HasSuccess)
            {
                MessageBox.Show("sucesso");
                SincronizarGrid();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Falha");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Cliente cliente = CreateObjectWithForm();
            Response response = _cliente.Delete(cliente.ID);
            if (response.HasSuccess)
            {
                MessageBox.Show("Sucesso");
                SincronizarGrid();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Falha");
            }

        }
        private void LimparCampos()
        {
            mskdCPF.Clear();
            txtDataNasc.Clear();
            txtTelefone.Clear();
            txtIdade.Clear();
            txtNome.Clear();
            txtRG.Clear();
            txtSobrenome.Clear();
            txtID.Clear();
            txtEmail.Clear();
        }
    }
}
