using BusinessLogicalLayer.BLL;
using BusinessLogicalLayer.Interfaces;
using DataAccessLayer.Implements;
using Entities;
using Entities.Filters;
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

        private void OpenChildFormSaida(Form childForm)
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
        private void OpenChildFormEntrada(Form childForm)
        {
                if (currentChildForm != null)
                {
                    currentChildForm.Close();
                }
                currentChildForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelDesktopEntrada.Controls.Add(childForm);
                panelDesktopEntrada.Tag = childForm;
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
                    OpenChildFormSaida(new TelaHome());
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
                    OpenChildFormSaida(new TelaHome());
                    return;
                }
                return;
            }
            for (int i = 0; i < data.Itens.Count; i++)
            {
                dtEntradas.Rows.Add();
                dtEntradas.Rows[i].Cells["IdEntrada"].Value = data.Itens[i].ID;
                dtEntradas.Rows[i].Cells["FornecedorEntrada"].Value = data.Itens[i].Fornecedor;
                dtEntradas.Rows[i].Cells["FuncionarioEntrada"].Value = data.Itens[i].Funcionario;
                dtEntradas.Rows[i].Cells["DataEntrada"].Value = data.Itens[i].DataEntrada;
                dtEntradas.Rows[i].Cells["ValorEntrada"].Value = data.Itens[i].Valor;
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
                OpenChildFormSaida(new TelaInformacoesAdicionaisSaida(saidaService, saidaService.GetSaidaViewById(index).Item));
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

        private async void btnTabelaEntrada_Click(object sender, EventArgs e)
        {
            btnInfoEntrada.Enabled = true;
            btnInfoEntrada.Visible = true;
            if (currentChildForm != null)
            {
                panelDesktopEntrada.SendToBack();
                currentChildForm.Close();
                dtEntradas.Rows.Clear();
                DataResponse<EntradaView> dataResponse = await entradaService.GetAll();
                for (int i = 0; i < dataResponse.Itens.Count; i++)
                {
                    dtEntradas.Rows.Add();
                    dtEntradas.Rows[i].Cells["IdEntrada"].Value = dataResponse.Itens[i].ID;
                    dtEntradas.Rows[i].Cells["FornecedorEntrada"].Value = dataResponse.Itens[i].Fornecedor;
                    dtEntradas.Rows[i].Cells["FuncionarioEntrada"].Value = dataResponse.Itens[i].Funcionario;
                    dtEntradas.Rows[i].Cells["DataEntrada"].Value = dataResponse.Itens[i].DataEntrada;
                    dtEntradas.Rows[i].Cells["ValorEntrada"].Value = dataResponse.Itens[i].Valor;
                }
            }
        }

        private void btnInfoEntrada_Click(object sender, EventArgs e)
        {
            if (dtEntradas.CurrentCell == null)
            {
                MessageBox.Show("Não é possivel ver as informações adicionais de uma Entrada não selecionada");
                return;
            }
            string message = "Você realmente  ver as informações adicionais desta Entrada?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int rowindex = dtEntradas.CurrentCell.RowIndex;
                int index = Convert.ToInt32(dtEntradas.Rows[rowindex].Cells[0].Value);
                btnInfoEntrada.Enabled = false;
                btnInfoEntrada.Visible = false;
                panelDesktopEntrada.BringToFront();
                OpenChildFormEntrada(new TelaInformacoesAdicionaisEntrada(entradaService.GetById(index).Result.Item, entradaService));
            }
        }

        private async void btnFilter_Click(object sender, EventArgs e)
        {
            dtEntradas.Rows.Clear();
            FilterEntrada filtersEntrada = new()
            {
                Inicio = dateEntrada.Value,
                Fim = dateSaida.Value
            };
            SingleResponse<List<EntradaView>> singleResponseFilterEntrada = await entradaService.GetByDate(filtersEntrada);
            for (int i = 0; i < singleResponseFilterEntrada.Item.Count; i++)
            {
                dtEntradas.Rows.Add();
                dtEntradas.Rows[i].Cells["IdEntrada"].Value = singleResponseFilterEntrada.Item[i].ID;
                dtEntradas.Rows[i].Cells["FornecedorEntrada"].Value = singleResponseFilterEntrada.Item[i].Fornecedor;
                dtEntradas.Rows[i].Cells["FuncionarioEntrada"].Value = singleResponseFilterEntrada.Item[i].Funcionario;
                dtEntradas.Rows[i].Cells["DataEntrada"].Value = singleResponseFilterEntrada.Item[i].DataEntrada;
                dtEntradas.Rows[i].Cells["ValorEntrada"].Value = singleResponseFilterEntrada.Item[i].Valor;
            }

        }
    }
}
