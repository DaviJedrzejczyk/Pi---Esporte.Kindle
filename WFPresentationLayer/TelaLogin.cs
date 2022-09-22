using BusinessLogicalLayer.Interfaces;
using Entities;
using Ninject;
using Shared;

namespace WFPresentationLayer
{
    public partial class TelaLogin : Form
    {
        private readonly IFuncionarioService funcionarioService;
        private readonly IClienteService clienteService;
        private readonly IProdutoService produtoService;
        private readonly IFornecedoraService fornecedoraService;
        public TelaLogin()
        {
            InitializeComponent();
        }
        public TelaLogin(IFuncionarioService fu, IClienteService clienteService, IProdutoService produtoService, IFornecedoraService fornecedoraService)
        {
            InitializeComponent();
            funcionarioService = fu;
            this.clienteService = clienteService;
            this.produtoService = produtoService;
            this.fornecedoraService = fornecedoraService;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Funcionario login = new(txtEmail.Text, txtSenha.Text);
            SingleResponse<Funcionario> singleResponse = await funcionarioService.GetLogin(login);
            if (singleResponse.HasSuccess)
            {
                this.Hide();
                TelaInicial tela = new(clienteService,funcionarioService,produtoService,fornecedoraService);
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