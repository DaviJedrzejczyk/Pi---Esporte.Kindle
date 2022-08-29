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

namespace WFPresentationLayer
{
    public partial class TelaFuncionario : Form
    {
        private readonly IFuncionarioService funcionarioService;
        private readonly ITipoFuncionarioService tipoFuncionarioService;
        public TelaFuncionario(IFuncionarioService service, ITipoFuncionarioService tipoFuncionarioService)
        {
            InitializeComponent();
            funcionarioService = service;
            this.dtFuncionario.DoubleClick += dtFuncionario_DoubleClick;
            this.tipoFuncionarioService = tipoFuncionarioService;
        }



        private void TelaFuncionario_Load(object sender, EventArgs e)
        {
            SincronizarGrid();
            cbGenero.DataSource = Enum.GetNames(typeof(Genero));
            cbNivelAcesso.DataSource = tipoFuncionarioService.GetAllTipo().Result.Itens;
            cbNivelAcesso.DisplayMember = "Nome";
            cbNivelAcesso.ValueMember = "ID";
        }

        private Funcionario CreateObjectWithForm()
        {
            int temp;
            DateTime dt;
            Genero genero;
            DateTime.TryParse(txtData.Text, out dt);
            Genero.TryParse(cbGenero.Text, out genero);
            int.TryParse(txtID.Text, out temp);
            Funcionario funcionario = new()
            {
                ID = temp,
                Nome = txtNome.Text,
                Sobrenome = txtSobrenome.Text,
                CPF = txtCPF.Text,
                Email = txtEmail.Text,
                RG = txtRG.Text,
                Genero = genero,
                DataNascimento = dt,
                Senha = txtSenha.Text,
                Nivel_Acesso = (TipoFuncionario)cbNivelAcesso.SelectedValue,
                Telefone = txtTelefone.Text,
                EnderecoId = Convert.ToInt32(txtEndereco.Text),
            };
            return funcionario;
        }
        private async void SincronizarGrid()
        {
            dtFuncionario.DataSource = null;
            DataResponse<Funcionario> dataResponse = await funcionarioService.GetAll();
            dtFuncionario.Rows.Clear();
            for (int i = 0; i < dataResponse.Itens.Count; i++)
            {
                dtFuncionario.Rows.Add();
                dtFuncionario.Rows[i].Cells["FuncionarioID"].Value = dataResponse.Itens[i].ID;
                dtFuncionario.Rows[i].Cells["FuncionarioNome"].Value = dataResponse.Itens[i].Nome;
                dtFuncionario.Rows[i].Cells["FuncionarioSobrenome"].Value = dataResponse.Itens[i].Sobrenome;
                dtFuncionario.Rows[i].Cells["FuncionarioCPF"].Value = dataResponse.Itens[i].CPF;
                dtFuncionario.Rows[i].Cells["FuncionarioRG"].Value = dataResponse.Itens[i].RG;
                dtFuncionario.Rows[i].Cells["FuncionarioData"].Value = dataResponse.Itens[i].DataNascimento;
                dtFuncionario.Rows[i].Cells["FuncionarioIdade"].Value = dataResponse.Itens[i].Idade;
                dtFuncionario.Rows[i].Cells["FuncionarioEmail"].Value = dataResponse.Itens[i].Email;
                dtFuncionario.Rows[i].Cells["FuncionarioTelefone"].Value = dataResponse.Itens[i].Telefone;
                dtFuncionario.Rows[i].Cells["FuncionarioGenero"].Value = dataResponse.Itens[i].Genero;
                dtFuncionario.Rows[i].Cells["FuncionarioEndereco"].Value = dataResponse.Itens[i].Endereco.ID;
                dtFuncionario.Rows[i].Cells["FuncionarioNivelAcesso"].Value = dataResponse.Itens[i].Nivel_Acesso.NivelAcesso;
            }
        }

        private void DrawFormWithObject(Funcionario funcionario)
        {
            this.txtID.Text = funcionario.ID.ToString();
            this.txtNome.Text = funcionario.Nome;
            this.txtSobrenome.Text = funcionario.Sobrenome;
            this.txtCPF.Text = funcionario.CPF;
            this.txtRG.Text = funcionario.RG;
            this.txtEmail.Text = funcionario.Email;
            this.txtIdade.Text = funcionario.Idade.ToString();
            this.txtTelefone.Text = funcionario.Telefone;
            this.txtData.Text = funcionario.DataNascimento.ToString();
            this.cbGenero.Text = funcionario.Genero.ToString();
            this.cbNivelAcesso.Text = funcionario.Nivel_Acesso.NivelAcesso;
            this.txtEndereco.Text = funcionario.Endereco.ID.ToString();

        }
        private void dtFuncionario_DoubleClick(object sender, EventArgs e)
        {
            int rowindex = dtFuncionario.CurrentCell.RowIndex;
            Funcionario funcionarioSelecionado = new();
            funcionarioSelecionado.ID = Convert.ToInt32(this.dtFuncionario.Rows[rowindex].Cells[0].Value);
            funcionarioSelecionado.Nome = Convert.ToString(this.dtFuncionario.Rows[rowindex].Cells[1].Value);
            funcionarioSelecionado.Sobrenome = Convert.ToString(this.dtFuncionario.Rows[rowindex].Cells[2].Value);
            funcionarioSelecionado.CPF = Convert.ToString(this.dtFuncionario.Rows[rowindex].Cells[3].Value);
            funcionarioSelecionado.RG = Convert.ToString(this.dtFuncionario.Rows[rowindex].Cells[4].Value);
            funcionarioSelecionado.DataNascimento = Convert.ToDateTime(dtFuncionario.Rows[rowindex].Cells[5].Value);
            funcionarioSelecionado.Idade = Convert.ToInt32(dtFuncionario.Rows[rowindex].Cells[6].Value);
            funcionarioSelecionado.Email = Convert.ToString(dtFuncionario.Rows[rowindex].Cells[7].Value);
            funcionarioSelecionado.Telefone = Convert.ToString(this.dtFuncionario.Rows[rowindex].Cells[8].Value);
            funcionarioSelecionado.Genero = (Genero)this.dtFuncionario.Rows[rowindex].Cells[9].Value;
            funcionarioSelecionado.Nivel_Acesso = (TipoFuncionario)this.dtFuncionario.Rows[rowindex].Cells[10].Value;
            funcionarioSelecionado.Endereco.ID = Convert.ToInt32(this.dtFuncionario.Rows[rowindex].Cells[11].Value);
            DrawFormWithObject(funcionarioSelecionado);
        }

        private void LimparCampos()
        {
            txtCPF.Clear();
            txtData.Clear();
            txtTelefone.Clear();
            txtIdade.Clear();
            txtNome.Clear();
            txtRG.Clear();
            txtSobrenome.Clear();
            txtID.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtConfSenha.Clear();
            txtSenha.Clear();
        }



        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = CreateObjectWithForm();
            Response response = await funcionarioService.Insert(funcionario);
            if (response.HasSuccess)
            {
                MessageBox.Show("Sucesso");
                SincronizarGrid();
                LimparCampos();
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = CreateObjectWithForm();
            Response response = await funcionarioService.Update(funcionario);
            if (response.HasSuccess)
            {
                MessageBox.Show("Sucesso");
                SincronizarGrid();
                LimparCampos();
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = CreateObjectWithForm();
            Response response = await funcionarioService.Delete(funcionario);
            if (response.HasSuccess)
            {
                MessageBox.Show("Sucesso");
                SincronizarGrid();
                LimparCampos();
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        
    }
}
