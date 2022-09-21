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
        public TelaInicial()
        {
            InitializeComponent();
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
            OpenChildForm(new TelaCliente());
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TelaFuncionario());

        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TelaFornecedor());
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TelaProduto());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaLogin formLogin = new();
            formLogin.ShowDialog();
            this.Close();
        }
    }
}
