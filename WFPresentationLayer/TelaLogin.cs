using BusinessLogicalLayer.BLL;
using BusinessLogicalLayer.Interfaces;
using Entities;
using Ninject;
using Shared;

namespace WFPresentationLayer
{
    public partial class TelaLogin : Form
    {
        private readonly IFuncionarioService funcionario;
        public TelaLogin(IFuncionarioService fu)
        {
            InitializeComponent();
            funcionario = fu;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Funcionario login = new(txtEmail.Text, txtSenha.Text);
            SingleResponse<int> singleResponse = await funcionario.GetLogin(login);
            if (singleResponse.HasSuccess)
            {
                MessageBox.Show("Logado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }
    }
}