using BusinessLogicalLayer.Interfaces;
using Entities;
using Shared;
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
    public partial class TelaHistoricos : Form
    {
        private readonly ISaidaService saidaService;
        private readonly IEntradaService entradaService;
        private Form currentChildForm;
        public TelaHistoricos(ISaidaService saida, IEntradaService entrada)
        {
            this.saidaService = saida;
            this.entradaService = entrada;
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
            panelDesktopSaida.Controls.Add(childForm);
            panelDesktopSaida.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private async void TelaHistóricos_Load(object sender, EventArgs e)
        {
            DataResponse<SaidaView> dataResponse = await saidaService.GetAll();
            if (dataResponse.Itens == null)
            {
                string message = "Não há registros de saída, deseja sair?";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    OpenChildForm(new TelaHome());
                    return;
                }
                return;
            }
            for (int i = 0; i < dataResponse.Itens.Count; i++)
            {
                dtHistoricoSaida.Rows.Add();
                dtHistoricoSaida.Rows[i].Cells["dtID"].Value = dataResponse.Itens[i].ID;
                dtHistoricoSaida.Rows[i].Cells["dtCliente"].Value = dataResponse.Itens[i].Cliente;
                dtHistoricoSaida.Rows[i].Cells["dtFuncionario"].Value = dataResponse.Itens[i].Funcionario;
                dtHistoricoSaida.Rows[i].Cells["dtData"].Value = dataResponse.Itens[i].DataSaida;
                dtHistoricoSaida.Rows[i].Cells["dtFormaPag"].Value = dataResponse.Itens[i].FormaPagamento;
                dtHistoricoSaida.Rows[i].Cells["dtValorTotal"].Value = dataResponse.Itens[i].ValorTotal;
            }
         
        }

        private async void tbEntrada_Click(object sender, EventArgs e)
        {
            DataResponse<EntradaView> data = await entradaService.GetAll();
            if (data.Itens == null)
            {
                string message = "Não há registros de entrada, deseja sair?";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    OpenChildForm(new TelaHome());
                    return;
                }
                return;
            }
            for (int i = 0; i < data.Itens.Count; i++)
            {
                
            }
        }

        private void btnInformacoes_Click(object sender, EventArgs e)
        {
            if (dtHistoricoSaida.CurrentCell == null)
            {
                MessageBox.Show("Não é possivel ver as informações adicionais de uma Saída não selecionada");
                return;
            }
            string message = "Você realmente  ver as informações adicionais desta Saida?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int rowindex = dtHistoricoSaida.CurrentCell.RowIndex;
                int index = Convert.ToInt32(dtHistoricoSaida.Rows[rowindex].Cells[0].Value);
                btnInformacoes.Enabled = false;
                btnInformacoes.Visible = false;
                tbVendas.BringToFront();
                OpenChildForm(new TelaInformacoesAdicionaisSaida(saidaService, saidaService.GetSaidaViewById(index).Item));
            }
        }

        private async void btnTabelas_Click(object sender, EventArgs e)
        {
            btnInformacoes.Enabled = true;
            btnInformacoes.Visible = true;
            if (currentChildForm != null)
            {
                panelButtos.SendToBack();
                currentChildForm.Close();
                dtHistoricoSaida.Rows.Clear();
                DataResponse<SaidaView> dataResponse = await saidaService.GetAll();
                for (int i = 0; i < dataResponse.Itens.Count; i++)
                {
                    dtHistoricoSaida.Rows.Add();
                    dtHistoricoSaida.Rows[i].Cells["dtID"].Value = dataResponse.Itens[i].ID;
                    dtHistoricoSaida.Rows[i].Cells["dtCliente"].Value = dataResponse.Itens[i].Cliente;
                    dtHistoricoSaida.Rows[i].Cells["dtFuncionario"].Value = dataResponse.Itens[i].Funcionario;
                    dtHistoricoSaida.Rows[i].Cells["dtData"].Value = dataResponse.Itens[i].DataSaida;
                    dtHistoricoSaida.Rows[i].Cells["dtFormaPag"].Value = dataResponse.Itens[i].FormaPagamento;
                    dtHistoricoSaida.Rows[i].Cells["dtValorTotal"].Value = dataResponse.Itens[i].ValorTotal;
                }
            }
        }
    }
}
