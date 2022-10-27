using BusinessLogicalLayer.Interfaces;
namespace WFPresentationLayer
{
    public partial class TelaInicial : Form
    {
        private Form currentChildForm;
        private readonly IClienteService cliente;
        private readonly IFuncionarioService funcionarioService;
        private readonly IProdutoService produtoService;
        private readonly IFornecedoraService fornecedoraService;
        private readonly IEstadoService estadoService;
        private readonly ICategoriaService categoriaService;
        private readonly ISaidaService saidaService;
        public TelaInicial(IClienteService clienteService, IFuncionarioService funcionarioService, IProdutoService produtoService, IFornecedoraService fornecedoraService, IEstadoService estadoService, ICategoriaService categoriaService,ISaidaService saida)
        {
            InitializeComponent();
            cliente = clienteService;
            this.produtoService = produtoService;
            this.fornecedoraService = fornecedoraService;
            this.estadoService = estadoService;
            this.funcionarioService = funcionarioService;
            this.categoriaService = categoriaService;
            this.saidaService = saida;
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TelaCliente(cliente));
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TelaFuncionario(funcionarioService, estadoService));
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TelaFornecedor(fornecedoraService));
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TelaProduto(produtoService, fornecedoraService,categoriaService));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaLogin telaLogin = new(funcionarioService, cliente, produtoService, fornecedoraService,estadoService,categoriaService,saidaService);
            telaLogin.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TelaHome());
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TelaCategoria(categoriaService));
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TelaVenda(cliente, funcionarioService, fornecedoraService,produtoService, saidaService));
        }
    }
}
