using BusinessLogicalLayer.Extensions;
using BusinessLogicalLayer.Interfaces;
using Entities;
using Entities.Enums;
using Shared;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace WFPresentationLayer
{
    public partial class TelaFuncionario : Form
    {
        private readonly IFuncionarioService funcionarioService;
        private readonly IEstadoService estadoService;
        private readonly IEnderecoService enderecoService;
        public TelaFuncionario(IFuncionarioService funcionario, IEstadoService estadoService, IEnderecoService enderecoService)
        {
            InitializeComponent();
            funcionarioService = funcionario;
            this.dtFuncionario.DoubleClick += dtFuncionario_DoubleClick;
            this.estadoService = estadoService;
            this.dtFuncionario.DefaultCellStyle.ForeColor = Color.Black;
            this.enderecoService = enderecoService;
        }

        
        private void TelaFuncionario_Load(object sender, EventArgs e)
        {
            
            cbGenero.DataSource = Enum.GetNames(typeof(Genero));
            cbNivelAcesso.DataSource = Enum.GetNames(typeof(TipoFuncionario));
            cbEstado.DataSource = estadoService.GetAll().Itens;
            cbEstado.DisplayMember = "Unidade_Federal";
            cbEstado.ValueMember = "ID";
            SincronizarGrid();
            StyleDatagridview();
        }

        private Funcionario CreateObjectWithForm()
        {
            DateTime.TryParse(mskDataNasc.Text, out DateTime dt);
            Genero.TryParse(cbGenero.Text, out Genero genero);
            TipoFuncionario.TryParse(cbNivelAcesso.Text, out TipoFuncionario tipo);
            int.TryParse(txtID.Text, out int temp);
            int.TryParse(txtEnderecoID.Text, out int tuc);
            Hash hash = new();
            string senha = hash.ComputeSha256Hash(txtSenha.Text);
            Funcionario funcionario = new()
            {
                ID = temp,
                Nome = txtNome.Text,
                Sobrenome = txtSobrenome.Text,
                CPF = mskdCPF.Text,
                Email = txtEmail.Text,
                RG = txtRG.Text,
                Genero = genero,
                DataNascimento = dt,
                Senha = senha,
                Nivel_Acesso = tipo,
                Telefone = mskTelefone.Text,

            };
            Endereco endereco = new()
            {
                ID = tuc,
                Rua = txtRua.Text,
                CEP = mskCEP.Text,
                Bairro = txtBairro.Text,
                Numero = txtNumero.Text,
                Cidade = txtCidade.Text,
                PontoReferencia = txtPonto.Text,
                Complemento = txtComplemento.Text,
                Estado = (Estado)cbEstado.SelectedItem,
            };
            funcionario.Endereco = endereco;
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
                dtFuncionario.Rows[i].Cells["FuncionarioEndereco"].Value = dataResponse.Itens[i].EnderecoId;
                dtFuncionario.Rows[i].Cells["FuncionarioNivelAcesso"].Value = dataResponse.Itens[i].Nivel_Acesso;
            }
        }

        private async void DrawFormWithObject(Funcionario funcionario)
        {
            this.txtID.Text = funcionario.ID.ToString();
            this.txtNome.Text = funcionario.Nome;
            this.txtSobrenome.Text = funcionario.Sobrenome;
            this.mskdCPF.Text = funcionario.CPF;
            this.txtRG.Text = funcionario.RG;
            this.txtEmail.Text = funcionario.Email;
            this.mskTelefone.Text = funcionario.Telefone;
            this.mskDataNasc.Text = funcionario.DataNascimento.ToString();
            this.cbGenero.Text = funcionario.Genero.ToString();
            this.cbNivelAcesso.Text = funcionario.Nivel_Acesso.ToString();
            SingleResponse<Endereco> singleResponse = await enderecoService.GetById(funcionario.EnderecoId);
            if (!singleResponse.HasSuccess)
            {
                MessageBox.Show(singleResponse.Message);
            }
            this.txtEnderecoID.Text = singleResponse.Item.ID.ToString();
            this.txtRua.Text = singleResponse.Item.Rua;
            this.txtBairro.Text = singleResponse.Item.Bairro;
            this.mskCEP.Text = singleResponse.Item.CEP;
            this.txtCidade.Text = singleResponse.Item.Cidade;
            this.txtComplemento.Text = singleResponse.Item.Complemento;
            this.txtNumero.Text = singleResponse.Item.Numero;
            this.txtPonto.Text = singleResponse.Item.PontoReferencia;


        }
        private void dtFuncionario_DoubleClick(object sender, EventArgs e)
        {
            int rowindex = dtFuncionario.CurrentCell.RowIndex;
            Funcionario funcionarioSelecionado = new()
            {
                ID = Convert.ToInt32(this.dtFuncionario.Rows[rowindex].Cells[0].Value),
                Nome = Convert.ToString(this.dtFuncionario.Rows[rowindex].Cells[1].Value),
                Sobrenome = Convert.ToString(this.dtFuncionario.Rows[rowindex].Cells[2].Value),
                CPF = Convert.ToString(this.dtFuncionario.Rows[rowindex].Cells[3].Value),
                RG = Convert.ToString(this.dtFuncionario.Rows[rowindex].Cells[4].Value),
                DataNascimento = Convert.ToDateTime(dtFuncionario.Rows[rowindex].Cells[5].Value),
                Idade = Convert.ToInt32(dtFuncionario.Rows[rowindex].Cells[6].Value),
                Email = Convert.ToString(dtFuncionario.Rows[rowindex].Cells[7].Value),
                Telefone = Convert.ToString(this.dtFuncionario.Rows[rowindex].Cells[8].Value),
                Genero = (Genero)this.dtFuncionario.Rows[rowindex].Cells[9].Value,
                Nivel_Acesso = (TipoFuncionario)this.dtFuncionario.Rows[rowindex].Cells[10].Value,
                EnderecoId = Convert.ToInt32(this.dtFuncionario.Rows[rowindex].Cells[11].Value)
            };
            DrawFormWithObject(funcionarioSelecionado);
        }

        private void LimparCampos()
        {
            mskdCPF.Clear();
            mskDataNasc.Clear();
            mskTelefone.Clear();
            txtNome.Clear();
            txtRG.Clear();
            txtSobrenome.Clear();
            txtEmail.Clear();
            txtRua.Clear();
            txtConfSenha.Clear();
            txtSenha.Clear();
            txtRua.Clear();
            txtPonto.Clear();
            txtBairro.Clear();
            mskCEP.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtEnderecoID.Clear();
            txtNumero.Clear();
        }

        void StyleDatagridview()
        {
            dtFuncionario.BorderStyle = BorderStyle.None;
            dtFuncionario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtFuncionario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtFuncionario.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dtFuncionario.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dtFuncionario.BackgroundColor = Color.FromArgb(30, 30, 30);
            dtFuncionario.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtFuncionario.EnableHeadersVisualStyles = false;
            dtFuncionario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtFuncionario.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dtFuncionario.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(37,37,38);
            dtFuncionario.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dtFuncionario.AutoSize = true;
        }

        private async void btnCadastrar_Click_1(object sender, EventArgs e)
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

        private async void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Funcionario funcionario = CreateObjectWithForm();
            Response response = funcionarioService.Update(funcionario);
            if (response.HasSuccess)
            {
                response = await enderecoService.Update(funcionario.Endereco);
                if (!response.HasSuccess)
                {
                    MessageBox.Show("Erro ao atualizar o endereço");
                }
                else
                {
                    MessageBox.Show("Sucesso");
                    SincronizarGrid();
                    LimparCampos();
                }
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private async void btnDelete_Click_1(object sender, EventArgs e)
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
