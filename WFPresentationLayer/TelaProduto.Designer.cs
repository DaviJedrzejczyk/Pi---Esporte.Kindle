namespace WFPresentationLayer
{
    partial class TelaProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.dtProduto = new System.Windows.Forms.DataGridView();
            this.ProdutoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoFornecedora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoQtdEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbFornecedora = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtQtdEstoque = new System.Windows.Forms.TextBox();
            this.lblQtdEstoque = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.lblForne = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(38, 47);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 15);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // dtProduto
            // 
            this.dtProduto.AllowUserToAddRows = false;
            this.dtProduto.AllowUserToDeleteRows = false;
            this.dtProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdutoID,
            this.ProdutoNome,
            this.ProdutoDescricao,
            this.ProdutoFornecedora,
            this.ProdutoQtdEstoque,
            this.ProdutoValor});
            this.dtProduto.Location = new System.Drawing.Point(238, 12);
            this.dtProduto.Name = "dtProduto";
            this.dtProduto.ReadOnly = true;
            this.dtProduto.RowTemplate.Height = 25;
            this.dtProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtProduto.Size = new System.Drawing.Size(550, 426);
            this.dtProduto.TabIndex = 1;
            this.dtProduto.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // ProdutoID
            // 
            this.ProdutoID.HeaderText = "ID";
            this.ProdutoID.Name = "ProdutoID";
            this.ProdutoID.ReadOnly = true;
            // 
            // ProdutoNome
            // 
            this.ProdutoNome.HeaderText = "Nome";
            this.ProdutoNome.Name = "ProdutoNome";
            this.ProdutoNome.ReadOnly = true;
            // 
            // ProdutoDescricao
            // 
            this.ProdutoDescricao.HeaderText = "Descrição";
            this.ProdutoDescricao.Name = "ProdutoDescricao";
            this.ProdutoDescricao.ReadOnly = true;
            // 
            // ProdutoFornecedora
            // 
            this.ProdutoFornecedora.HeaderText = "Fornecedora";
            this.ProdutoFornecedora.Name = "ProdutoFornecedora";
            this.ProdutoFornecedora.ReadOnly = true;
            // 
            // ProdutoQtdEstoque
            // 
            this.ProdutoQtdEstoque.HeaderText = "Quantidade em Estoque";
            this.ProdutoQtdEstoque.Name = "ProdutoQtdEstoque";
            this.ProdutoQtdEstoque.ReadOnly = true;
            // 
            // ProdutoValor
            // 
            this.ProdutoValor.HeaderText = "Valor do Produto";
            this.ProdutoValor.Name = "ProdutoValor";
            this.ProdutoValor.ReadOnly = true;
            // 
            // cbFornecedora
            // 
            this.cbFornecedora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedora.FormattingEnabled = true;
            this.cbFornecedora.Location = new System.Drawing.Point(82, 141);
            this.cbFornecedora.Name = "cbFornecedora";
            this.cbFornecedora.Size = new System.Drawing.Size(121, 23);
            this.cbFornecedora.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(82, 44);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(50, 23);
            this.txtID.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(82, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 23);
            this.txtNome.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(21, 82);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(82, 111);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(121, 23);
            this.txtDescricao.TabIndex = 7;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(3, 111);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(61, 15);
            this.lblDescricao.TabIndex = 6;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtQtdEstoque
            // 
            this.txtQtdEstoque.Location = new System.Drawing.Point(3, 233);
            this.txtQtdEstoque.Name = "txtQtdEstoque";
            this.txtQtdEstoque.Size = new System.Drawing.Size(137, 23);
            this.txtQtdEstoque.TabIndex = 9;
            // 
            // lblQtdEstoque
            // 
            this.lblQtdEstoque.AutoSize = true;
            this.lblQtdEstoque.Location = new System.Drawing.Point(3, 215);
            this.lblQtdEstoque.Name = "lblQtdEstoque";
            this.lblQtdEstoque.Size = new System.Drawing.Size(137, 15);
            this.lblQtdEstoque.TabIndex = 8;
            this.lblQtdEstoque.Text = "Quantidade em Estoque:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(3, 277);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 11;
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Location = new System.Drawing.Point(3, 259);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(99, 15);
            this.lblValorUnitario.TabIndex = 10;
            this.lblValorUnitario.Text = "Valor do Produto:";
            // 
            // lblForne
            // 
            this.lblForne.AutoSize = true;
            this.lblForne.Location = new System.Drawing.Point(3, 144);
            this.lblForne.Name = "lblForne";
            this.lblForne.Size = new System.Drawing.Size(73, 15);
            this.lblForne.TabIndex = 12;
            this.lblForne.Text = "Fornecedora";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(3, 357);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(73, 53);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(82, 357);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 53);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(158, 357);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 53);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(3, 173);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(58, 15);
            this.lblCategoria.TabIndex = 18;
            this.lblCategoria.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(82, 170);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 23);
            this.cbCategoria.TabIndex = 17;
            // 
            // TelaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblForne);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValorUnitario);
            this.Controls.Add(this.txtQtdEstoque);
            this.Controls.Add(this.lblQtdEstoque);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cbFornecedora);
            this.Controls.Add(this.dtProduto);
            this.Controls.Add(this.lblID);
            this.Name = "TelaProduto";
            this.Text = "TelaProduto";
            this.Load += new System.EventHandler(this.TelaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblID;
        private DataGridView dtProduto;
        private ComboBox cbFornecedora;
        private TextBox txtID;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private TextBox txtQtdEstoque;
        private Label lblQtdEstoque;
        private TextBox txtValor;
        private Label lblValorUnitario;
        private Label lblForne;
        private DataGridViewTextBoxColumn ProdutoID;
        private DataGridViewTextBoxColumn ProdutoNome;
        private DataGridViewTextBoxColumn ProdutoDescricao;
        private DataGridViewTextBoxColumn ProdutoFornecedora;
        private DataGridViewTextBoxColumn ProdutoQtdEstoque;
        private DataGridViewTextBoxColumn ProdutoValor;
        private Button btnCadastrar;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblCategoria;
        private ComboBox cbCategoria;
    }
}