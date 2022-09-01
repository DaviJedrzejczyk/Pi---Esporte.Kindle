using BusinessLogicalLayer.Interfaces;
using Entities.Enums;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared;

namespace WFPresentationLayer
{
    public partial class TelaCategoria : Form
    {
        private readonly ICategoriaService _categoriaService;
        public TelaCategoria(ICategoriaService categoria)
        {
            InitializeComponent();
            _categoriaService = categoria;
            dtCategoria.DoubleClick += dtCategoria_DoubleClick;
        }


        private void TelaCategoria_Load(object sender, EventArgs e)
        {
            SincronizarGrid();
        }

        private Categoria CreateObjectWithForm()
        {
            int temp;
            int.TryParse(txtID.Text, out temp);
            Categoria c = new()
            {
                Id = temp,
                Nome = txtNome.Text,
                Descricao = txtDesc.Text,

            };
            return c;
        }
        private void dtCategoria_DoubleClick(object sender, EventArgs e)
        {
            int rowindex = dtCategoria.CurrentCell.RowIndex;
            Categoria categoriaSelecionada = new();
            categoriaSelecionada.Id = Convert.ToInt32(this.dtCategoria.Rows[rowindex].Cells[0].Value);
            categoriaSelecionada.Nome = Convert.ToString(this.dtCategoria.Rows[rowindex].Cells[1].Value);
            categoriaSelecionada.Descricao = Convert.ToString(this.dtCategoria.Rows[rowindex].Cells[2].Value);
            DrawFormWithObject(categoriaSelecionada);
        }


        private async void SincronizarGrid()
        {
            dtCategoria.DataSource = null;
            DataResponse<Categoria> dataResponse = await _categoriaService.GetAll();
            dtCategoria.Rows.Clear();
            for (int i = 0; i < dataResponse.Itens.Count; i++)
            {
                dtCategoria.Rows.Add();
                dtCategoria.Rows[i].Cells["CategoriaID"].Value = dataResponse.Itens[i].Id;
                dtCategoria.Rows[i].Cells["CategoriaNome"].Value = dataResponse.Itens[i].Nome;
                dtCategoria.Rows[i].Cells["CategoriaDescricao"].Value = dataResponse.Itens[i].Descricao;
            }
        }

        private void DrawFormWithObject(Categoria categoria)
        {
            this.txtID.Text = categoria.Id.ToString();
            this.txtNome.Text = categoria.Nome;
            this.txtDesc.Text = categoria.Descricao;

        }



        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            Categoria categoria = CreateObjectWithForm();
            Response response = await _categoriaService.Insert(categoria);
            if (response.HasSuccess)
            {
                MessageBox.Show("Sucesso");
                SincronizarGrid();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            Categoria categoria = CreateObjectWithForm();
            Response response = await _categoriaService.Update(categoria);
            if (response.HasSuccess)
            {
                MessageBox.Show("Sucesso");
                SincronizarGrid();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            Categoria categoria = CreateObjectWithForm();
            Response response = await _categoriaService.Delete(categoria);
            if (response.HasSuccess)
            {
                MessageBox.Show("Sucesso");
                SincronizarGrid();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtID.Clear();
            txtDesc.Clear();
        }
    }
}
