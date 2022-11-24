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
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblForne = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.txtQtdEstoque = new System.Windows.Forms.TextBox();
            this.lblQtdEstoque = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbFornecedora = new System.Windows.Forms.ComboBox();
            this.ProdutoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoQtdEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoFornecedora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtProduto = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCategoria
            // 
            this.btnCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCategoria.Location = new System.Drawing.Point(1499, 727);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(193, 71);
            this.btnCategoria.TabIndex = 111;
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(420, 650);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(193, 71);
            this.btnDelete.TabIndex = 109;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(221, 650);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(193, 71);
            this.btnUpdate.TabIndex = 108;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(21, 650);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(193, 71);
            this.btnCadastrar.TabIndex = 107;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(99, 277);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(84, 21);
            this.lblCategoria.TabIndex = 18;
            this.lblCategoria.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(99, 301);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 23);
            this.cbCategoria.TabIndex = 17;
            // 
            // lblForne
            // 
            this.lblForne.AutoSize = true;
            this.lblForne.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForne.ForeColor = System.Drawing.Color.White;
            this.lblForne.Location = new System.Drawing.Point(226, 277);
            this.lblForne.Name = "lblForne";
            this.lblForne.Size = new System.Drawing.Size(106, 21);
            this.lblForne.TabIndex = 12;
            this.lblForne.Text = "Fornecedora";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(99, 361);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 11;
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorUnitario.ForeColor = System.Drawing.Color.White;
            this.lblValorUnitario.Location = new System.Drawing.Point(99, 337);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(57, 21);
            this.lblValorUnitario.TabIndex = 10;
            this.lblValorUnitario.Text = "Preço:";
            // 
            // txtQtdEstoque
            // 
            this.txtQtdEstoque.Location = new System.Drawing.Point(99, 411);
            this.txtQtdEstoque.Name = "txtQtdEstoque";
            this.txtQtdEstoque.Size = new System.Drawing.Size(100, 23);
            this.txtQtdEstoque.TabIndex = 9;
            // 
            // lblQtdEstoque
            // 
            this.lblQtdEstoque.AutoSize = true;
            this.lblQtdEstoque.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQtdEstoque.ForeColor = System.Drawing.Color.White;
            this.lblQtdEstoque.Location = new System.Drawing.Point(99, 387);
            this.lblQtdEstoque.Name = "lblQtdEstoque";
            this.lblQtdEstoque.Size = new System.Drawing.Size(104, 21);
            this.lblQtdEstoque.TabIndex = 8;
            this.lblQtdEstoque.Text = "Quantidade:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(99, 227);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(243, 47);
            this.txtDescricao.TabIndex = 7;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(99, 203);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(87, 21);
            this.lblDescricao.TabIndex = 6;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(99, 177);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(99, 153);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 21);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(99, 127);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(50, 23);
            this.txtID.TabIndex = 3;
            // 
            // cbFornecedora
            // 
            this.cbFornecedora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedora.FormattingEnabled = true;
            this.cbFornecedora.Location = new System.Drawing.Point(226, 301);
            this.cbFornecedora.Name = "cbFornecedora";
            this.cbFornecedora.Size = new System.Drawing.Size(116, 23);
            this.cbFornecedora.TabIndex = 2;
            // 
            // ProdutoValor
            // 
            this.ProdutoValor.HeaderText = "Valor do Produto";
            this.ProdutoValor.Name = "ProdutoValor";
            this.ProdutoValor.ReadOnly = true;
            // 
            // ProdutoQtdEstoque
            // 
            this.ProdutoQtdEstoque.HeaderText = "Quantidade em Estoque";
            this.ProdutoQtdEstoque.Name = "ProdutoQtdEstoque";
            this.ProdutoQtdEstoque.ReadOnly = true;
            // 
            // CatProduto
            // 
            this.CatProduto.HeaderText = "Categoria";
            this.CatProduto.Name = "CatProduto";
            this.CatProduto.ReadOnly = true;
            // 
            // ProdutoFornecedora
            // 
            this.ProdutoFornecedora.HeaderText = "Fornecedora";
            this.ProdutoFornecedora.Name = "ProdutoFornecedora";
            this.ProdutoFornecedora.ReadOnly = true;
            // 
            // ProdutoDescricao
            // 
            this.ProdutoDescricao.HeaderText = "Descrição";
            this.ProdutoDescricao.Name = "ProdutoDescricao";
            this.ProdutoDescricao.ReadOnly = true;
            // 
            // ProdutoNome
            // 
            this.ProdutoNome.HeaderText = "Nome";
            this.ProdutoNome.Name = "ProdutoNome";
            this.ProdutoNome.ReadOnly = true;
            // 
            // ProdutoID
            // 
            this.ProdutoID.HeaderText = "ID";
            this.ProdutoID.Name = "ProdutoID";
            this.ProdutoID.ReadOnly = true;
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
            this.CatProduto,
            this.ProdutoQtdEstoque,
            this.ProdutoValor});
            this.dtProduto.Location = new System.Drawing.Point(643, 82);
            this.dtProduto.Name = "dtProduto";
            this.dtProduto.ReadOnly = true;
            this.dtProduto.RowTemplate.Height = 25;
            this.dtProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtProduto.Size = new System.Drawing.Size(1049, 639);
            this.dtProduto.TabIndex = 1;
            this.dtProduto.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(99, 103);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 21);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // TelaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1715, 902);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbCategoria);
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

        private Button btnCategoria;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCadastrar;
        private Label lblCategoria;
        private ComboBox cbCategoria;
        private Label lblForne;
        private TextBox txtValor;
        private Label lblValorUnitario;
        private TextBox txtQtdEstoque;
        private Label lblQtdEstoque;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtID;
        private ComboBox cbFornecedora;
        private DataGridViewTextBoxColumn ProdutoValor;
        private DataGridViewTextBoxColumn ProdutoQtdEstoque;
        private DataGridViewTextBoxColumn CatProduto;
        private DataGridViewTextBoxColumn ProdutoFornecedora;
        private DataGridViewTextBoxColumn ProdutoDescricao;
        private DataGridViewTextBoxColumn ProdutoNome;
        private DataGridViewTextBoxColumn ProdutoID;
        private DataGridView dtProduto;
        private Label lblID;
    }
}