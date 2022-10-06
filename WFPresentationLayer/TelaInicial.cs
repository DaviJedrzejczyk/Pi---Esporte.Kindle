using BusinessLogicalLayer.Interfaces;
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
    public partial class TelaInicial : Form
    {
        private Form currentChildForm;
        private readonly IClienteService cliente;
        private readonly IFuncionarioService funcionarioService;
        private readonly IProdutoService produtoService;
        private readonly IFornecedoraService fornecedoraService;
        private readonly IEstadoService estadoService;
        private readonly ICategoriaService categoriaService;
        public TelaInicial(IClienteService clienteService, IFuncionarioService funcionarioService, IProdutoService produtoService, IFornecedoraService fornecedoraService, IEstadoService estadoService, ICategoriaService categoriaService)
        {
            InitializeComponent();
            cliente = clienteService;
            this.produtoService = produtoService;
            this.fornecedoraService = fornecedoraService;
            this.estadoService = estadoService;
            this.funcionarioService = funcionarioService;
            this.categoriaService = categoriaService;

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
            TelaLogin telaLogin = new(funcionarioService, cliente, produtoService, fornecedoraService,estadoService,categoriaService);
            telaLogin.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TelaHome());
        }
    }
}
