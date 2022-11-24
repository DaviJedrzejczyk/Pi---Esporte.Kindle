namespace WFPresentationLayer
{
    partial class TelaVenda
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
            this.dateTelaVenda = new System.Windows.Forms.DateTimePicker();
            this.cbFormaPag = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dtTelaVenda = new System.Windows.Forms.DataGridView();
            this.IDVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdeVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotPag = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQtdItens = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.btnRetirarProduto = new System.Windows.Forms.Button();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.btnRegistrarVenda = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTelaVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTelaVenda
            // 
            this.dateTelaVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTelaVenda.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTelaVenda.Location = new System.Drawing.Point(341, 183);
            this.dateTelaVenda.Name = "dateTelaVenda";
            this.dateTelaVenda.Size = new System.Drawing.Size(258, 28);
            this.dateTelaVenda.TabIndex = 54;
            // 
            // cbFormaPag
            // 
            this.cbFormaPag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFormaPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPag.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFormaPag.FormattingEnabled = true;
            this.cbFormaPag.Location = new System.Drawing.Point(1205, 493);
            this.cbFormaPag.Name = "cbFormaPag";
            this.cbFormaPag.Size = new System.Drawing.Size(196, 29);
            this.cbFormaPag.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1208, 465);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 21);
            this.label11.TabIndex = 52;
            this.label11.Text = "Forma de Pagamento";
            // 
            // cbProduto
            // 
            this.cbProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduto.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(170, 182);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(165, 29);
            this.cbProduto.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(170, 158);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 21);
            this.label10.TabIndex = 50;
            this.label10.Text = "Produto:";
            // 
            // nudQtd
            // 
            this.nudQtd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudQtd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudQtd.Location = new System.Drawing.Point(44, 183);
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(120, 28);
            this.nudQtd.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(44, 159);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 48;
            this.label8.Text = "Quantidade:";
            // 
            // dtTelaVenda
            // 
            this.dtTelaVenda.AllowUserToAddRows = false;
            this.dtTelaVenda.AllowUserToDeleteRows = false;
            this.dtTelaVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtTelaVenda.BackgroundColor = System.Drawing.Color.DimGray;
            this.dtTelaVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTelaVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDVenda,
            this.NomeVenda,
            this.QtdeVenda,
            this.ValorVenda,
            this.TotalVenda});
            this.dtTelaVenda.Location = new System.Drawing.Point(28, 414);
            this.dtTelaVenda.Name = "dtTelaVenda";
            this.dtTelaVenda.ReadOnly = true;
            this.dtTelaVenda.RowTemplate.Height = 25;
            this.dtTelaVenda.Size = new System.Drawing.Size(869, 340);
            this.dtTelaVenda.TabIndex = 47;
            // 
            // IDVenda
            // 
            this.IDVenda.HeaderText = "ID";
            this.IDVenda.Name = "IDVenda";
            this.IDVenda.ReadOnly = true;
            // 
            // NomeVenda
            // 
            this.NomeVenda.HeaderText = "Nome";
            this.NomeVenda.Name = "NomeVenda";
            this.NomeVenda.ReadOnly = true;
            // 
            // QtdeVenda
            // 
            this.QtdeVenda.HeaderText = "Quantidade";
            this.QtdeVenda.Name = "QtdeVenda";
            this.QtdeVenda.ReadOnly = true;
            // 
            // ValorVenda
            // 
            this.ValorVenda.HeaderText = "Valor";
            this.ValorVenda.Name = "ValorVenda";
            this.ValorVenda.ReadOnly = true;
            // 
            // TotalVenda
            // 
            this.TotalVenda.HeaderText = "Total";
            this.TotalVenda.Name = "TotalVenda";
            this.TotalVenda.ReadOnly = true;
            // 
            // txtTotPag
            // 
            this.txtTotPag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotPag.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotPag.Location = new System.Drawing.Point(1208, 392);
            this.txtTotPag.Name = "txtTotPag";
            this.txtTotPag.Size = new System.Drawing.Size(195, 28);
            this.txtTotPag.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1208, 364);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 45;
            this.label7.Text = "Total Pago";
            // 
            // txtQtdItens
            // 
            this.txtQtdItens.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQtdItens.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQtdItens.Location = new System.Drawing.Point(1208, 308);
            this.txtQtdItens.Name = "txtQtdItens";
            this.txtQtdItens.Size = new System.Drawing.Size(195, 28);
            this.txtQtdItens.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1208, 280);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 21);
            this.label6.TabIndex = 43;
            this.label6.Text = "Quantidade de itens";
            // 
            // txtValor
            // 
            this.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor.Location = new System.Drawing.Point(1208, 217);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(195, 28);
            this.txtValor.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1208, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 41;
            this.label5.Text = "Valor";
            // 
            // txtCpf
            // 
            this.txtCpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCpf.Location = new System.Drawing.Point(605, 182);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(195, 28);
            this.txtCpf.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(605, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(341, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Data da Venda:";
            // 
            // txtCliente
            // 
            this.txtCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCliente.Location = new System.Drawing.Point(44, 111);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(224, 28);
            this.txtCliente.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Cliente";
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddCliente.ForeColor = System.Drawing.Color.White;
            this.btnAddCliente.Location = new System.Drawing.Point(605, 217);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(195, 42);
            this.btnAddCliente.TabIndex = 55;
            this.btnAddCliente.Text = "Adicionar Cliente";
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click_1);
            // 
            // btnRetirarProduto
            // 
            this.btnRetirarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetirarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetirarProduto.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRetirarProduto.ForeColor = System.Drawing.Color.White;
            this.btnRetirarProduto.Location = new System.Drawing.Point(702, 364);
            this.btnRetirarProduto.Name = "btnRetirarProduto";
            this.btnRetirarProduto.Size = new System.Drawing.Size(195, 42);
            this.btnRetirarProduto.TabIndex = 56;
            this.btnRetirarProduto.Text = "Retirar Produto";
            this.btnRetirarProduto.UseVisualStyleBackColor = true;
            this.btnRetirarProduto.Click += new System.EventHandler(this.btnRetirarProduto_Click_1);
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarProduto.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionarProduto.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(501, 364);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(195, 42);
            this.btnAdicionarProduto.TabIndex = 57;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click_1);
            // 
            // btnRegistrarVenda
            // 
            this.btnRegistrarVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVenda.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarVenda.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarVenda.Location = new System.Drawing.Point(903, 677);
            this.btnRegistrarVenda.Name = "btnRegistrarVenda";
            this.btnRegistrarVenda.Size = new System.Drawing.Size(243, 77);
            this.btnRegistrarVenda.TabIndex = 58;
            this.btnRegistrarVenda.Text = "Registrar Venda";
            this.btnRegistrarVenda.UseVisualStyleBackColor = true;
            this.btnRegistrarVenda.Click += new System.EventHandler(this.btnRegistrarVenda_Click_1);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarCliente.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(1460, 677);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(243, 77);
            this.btnCadastrarCliente.TabIndex = 59;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click_1);
            // 
            // TelaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1715, 902);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.btnRegistrarVenda);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.btnRetirarProduto);
            this.Controls.Add(this.btnAddCliente);
            this.Controls.Add(this.dateTelaVenda);
            this.Controls.Add(this.cbFormaPag);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudQtd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtTelaVenda);
            this.Controls.Add(this.txtTotPag);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQtdItens);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "TelaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaVenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTelaVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTelaVenda;
        private ComboBox cbFormaPag;
        private Label label11;
        private ComboBox cbProduto;
        private Label label10;
        private NumericUpDown nudQtd;
        private Label label8;
        private DataGridView dtTelaVenda;
        private DataGridViewTextBoxColumn IDVenda;
        private DataGridViewTextBoxColumn NomeVenda;
        private DataGridViewTextBoxColumn QtdeVenda;
        private DataGridViewTextBoxColumn ValorVenda;
        private DataGridViewTextBoxColumn TotalVenda;
        private TextBox txtTotPag;
        private Label label7;
        private TextBox txtQtdItens;
        private Label label6;
        private TextBox txtValor;
        private Label label5;
        private TextBox txtCpf;
        private Label label3;
        private Label label2;
        private TextBox txtCliente;
        private Label label1;
        private Button btnAddCliente;
        private Button btnRetirarProduto;
        private Button btnAdicionarProduto;
        private Button btnRegistrarVenda;
        private Button btnCadastrarCliente;
    }
}