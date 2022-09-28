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
        private readonly IEstadoService estadoService;
        private readonly ICategoriaService categoriaService;
        public TelaLogin(IFuncionarioService fu, IClienteService clienteService, IProdutoService produtoService, IFornecedoraService fornecedoraService, IEstadoService estadoService, ICategoriaService categoriaService)
        {
            InitializeComponent();
            funcionarioService = fu;
            this.clienteService = clienteService;
            this.produtoService = produtoService;
            this.fornecedoraService = fornecedoraService;
            this.estadoService = estadoService;
            this.categoriaService = categoriaService;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Funcionario login = new(txtEmail.Text, txtSenha.Text);
            SingleResponse<Funcionario> singleResponse = await funcionarioService.GetLogin(login);
            if (singleResponse.HasSuccess)
            {
                this.Hide();
                TelaInicial tela = new(clienteService,funcionarioService,produtoService,fornecedoraService,estadoService,categoriaService);
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