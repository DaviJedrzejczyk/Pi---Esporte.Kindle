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
        private readonly ISaidaService saidaService;
        private readonly IEnderecoService endereco;
        private readonly IEntradaService entrada;
        public TelaLogin(IFuncionarioService fu, IClienteService clienteService, IProdutoService produtoService, IFornecedoraService fornecedoraService, IEstadoService estadoService, ICategoriaService categoriaService, ISaidaService saidaService, IEnderecoService endereco, IEntradaService entrada)
        {
            InitializeComponent();
            funcionarioService = fu;
            this.clienteService = clienteService;
            this.produtoService = produtoService;
            this.fornecedoraService = fornecedoraService;
            this.estadoService = estadoService;
            this.categoriaService = categoriaService;
            this.saidaService = saidaService;
            this.endereco = endereco;
            this.entrada = entrada;
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            Funcionario login = new(txtEmail.Text, txtSenha.Text);
            SingleResponse<Funcionario> singleResponse = await funcionarioService.GetLogin(login);
            if (singleResponse.HasSuccess)
            {
                FuncionarioLogin.id = singleResponse.Item.ID;
                FuncionarioLogin.nome = singleResponse.Item.Nome;
                this.Hide();
                TelaInicial tela = new(clienteService, funcionarioService, produtoService, fornecedoraService, estadoService, categoriaService,saidaService,endereco, entrada);
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