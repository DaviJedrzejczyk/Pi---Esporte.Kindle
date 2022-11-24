namespace WFPresentationLayer
{
    partial class TelaInformacoesAdicionaisSaida
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFormaPagamento = new System.Windows.Forms.TextBox();
            this.lblFormaPag = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dtInfoSaida = new System.Windows.Forms.DataGridView();
            this.dtProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInfoSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.lblValorTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(714, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 496);
            this.panel1.TabIndex = 1;
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.Enabled = false;
            this.txtFormaPagamento.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFormaPagamento.Location = new System.Drawing.Point(608, 66);
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Size = new System.Drawing.Size(100, 28);
            this.txtFormaPagamento.TabIndex = 20;
            // 
            // lblFormaPag
            // 
            this.lblFormaPag.AutoSize = true;
            this.lblFormaPag.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFormaPag.ForeColor = System.Drawing.Color.White;
            this.lblFormaPag.Location = new System.Drawing.Point(422, 69);
            this.lblFormaPag.Name = "lblFormaPag";
            this.lblFormaPag.Size = new System.Drawing.Size(180, 21);
            this.lblFormaPag.TabIndex = 21;
            this.lblFormaPag.Text = "Forma de Pagamento:";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor.Location = new System.Drawing.Point(14, 66);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 28);
            this.txtValor.TabIndex = 16;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorTotal.ForeColor = System.Drawing.Color.White;
            this.lblValorTotal.Location = new System.Drawing.Point(14, 42);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(97, 21);
            this.lblValorTotal.TabIndex = 17;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.txtFormaPagamento);
            this.panel2.Controls.Add(this.txtData);
            this.panel2.Controls.Add(this.lblFormaPag);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.txtFuncionario);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.lblFuncionario);
            this.panel2.Controls.Add(this.lblData);
            this.panel2.Controls.Add(this.txtCliente);
            this.panel2.Controls.Add(this.lblCliente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 100);
            this.panel2.TabIndex = 2;
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtData.Location = new System.Drawing.Point(293, 66);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(123, 28);
            this.txtData.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(3, 42);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 21);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "ID:";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Enabled = false;
            this.txtFuncionario.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFuncionario.Location = new System.Drawing.Point(187, 66);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(100, 28);
            this.txtFuncionario.TabIndex = 16;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(3, 66);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(44, 28);
            this.txtID.TabIndex = 20;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblFuncionario.Location = new System.Drawing.Point(183, 42);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(104, 21);
            this.lblFuncionario.TabIndex = 17;
            this.lblFuncionario.Text = "Funcionario:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(293, 42);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(50, 21);
            this.lblData.TabIndex = 19;
            this.lblData.Text = "Data:";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCliente.Location = new System.Drawing.Point(53, 66);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(128, 28);
            this.txtCliente.TabIndex = 14;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(53, 42);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(67, 21);
            this.lblCliente.TabIndex = 15;
            this.lblCliente.Text = "Cliente:";
            // 
            // dtInfoSaida
            // 
            this.dtInfoSaida.AllowUserToAddRows = false;
            this.dtInfoSaida.AllowUserToDeleteRows = false;
            this.dtInfoSaida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtInfoSaida.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtInfoSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtInfoSaida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtProduto,
            this.dtQuantidade,
            this.dtValorUnitario});
            this.dtInfoSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtInfoSaida.Location = new System.Drawing.Point(0, 100);
            this.dtInfoSaida.Name = "dtInfoSaida";
            this.dtInfoSaida.ReadOnly = true;
            this.dtInfoSaida.RowTemplate.Height = 25;
            this.dtInfoSaida.Size = new System.Drawing.Size(714, 396);
            this.dtInfoSaida.TabIndex = 3;
            // 
            // dtProduto
            // 
            this.dtProduto.HeaderText = "Produto";
            this.dtProduto.Name = "dtProduto";
            this.dtProduto.ReadOnly = true;
            // 
            // dtQuantidade
            // 
            this.dtQuantidade.HeaderText = "Quantidade";
            this.dtQuantidade.Name = "dtQuantidade";
            this.dtQuantidade.ReadOnly = true;
            // 
            // dtValorUnitario
            // 
            this.dtValorUnitario.HeaderText = "Valor Unitario";
            this.dtValorUnitario.Name = "dtValorUnitario";
            this.dtValorUnitario.ReadOnly = true;
            // 
            // TelaInformacoesAdicionaisSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 496);
            this.Controls.Add(this.dtInfoSaida);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "TelaInformacoesAdicionaisSaida";
            this.Text = "TelaInformacoesAdicionais";
            this.Load += new System.EventHandler(this.TelaInformacoesAdicionais_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInfoSaida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txtFormaPagamento;
        private Label lblFormaPag;
        private TextBox txtValor;
        private Label lblValorTotal;
        private Panel panel2;
        private TextBox txtData;
        private Label lblID;
        private TextBox txtFuncionario;
        private TextBox txtID;
        private Label lblFuncionario;
        private Label lblData;
        private TextBox txtCliente;
        private Label lblCliente;
        private DataGridView dtInfoSaida;
        private DataGridViewTextBoxColumn dtProduto;
        private DataGridViewTextBoxColumn dtQuantidade;
        private DataGridViewTextBoxColumn dtValorUnitario;
    }
}