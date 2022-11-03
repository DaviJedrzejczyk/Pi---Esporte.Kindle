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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtInfoSaida = new System.Windows.Forms.DataGridView();
            this.dtProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFormaPagamento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInfoSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.txtFormaPagamento);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtValorTotal);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDesconto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(714, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 496);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.txtData);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtFuncionario);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtCliente);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 100);
            this.panel2.TabIndex = 2;
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
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(378, 51);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(123, 23);
            this.txtData.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "ID";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Enabled = false;
            this.txtFuncionario.Location = new System.Drawing.Point(270, 51);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(100, 23);
            this.txtFuncionario.TabIndex = 16;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(77, 51);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(44, 23);
            this.txtID.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Funcionario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(378, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Data";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(136, 51);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(128, 23);
            this.txtCliente.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cliente";
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.Enabled = false;
            this.txtFormaPagamento.Location = new System.Drawing.Point(20, 60);
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Size = new System.Drawing.Size(100, 23);
            this.txtFormaPagamento.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Valor Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Forma Pagamento";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValorTotal.Location = new System.Drawing.Point(20, 192);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(100, 23);
            this.txtValorTotal.TabIndex = 22;
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(20, 104);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Valor";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Location = new System.Drawing.Point(20, 148);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 23);
            this.txtDesconto.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Desconto";
            // 
            // TelaInformacoesAdicionais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 496);
            this.Controls.Add(this.dtInfoSaida);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TelaInformacoesAdicionais";
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
        private Label label8;
        private Label label6;
        private TextBox txtValorTotal;
        private TextBox txtValor;
        private Label label3;
        private TextBox txtDesconto;
        private Label label5;
        private Panel panel2;
        private TextBox txtData;
        private Label label7;
        private TextBox txtFuncionario;
        private TextBox txtID;
        private Label label2;
        private Label label4;
        private TextBox txtCliente;
        private Label label1;
        private DataGridView dtInfoSaida;
        private DataGridViewTextBoxColumn dtProduto;
        private DataGridViewTextBoxColumn dtQuantidade;
        private DataGridViewTextBoxColumn dtValorUnitario;
    }
}