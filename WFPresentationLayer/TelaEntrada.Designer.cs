namespace WFPresentationLayer
{
    partial class TelaEntrada
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
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.dtDataEntrada = new System.Windows.Forms.DataGridView();
            this.EntradaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.lblQtd = new System.Windows.Forms.Label();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.btnDelProduto = new System.Windows.Forms.Button();
            this.txtNitens = new System.Windows.Forms.TextBox();
            this.txtTotalPago = new System.Windows.Forms.TextBox();
            this.lblNItens = new System.Windows.Forms.Label();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProduto
            // 
            this.cbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(264, 201);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(121, 23);
            this.cbProduto.TabIndex = 0;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(472, 131);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(121, 23);
            this.cbFornecedor.TabIndex = 1;
            // 
            // dtDataEntrada
            // 
            this.dtDataEntrada.AllowUserToAddRows = false;
            this.dtDataEntrada.AllowUserToDeleteRows = false;
            this.dtDataEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtDataEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDataEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EntradaID,
            this.EntradaNome,
            this.EntradaQuantidade,
            this.EntradaValor,
            this.EntradaTotal});
            this.dtDataEntrada.Location = new System.Drawing.Point(84, 233);
            this.dtDataEntrada.Name = "dtDataEntrada";
            this.dtDataEntrada.ReadOnly = true;
            this.dtDataEntrada.RowTemplate.Height = 25;
            this.dtDataEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtDataEntrada.Size = new System.Drawing.Size(585, 152);
            this.dtDataEntrada.TabIndex = 2;
            // 
            // EntradaID
            // 
            this.EntradaID.HeaderText = "Id";
            this.EntradaID.Name = "EntradaID";
            this.EntradaID.ReadOnly = true;
            // 
            // EntradaNome
            // 
            this.EntradaNome.HeaderText = "Nome";
            this.EntradaNome.Name = "EntradaNome";
            this.EntradaNome.ReadOnly = true;
            // 
            // EntradaQuantidade
            // 
            this.EntradaQuantidade.HeaderText = "Quantidade";
            this.EntradaQuantidade.Name = "EntradaQuantidade";
            this.EntradaQuantidade.ReadOnly = true;
            // 
            // EntradaValor
            // 
            this.EntradaValor.HeaderText = "Valor Unitário";
            this.EntradaValor.Name = "EntradaValor";
            this.EntradaValor.ReadOnly = true;
            // 
            // EntradaTotal
            // 
            this.EntradaTotal.HeaderText = "Total";
            this.EntradaTotal.Name = "EntradaTotal";
            this.EntradaTotal.ReadOnly = true;
            // 
            // dtEntrada
            // 
            this.dtEntrada.Location = new System.Drawing.Point(190, 131);
            this.dtEntrada.Name = "dtEntrada";
            this.dtEntrada.Size = new System.Drawing.Size(200, 23);
            this.dtEntrada.TabIndex = 3;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(91, 135);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(93, 15);
            this.lblDataEntrada.TabIndex = 4;
            this.lblDataEntrada.Text = "Data de Entrada:";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(396, 134);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(70, 15);
            this.lblFornecedor.TabIndex = 5;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(264, 184);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(53, 15);
            this.lblProduto.TabIndex = 6;
            this.lblProduto.Text = "Produto:";
            // 
            // nudValor
            // 
            this.nudValor.DecimalPlaces = 2;
            this.nudValor.Location = new System.Drawing.Point(84, 202);
            this.nudValor.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(78, 23);
            this.nudValor.TabIndex = 7;
            this.nudValor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Location = new System.Drawing.Point(84, 184);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(57, 15);
            this.lblValorUnitario.TabIndex = 8;
            this.lblValorUnitario.Text = "Valor Uni:";
            // 
            // nudQtd
            // 
            this.nudQtd.Location = new System.Drawing.Point(168, 202);
            this.nudQtd.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(78, 23);
            this.nudQtd.TabIndex = 9;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(168, 184);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(72, 15);
            this.lblQtd.TabIndex = 10;
            this.lblQtd.Text = "Quantidade:";
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Location = new System.Drawing.Point(391, 201);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(130, 24);
            this.btnAddProduto.TabIndex = 11;
            this.btnAddProduto.Text = "Adicionar Produto";
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // btnDelProduto
            // 
            this.btnDelProduto.Location = new System.Drawing.Point(527, 201);
            this.btnDelProduto.Name = "btnDelProduto";
            this.btnDelProduto.Size = new System.Drawing.Size(130, 26);
            this.btnDelProduto.TabIndex = 12;
            this.btnDelProduto.Text = "Retirar Produto";
            this.btnDelProduto.UseVisualStyleBackColor = true;
            this.btnDelProduto.Click += new System.EventHandler(this.btnDelProduto_Click);
            // 
            // txtNitens
            // 
            this.txtNitens.Location = new System.Drawing.Point(811, 201);
            this.txtNitens.Name = "txtNitens";
            this.txtNitens.Size = new System.Drawing.Size(100, 23);
            this.txtNitens.TabIndex = 13;
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.Location = new System.Drawing.Point(811, 264);
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.Size = new System.Drawing.Size(100, 23);
            this.txtTotalPago.TabIndex = 14;
            // 
            // lblNItens
            // 
            this.lblNItens.AutoSize = true;
            this.lblNItens.Location = new System.Drawing.Point(811, 183);
            this.lblNItens.Name = "lblNItens";
            this.lblNItens.Size = new System.Drawing.Size(68, 15);
            this.lblNItens.TabIndex = 15;
            this.lblNItens.Text = "N.º de Itens";
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.Location = new System.Drawing.Point(811, 246);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(66, 15);
            this.lblTotalPago.TabIndex = 16;
            this.lblTotalPago.Text = "Total Pago:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(675, 359);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(130, 26);
            this.btnRegistrar.TabIndex = 17;
            this.btnRegistrar.Text = "Registrar Entrada";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(579, 498);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(130, 26);
            this.btnProduto.TabIndex = 18;
            this.btnProduto.Text = "Cadastrar Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Location = new System.Drawing.Point(715, 498);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(130, 26);
            this.btnFornecedor.TabIndex = 19;
            this.btnFornecedor.Text = "Cadastrar Fornecedor";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // TelaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 536);
            this.Controls.Add(this.btnFornecedor);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblTotalPago);
            this.Controls.Add(this.lblNItens);
            this.Controls.Add(this.txtTotalPago);
            this.Controls.Add(this.txtNitens);
            this.Controls.Add(this.btnDelProduto);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.nudQtd);
            this.Controls.Add(this.lblValorUnitario);
            this.Controls.Add(this.nudValor);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.dtEntrada);
            this.Controls.Add(this.dtDataEntrada);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.cbProduto);
            this.Name = "TelaEntrada";
            this.Text = "TelaEntrada";
            this.Load += new System.EventHandler(this.TelaEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDataEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbProduto;
        private ComboBox cbFornecedor;
        private DataGridView dtDataEntrada;
        private DataGridViewTextBoxColumn EntradaID;
        private DataGridViewTextBoxColumn EntradaNome;
        private DataGridViewTextBoxColumn EntradaQuantidade;
        private DataGridViewTextBoxColumn EntradaValor;
        private DataGridViewTextBoxColumn EntradaTotal;
        private DateTimePicker dtEntrada;
        private Label lblDataEntrada;
        private Label lblFornecedor;
        private Label lblProduto;
        private NumericUpDown nudValor;
        private Label lblValorUnitario;
        private NumericUpDown nudQtd;
        private Label lblQtd;
        private Button btnAddProduto;
        private Button btnDelProduto;
        private TextBox txtNitens;
        private TextBox txtTotalPago;
        private Label lblNItens;
        private Label lblTotalPago;
        private Button btnRegistrar;
        private Button btnProduto;
        private Button btnFornecedor;
    }
}