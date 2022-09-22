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
        public TelaInicial()
        {
            InitializeComponent();
        }
        public TelaInicial(IClienteService clienteService, IFuncionarioService funcionarioService, IProdutoService produtoService, IFornecedoraService fornecedoraService)
        {
            InitializeComponent();
            cliente = clienteService;
            this.funcionarioService = funcionarioService;
            this.produtoService = produtoService;
            this.fornecedoraService = fornecedoraService;
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
            OpenChildForm(new TelaFuncionario(funcionarioService));
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TelaFornecedor(fornecedoraService));
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TelaProduto(produtoService,fornecedoraService));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaLogin telaLogin = new(funcionarioService, cliente, produtoService, fornecedoraService);
            telaLogin.ShowDialog();
            this.Close();
        }
    }
}
