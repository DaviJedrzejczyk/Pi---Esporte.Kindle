namespace WFPresentationLayer
{
    partial class TelaHistoricos
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
            this.tbMaster = new System.Windows.Forms.TabControl();
            this.tbVendas = new System.Windows.Forms.TabPage();
            this.panelDesktopSaida = new System.Windows.Forms.Panel();
            this.dtHistoricoSaida = new System.Windows.Forms.DataGridView();
            this.dtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFormaPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelButtos = new System.Windows.Forms.Panel();
            this.btnTabelas = new System.Windows.Forms.Button();
            this.btnInformacoes = new System.Windows.Forms.Button();
            this.tbEntrada = new System.Windows.Forms.TabPage();
            this.panelDesktopEntrada = new System.Windows.Forms.Panel();
            this.dtEntradas = new System.Windows.Forms.DataGridView();
            this.IdEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionarioEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnTabelaEntrada = new System.Windows.Forms.Button();
            this.btnInfoEntrada = new System.Windows.Forms.Button();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dateSaida = new System.Windows.Forms.DateTimePicker();
            this.dateEntrada = new System.Windows.Forms.DateTimePicker();
            this.tbMaster.SuspendLayout();
            this.tbVendas.SuspendLayout();
            this.panelDesktopSaida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHistoricoSaida)).BeginInit();
            this.panelButtos.SuspendLayout();
            this.tbEntrada.SuspendLayout();
            this.panelDesktopEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEntradas)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMaster
            // 
            this.tbMaster.Controls.Add(this.tbVendas);
            this.tbMaster.Controls.Add(this.tbEntrada);
            this.tbMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMaster.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMaster.Location = new System.Drawing.Point(0, 0);
            this.tbMaster.Name = "tbMaster";
            this.tbMaster.SelectedIndex = 0;
            this.tbMaster.Size = new System.Drawing.Size(1715, 902);
            this.tbMaster.TabIndex = 0;
            // 
            // tbVendas
            // 
            this.tbVendas.Controls.Add(this.panelDesktopSaida);
            this.tbVendas.Location = new System.Drawing.Point(4, 30);
            this.tbVendas.Name = "tbVendas";
            this.tbVendas.Padding = new System.Windows.Forms.Padding(3);
            this.tbVendas.Size = new System.Drawing.Size(1707, 868);
            this.tbVendas.TabIndex = 0;
            this.tbVendas.Text = "Vendas";
            this.tbVendas.UseVisualStyleBackColor = true;
            // 
            // panelDesktopSaida
            // 
            this.panelDesktopSaida.Controls.Add(this.dtHistoricoSaida);
            this.panelDesktopSaida.Controls.Add(this.panelButtos);
            this.panelDesktopSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopSaida.Location = new System.Drawing.Point(3, 3);
            this.panelDesktopSaida.Name = "panelDesktopSaida";
            this.panelDesktopSaida.Size = new System.Drawing.Size(1701, 862);
            this.panelDesktopSaida.TabIndex = 0;
            // 
            // dtHistoricoSaida
            // 
            this.dtHistoricoSaida.AllowUserToAddRows = false;
            this.dtHistoricoSaida.AllowUserToDeleteRows = false;
            this.dtHistoricoSaida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtHistoricoSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHistoricoSaida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtID,
            this.dtCliente,
            this.dtFuncionario,
            this.dtData,
            this.dtFormaPag,
            this.dtValorTotal});
            this.dtHistoricoSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtHistoricoSaida.Location = new System.Drawing.Point(0, 0);
            this.dtHistoricoSaida.Name = "dtHistoricoSaida";
            this.dtHistoricoSaida.ReadOnly = true;
            this.dtHistoricoSaida.RowTemplate.Height = 25;
            this.dtHistoricoSaida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtHistoricoSaida.Size = new System.Drawing.Size(1408, 862);
            this.dtHistoricoSaida.TabIndex = 4;
            // 
            // dtID
            // 
            this.dtID.HeaderText = "ID";
            this.dtID.Name = "dtID";
            this.dtID.ReadOnly = true;
            // 
            // dtCliente
            // 
            this.dtCliente.HeaderText = "Cliente";
            this.dtCliente.Name = "dtCliente";
            this.dtCliente.ReadOnly = true;
            // 
            // dtFuncionario
            // 
            this.dtFuncionario.HeaderText = "Funcionário";
            this.dtFuncionario.Name = "dtFuncionario";
            this.dtFuncionario.ReadOnly = true;
            // 
            // dtData
            // 
            this.dtData.HeaderText = "Data";
            this.dtData.Name = "dtData";
            this.dtData.ReadOnly = true;
            // 
            // dtFormaPag
            // 
            this.dtFormaPag.HeaderText = "Forma de Pagamento";
            this.dtFormaPag.Name = "dtFormaPag";
            this.dtFormaPag.ReadOnly = true;
            // 
            // dtValorTotal
            // 
            this.dtValorTotal.HeaderText = "Valor Total";
            this.dtValorTotal.Name = "dtValorTotal";
            this.dtValorTotal.ReadOnly = true;
            // 
            // panelButtos
            // 
            this.panelButtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelButtos.Controls.Add(this.btnTabelas);
            this.panelButtos.Controls.Add(this.btnInformacoes);
            this.panelButtos.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtos.Location = new System.Drawing.Point(1408, 0);
            this.panelButtos.Name = "panelButtos";
            this.panelButtos.Size = new System.Drawing.Size(293, 862);
            this.panelButtos.TabIndex = 3;
            // 
            // btnTabelas
            // 
            this.btnTabelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabelas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTabelas.ForeColor = System.Drawing.Color.White;
            this.btnTabelas.Location = new System.Drawing.Point(6, 30);
            this.btnTabelas.Name = "btnTabelas";
            this.btnTabelas.Size = new System.Drawing.Size(282, 116);
            this.btnTabelas.TabIndex = 1;
            this.btnTabelas.Text = "Tabelas Saídas";
            this.btnTabelas.UseVisualStyleBackColor = true;
            this.btnTabelas.Click += new System.EventHandler(this.btnTabelas_Click);
            // 
            // btnInformacoes
            // 
            this.btnInformacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacoes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInformacoes.ForeColor = System.Drawing.Color.White;
            this.btnInformacoes.Location = new System.Drawing.Point(6, 152);
            this.btnInformacoes.Name = "btnInformacoes";
            this.btnInformacoes.Size = new System.Drawing.Size(282, 116);
            this.btnInformacoes.TabIndex = 0;
            this.btnInformacoes.Text = "Informações da Saída";
            this.btnInformacoes.UseVisualStyleBackColor = true;
            this.btnInformacoes.Click += new System.EventHandler(this.btnInformacoes_Click);
            // 
            // tbEntrada
            // 
            this.tbEntrada.Controls.Add(this.panelDesktopEntrada);
            this.tbEntrada.Controls.Add(this.panelButtons);
            this.tbEntrada.Location = new System.Drawing.Point(4, 30);
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.Padding = new System.Windows.Forms.Padding(3);
            this.tbEntrada.Size = new System.Drawing.Size(1720, 868);
            this.tbEntrada.TabIndex = 1;
            this.tbEntrada.Text = "Entradas";
            this.tbEntrada.UseVisualStyleBackColor = true;
            // 
            // panelDesktopEntrada
            // 
            this.panelDesktopEntrada.Controls.Add(this.dtEntradas);
            this.panelDesktopEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopEntrada.Location = new System.Drawing.Point(3, 3);
            this.panelDesktopEntrada.Name = "panelDesktopEntrada";
            this.panelDesktopEntrada.Size = new System.Drawing.Size(1421, 862);
            this.panelDesktopEntrada.TabIndex = 1;
            // 
            // dtEntradas
            // 
            this.dtEntradas.AllowUserToAddRows = false;
            this.dtEntradas.AllowUserToDeleteRows = false;
            this.dtEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEntrada,
            this.FornecedorEntrada,
            this.FuncionarioEntrada,
            this.DataEntrada,
            this.ValorEntrada});
            this.dtEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtEntradas.Location = new System.Drawing.Point(0, 0);
            this.dtEntradas.Name = "dtEntradas";
            this.dtEntradas.ReadOnly = true;
            this.dtEntradas.RowTemplate.Height = 25;
            this.dtEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtEntradas.Size = new System.Drawing.Size(1421, 862);
            this.dtEntradas.TabIndex = 0;
            // 
            // IdEntrada
            // 
            this.IdEntrada.HeaderText = "ID";
            this.IdEntrada.Name = "IdEntrada";
            this.IdEntrada.ReadOnly = true;
            // 
            // FornecedorEntrada
            // 
            this.FornecedorEntrada.HeaderText = "Fornecedor";
            this.FornecedorEntrada.Name = "FornecedorEntrada";
            this.FornecedorEntrada.ReadOnly = true;
            // 
            // FuncionarioEntrada
            // 
            this.FuncionarioEntrada.HeaderText = "Funcionários";
            this.FuncionarioEntrada.Name = "FuncionarioEntrada";
            this.FuncionarioEntrada.ReadOnly = true;
            // 
            // DataEntrada
            // 
            this.DataEntrada.HeaderText = "Data";
            this.DataEntrada.Name = "DataEntrada";
            this.DataEntrada.ReadOnly = true;
            // 
            // ValorEntrada
            // 
            this.ValorEntrada.HeaderText = "Valor";
            this.ValorEntrada.Name = "ValorEntrada";
            this.ValorEntrada.ReadOnly = true;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelButtons.Controls.Add(this.btnTabelaEntrada);
            this.panelButtons.Controls.Add(this.btnInfoEntrada);
            this.panelButtons.Controls.Add(this.lblDataEntrada);
            this.panelButtons.Controls.Add(this.lblDataSaida);
            this.panelButtons.Controls.Add(this.btnFilter);
            this.panelButtons.Controls.Add(this.dateSaida);
            this.panelButtons.Controls.Add(this.dateEntrada);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(1424, 3);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(293, 862);
            this.panelButtons.TabIndex = 0;
            // 
            // btnTabelaEntrada
            // 
            this.btnTabelaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabelaEntrada.ForeColor = System.Drawing.Color.White;
            this.btnTabelaEntrada.Location = new System.Drawing.Point(6, 19);
            this.btnTabelaEntrada.Name = "btnTabelaEntrada";
            this.btnTabelaEntrada.Size = new System.Drawing.Size(282, 93);
            this.btnTabelaEntrada.TabIndex = 6;
            this.btnTabelaEntrada.Text = "Tabela Entrada";
            this.btnTabelaEntrada.UseVisualStyleBackColor = true;
            this.btnTabelaEntrada.Click += new System.EventHandler(this.btnTabelaEntrada_Click);
            // 
            // btnInfoEntrada
            // 
            this.btnInfoEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoEntrada.ForeColor = System.Drawing.Color.White;
            this.btnInfoEntrada.Location = new System.Drawing.Point(6, 118);
            this.btnInfoEntrada.Name = "btnInfoEntrada";
            this.btnInfoEntrada.Size = new System.Drawing.Size(282, 93);
            this.btnInfoEntrada.TabIndex = 5;
            this.btnInfoEntrada.Text = "Informações da Entrada";
            this.btnInfoEntrada.UseVisualStyleBackColor = true;
            this.btnInfoEntrada.Click += new System.EventHandler(this.btnInfoEntrada_Click);
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.ForeColor = System.Drawing.Color.White;
            this.lblDataEntrada.Location = new System.Drawing.Point(6, 559);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(114, 21);
            this.lblDataEntrada.TabIndex = 4;
            this.lblDataEntrada.Text = "Data Entrada:";
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.ForeColor = System.Drawing.Color.White;
            this.lblDataSaida.Location = new System.Drawing.Point(4, 624);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(96, 21);
            this.lblDataSaida.TabIndex = 3;
            this.lblDataSaida.Text = "Data Saída:";
            // 
            // btnFilter
            // 
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(4, 764);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(282, 93);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filtrar Entradas";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dateSaida
            // 
            this.dateSaida.Location = new System.Drawing.Point(6, 648);
            this.dateSaida.Name = "dateSaida";
            this.dateSaida.Size = new System.Drawing.Size(282, 28);
            this.dateSaida.TabIndex = 1;
            // 
            // dateEntrada
            // 
            this.dateEntrada.Location = new System.Drawing.Point(4, 593);
            this.dateEntrada.Name = "dateEntrada";
            this.dateEntrada.Size = new System.Drawing.Size(282, 28);
            this.dateEntrada.TabIndex = 0;
            // 
            // TelaHistoricos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1715, 902);
            this.Controls.Add(this.tbMaster);
            this.MaximizeBox = false;
            this.Name = "TelaHistoricos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaHistóricos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaHistóricos_Load);
            this.tbMaster.ResumeLayout(false);
            this.tbVendas.ResumeLayout(false);
            this.panelDesktopSaida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtHistoricoSaida)).EndInit();
            this.panelButtos.ResumeLayout(false);
            this.tbEntrada.ResumeLayout(false);
            this.panelDesktopEntrada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtEntradas)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbMaster;
        private TabPage tbVendas;
        private Panel panelDesktopSaida;
        private Panel panelButtos;
        private TabPage tbEntrada;
        private Button btnInformacoes;
        private Button btnTabelas;
        private DataGridView dtHistoricoSaida;
        private DataGridViewTextBoxColumn dtID;
        private DataGridViewTextBoxColumn dtCliente;
        private DataGridViewTextBoxColumn dtFuncionario;
        private DataGridViewTextBoxColumn dtData;
        private DataGridViewTextBoxColumn dtFormaPag;
        private DataGridViewTextBoxColumn dtValorTotal;
        private Panel panelDesktopEntrada;
        private DataGridView dtEntradas;
        private DataGridViewTextBoxColumn IdEntrada;
        private DataGridViewTextBoxColumn FornecedorEntrada;
        private DataGridViewTextBoxColumn FuncionarioEntrada;
        private DataGridViewTextBoxColumn DataEntrada;
        private DataGridViewTextBoxColumn ValorEntrada;
        private Panel panelButtons;
        private Button btnTabelaEntrada;
        private Button btnInfoEntrada;
        private Label lblDataEntrada;
        private Label lblDataSaida;
        private Button btnFilter;
        private DateTimePicker dateSaida;
        private DateTimePicker dateEntrada;
    }
}