using BusinessLogicalLayer.Interfaces;
using Entities;
using MaterialSkin;
using Ninject;
using Shared;
using MaterialSkin;

namespace WFPresentationLayer
{
    public partial class TelaLogin : Form
    {
        private readonly IFuncionarioService funcionario;
        public TelaLogin(IFuncionarioService fu)
        {
            InitializeComponent();
            funcionario = fu;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            TelaLogin telaLogin = this;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            
        }

        private async void btnlogin_Click(object sender, EventArgs e)
        {
            Funcionario login = new(txtEmail.Text, txtSenha.Text);
            SingleResponse<Funcionario> singleResponse = await funcionario.GetLogin(login);
            if (singleResponse.HasSuccess)
            {
                this.Hide();
                TelaInicial tela = new();
                tela.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }
    }
}