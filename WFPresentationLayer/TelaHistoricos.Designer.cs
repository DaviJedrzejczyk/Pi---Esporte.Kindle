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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbMaster = new System.Windows.Forms.TabControl();
            this.tbVendas = new System.Windows.Forms.TabPage();
            this.tbEntrada = new System.Windows.Forms.TabPage();
            this.panelDesktopSaida = new System.Windows.Forms.Panel();
            this.dtHistoricoSaida = new System.Windows.Forms.DataGridView();
            this.dtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFormaPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnTabelaSaida = new System.Windows.Forms.Button();
            this.panelButtos = new System.Windows.Forms.Panel();
            this.tbMaster.SuspendLayout();
            this.tbVendas.SuspendLayout();
            this.panelDesktopSaida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHistoricoSaida)).BeginInit();
            this.panelButtos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMaster
            // 
            this.tbMaster.Controls.Add(this.tbVendas);
            this.tbMaster.Controls.Add(this.tbEntrada);
            this.tbMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMaster.Location = new System.Drawing.Point(0, 0);
            this.tbMaster.Name = "tbMaster";
            this.tbMaster.SelectedIndex = 0;
            this.tbMaster.Size = new System.Drawing.Size(800, 450);
            this.tbMaster.TabIndex = 0;
            // 
            // tbVendas
            // 
            this.tbVendas.Controls.Add(this.panelDesktopSaida);
            this.tbVendas.Location = new System.Drawing.Point(4, 24);
            this.tbVendas.Name = "tbVendas";
            this.tbVendas.Padding = new System.Windows.Forms.Padding(3);
            this.tbVendas.Size = new System.Drawing.Size(792, 422);
            this.tbVendas.TabIndex = 0;
            this.tbVendas.Text = "Vendas";
            this.tbVendas.UseVisualStyleBackColor = true;
            // 
            // tbEntrada
            // 
            this.tbEntrada.Location = new System.Drawing.Point(4, 24);
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.Padding = new System.Windows.Forms.Padding(3);
            this.tbEntrada.Size = new System.Drawing.Size(792, 422);
            this.tbEntrada.TabIndex = 1;
            this.tbEntrada.Text = "Entradas";
            this.tbEntrada.UseVisualStyleBackColor = true;
            this.tbEntrada.Click += new System.EventHandler(this.tbEntrada_Click);
            // 
            // panelDesktopSaida
            // 
            this.panelDesktopSaida.Controls.Add(this.dtHistoricoSaida);
            this.panelDesktopSaida.Controls.Add(this.panelButtos);
            this.panelDesktopSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopSaida.Location = new System.Drawing.Point(3, 3);
            this.panelDesktopSaida.Name = "panelDesktopSaida";
            this.panelDesktopSaida.Size = new System.Drawing.Size(786, 416);
            this.panelDesktopSaida.TabIndex = 0;
            // 
            // dtHistoricoSaida
            // 
            this.dtHistoricoSaida.AllowUserToAddRows = false;
            this.dtHistoricoSaida.AllowUserToDeleteRows = false;
            this.dtHistoricoSaida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtHistoricoSaida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtHistoricoSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHistoricoSaida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtID,
            this.dtCliente,
            this.dtFuncionario,
            this.dtData,
            this.dtFormaPag,
            this.dtValorTotal});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtHistoricoSaida.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtHistoricoSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtHistoricoSaida.Location = new System.Drawing.Point(0, 0);
            this.dtHistoricoSaida.Name = "dtHistoricoSaida";
            this.dtHistoricoSaida.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtHistoricoSaida.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtHistoricoSaida.RowTemplate.Height = 25;
            this.dtHistoricoSaida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtHistoricoSaida.Size = new System.Drawing.Size(598, 416);
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
            // btnInfo
            // 
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(30, 119);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(137, 85);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Informções da Saída";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnTabelaSaida
            // 
            this.btnTabelaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabelaSaida.Location = new System.Drawing.Point(30, 28);
            this.btnTabelaSaida.Name = "btnTabelaSaida";
            this.btnTabelaSaida.Size = new System.Drawing.Size(137, 85);
            this.btnTabelaSaida.TabIndex = 0;
            this.btnTabelaSaida.Text = "Tabela Saida";
            this.btnTabelaSaida.UseVisualStyleBackColor = true;
            // 
            // panelButtos
            // 
            this.panelButtos.Controls.Add(this.btnInfo);
            this.panelButtos.Controls.Add(this.btnTabelaSaida);
            this.panelButtos.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtos.Location = new System.Drawing.Point(598, 0);
            this.panelButtos.Name = "panelButtos";
            this.panelButtos.Size = new System.Drawing.Size(188, 416);
            this.panelButtos.TabIndex = 3;
            // 
            // TelaHistóricos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbMaster);
            this.Name = "TelaHistóricos";
            this.Text = "TelaHistóricos";
            this.Load += new System.EventHandler(this.TelaHistóricos_Load);
            this.tbMaster.ResumeLayout(false);
            this.tbVendas.ResumeLayout(false);
            this.panelDesktopSaida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtHistoricoSaida)).EndInit();
            this.panelButtos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbMaster;
        private TabPage tbVendas;
        private Panel panelDesktopSaida;
        private DataGridView dtHistoricoSaida;
        private DataGridViewTextBoxColumn dtID;
        private DataGridViewTextBoxColumn dtCliente;
        private DataGridViewTextBoxColumn dtFuncionario;
        private DataGridViewTextBoxColumn dtData;
        private DataGridViewTextBoxColumn dtFormaPag;
        private DataGridViewTextBoxColumn dtValorTotal;
        private Panel panelButtos;
        private Button btnInfo;
        private Button btnTabelaSaida;
        private TabPage tbEntrada;
    }
}