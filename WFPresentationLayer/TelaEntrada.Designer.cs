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
            this.cbProduto.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(601, 241);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(121, 29);
            this.cbProduto.TabIndex = 0;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(601, 206);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(121, 29);
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
            this.dtDataEntrada.Location = new System.Drawing.Point(73, 276);
            this.dtDataEntrada.Name = "dtDataEntrada";
            this.dtDataEntrada.ReadOnly = true;
            this.dtDataEntrada.RowTemplate.Height = 25;
            this.dtDataEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtDataEntrada.Size = new System.Drawing.Size(967, 338);
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
            this.dtEntrada.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtEntrada.Location = new System.Drawing.Point(288, 206);
            this.dtEntrada.Name = "dtEntrada";
            this.dtEntrada.Size = new System.Drawing.Size(200, 28);
            this.dtEntrada.TabIndex = 3;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.lblDataEntrada.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataEntrada.ForeColor = System.Drawing.Color.White;
            this.lblDataEntrada.Location = new System.Drawing.Point(144, 206);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(138, 21);
            this.lblDataEntrada.TabIndex = 4;
            this.lblDataEntrada.Text = "Data de Entrada:";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFornecedor.ForeColor = System.Drawing.Color.White;
            this.lblFornecedor.Location = new System.Drawing.Point(494, 209);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(101, 21);
            this.lblFornecedor.TabIndex = 5;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.lblProduto.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProduto.ForeColor = System.Drawing.Color.White;
            this.lblProduto.Location = new System.Drawing.Point(519, 246);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(76, 21);
            this.lblProduto.TabIndex = 6;
            this.lblProduto.Text = "Produto:";
            // 
            // nudValor
            // 
            this.nudValor.DecimalPlaces = 2;
            this.nudValor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudValor.Location = new System.Drawing.Point(171, 240);
            this.nudValor.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(78, 28);
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
            this.lblValorUnitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.lblValorUnitario.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorUnitario.ForeColor = System.Drawing.Color.White;
            this.lblValorUnitario.Location = new System.Drawing.Point(74, 243);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(85, 21);
            this.lblValorUnitario.TabIndex = 8;
            this.lblValorUnitario.Text = "Valor Uni:";
            // 
            // nudQtd
            // 
            this.nudQtd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudQtd.Location = new System.Drawing.Point(365, 242);
            this.nudQtd.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(78, 28);
            this.nudQtd.TabIndex = 9;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.lblQtd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQtd.ForeColor = System.Drawing.Color.White;
            this.lblQtd.Location = new System.Drawing.Point(255, 247);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(104, 21);
            this.lblQtd.TabIndex = 10;
            this.lblQtd.Text = "Quantidade:";
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduto.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduto.ForeColor = System.Drawing.Color.White;
            this.btnAddProduto.Location = new System.Drawing.Point(728, 242);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(153, 28);
            this.btnAddProduto.TabIndex = 11;
            this.btnAddProduto.Text = "Adicionar Produto";
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // btnDelProduto
            // 
            this.btnDelProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelProduto.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelProduto.ForeColor = System.Drawing.Color.White;
            this.btnDelProduto.Location = new System.Drawing.Point(887, 242);
            this.btnDelProduto.Name = "btnDelProduto";
            this.btnDelProduto.Size = new System.Drawing.Size(153, 28);
            this.btnDelProduto.TabIndex = 12;
            this.btnDelProduto.Text = "Retirar Produto";
            this.btnDelProduto.UseVisualStyleBackColor = true;
            this.btnDelProduto.Click += new System.EventHandler(this.btnDelProduto_Click);
            // 
            // txtNitens
            // 
            this.txtNitens.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNitens.Location = new System.Drawing.Point(1116, 300);
            this.txtNitens.Name = "txtNitens";
            this.txtNitens.Size = new System.Drawing.Size(100, 28);
            this.txtNitens.TabIndex = 13;
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalPago.Location = new System.Drawing.Point(1116, 355);
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.Size = new System.Drawing.Size(100, 28);
            this.txtTotalPago.TabIndex = 14;
            // 
            // lblNItens
            // 
            this.lblNItens.AutoSize = true;
            this.lblNItens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.lblNItens.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNItens.ForeColor = System.Drawing.Color.White;
            this.lblNItens.Location = new System.Drawing.Point(1116, 276);
            this.lblNItens.Name = "lblNItens";
            this.lblNItens.Size = new System.Drawing.Size(101, 21);
            this.lblNItens.TabIndex = 15;
            this.lblNItens.Text = "N.º de Itens";
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.lblTotalPago.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPago.ForeColor = System.Drawing.Color.White;
            this.lblTotalPago.Location = new System.Drawing.Point(1116, 331);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(96, 21);
            this.lblTotalPago.TabIndex = 16;
            this.lblTotalPago.Text = "Total Pago:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(1046, 554);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(171, 60);
            this.btnRegistrar.TabIndex = 17;
            this.btnRegistrar.Text = "Registrar Entrada";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProduto.ForeColor = System.Drawing.Color.White;
            this.btnProduto.Location = new System.Drawing.Point(1239, 737);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(229, 59);
            this.btnProduto.TabIndex = 18;
            this.btnProduto.Text = "Cadastrar Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnFornecedor.Location = new System.Drawing.Point(1474, 737);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(229, 59);
            this.btnFornecedor.TabIndex = 19;
            this.btnFornecedor.Text = "Cadastrar Fornecedor";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // TelaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1715, 902);
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
            this.MaximizeBox = false;
            this.Name = "TelaEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaEntrada";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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