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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.btnAddCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQtdItens = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotPag = new System.Windows.Forms.TextBox();
            this.dtTelaVenda = new System.Windows.Forms.DataGridView();
            this.IDVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdeVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.btnRetirarProduto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAdicionarProduto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbFormaPag = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCadastrarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRegistrarVenda = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dateTelaVenda = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTelaVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 48);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "V e n d a s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCliente.Location = new System.Drawing.Point(30, 103);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(224, 29);
            this.txtCliente.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(272, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data Venda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(568, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "CPF";
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCpf.Location = new System.Drawing.Point(568, 103);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(195, 29);
            this.txtCpf.TabIndex = 12;
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Depth = 0;
            this.btnAddCliente.Location = new System.Drawing.Point(643, 146);
            this.btnAddCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Primary = true;
            this.btnAddCliente.Size = new System.Drawing.Size(109, 42);
            this.btnAddCliente.TabIndex = 14;
            this.btnAddCliente.Text = "Adicionar Cliente";
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(824, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor.Location = new System.Drawing.Point(824, 103);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(195, 29);
            this.txtValor.TabIndex = 16;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(794, 75);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(2, 370);
            this.materialDivider1.TabIndex = 17;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(824, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Quantidade de itens";
            // 
            // txtQtdItens
            // 
            this.txtQtdItens.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQtdItens.Location = new System.Drawing.Point(824, 194);
            this.txtQtdItens.Name = "txtQtdItens";
            this.txtQtdItens.Size = new System.Drawing.Size(195, 29);
            this.txtQtdItens.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(824, 250);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total Pago";
            // 
            // txtTotPag
            // 
            this.txtTotPag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotPag.Location = new System.Drawing.Point(824, 278);
            this.txtTotPag.Name = "txtTotPag";
            this.txtTotPag.Size = new System.Drawing.Size(195, 29);
            this.txtTotPag.TabIndex = 21;
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
            this.dtTelaVenda.Location = new System.Drawing.Point(30, 240);
            this.dtTelaVenda.Name = "dtTelaVenda";
            this.dtTelaVenda.ReadOnly = true;
            this.dtTelaVenda.RowTemplate.Height = 25;
            this.dtTelaVenda.Size = new System.Drawing.Size(733, 203);
            this.dtTelaVenda.TabIndex = 22;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(30, 166);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Qtde";
            // 
            // nudQtd
            // 
            this.nudQtd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudQtd.Location = new System.Drawing.Point(30, 194);
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(120, 29);
            this.nudQtd.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(163, 166);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "Produto";
            // 
            // cbProduto
            // 
            this.cbProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(160, 194);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(165, 29);
            this.cbProduto.TabIndex = 28;
            // 
            // btnRetirarProduto
            // 
            this.btnRetirarProduto.Depth = 0;
            this.btnRetirarProduto.Location = new System.Drawing.Point(528, 194);
            this.btnRetirarProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRetirarProduto.Name = "btnRetirarProduto";
            this.btnRetirarProduto.Primary = true;
            this.btnRetirarProduto.Size = new System.Drawing.Size(109, 42);
            this.btnRetirarProduto.TabIndex = 29;
            this.btnRetirarProduto.Text = "Retirar Produto";
            this.btnRetirarProduto.UseVisualStyleBackColor = true;
            this.btnRetirarProduto.Click += new System.EventHandler(this.btnRetirarProduto_Click);
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Depth = 0;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(643, 194);
            this.btnAdicionarProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Primary = true;
            this.btnAdicionarProduto.Size = new System.Drawing.Size(109, 42);
            this.btnAdicionarProduto.TabIndex = 30;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // cbFormaPag
            // 
            this.cbFormaPag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFormaPag.FormattingEnabled = true;
            this.cbFormaPag.Location = new System.Drawing.Point(27, 491);
            this.cbFormaPag.Name = "cbFormaPag";
            this.cbFormaPag.Size = new System.Drawing.Size(196, 29);
            this.cbFormaPag.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(30, 463);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "Forma de Pagamento";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Depth = 0;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(581, 446);
            this.btnCadastrarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Primary = true;
            this.btnCadastrarCliente.Size = new System.Drawing.Size(182, 42);
            this.btnCadastrarCliente.TabIndex = 33;
            this.btnCadastrarCliente.Text = "Cadastrar novo Cliente";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnRegistrarVenda
            // 
            this.btnRegistrarVenda.Depth = 0;
            this.btnRegistrarVenda.Location = new System.Drawing.Point(835, 335);
            this.btnRegistrarVenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarVenda.Name = "btnRegistrarVenda";
            this.btnRegistrarVenda.Primary = true;
            this.btnRegistrarVenda.Size = new System.Drawing.Size(171, 37);
            this.btnRegistrarVenda.TabIndex = 34;
            this.btnRegistrarVenda.Text = "Registrar Venda";
            this.btnRegistrarVenda.UseVisualStyleBackColor = true;
            this.btnRegistrarVenda.Click += new System.EventHandler(this.btnRegistrarVenda_Click);
            // 
            // dateTelaVenda
            // 
            this.dateTelaVenda.Location = new System.Drawing.Point(272, 103);
            this.dateTelaVenda.Name = "dateTelaVenda";
            this.dateTelaVenda.Size = new System.Drawing.Size(258, 23);
            this.dateTelaVenda.TabIndex = 35;
            // 
            // TelaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 553);
            this.Controls.Add(this.dateTelaVenda);
            this.Controls.Add(this.btnRegistrarVenda);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.cbFormaPag);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.btnRetirarProduto);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudQtd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtTelaVenda);
            this.Controls.Add(this.txtTotPag);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQtdItens);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddCliente);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TelaVenda";
            this.Text = "TelaVenda";
            this.Load += new System.EventHandler(this.TelaVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTelaVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label1;
        private TextBox txtCliente;
        private Label label2;
        private Label label3;
        private TextBox txtCpf;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddCliente;
        private Label label5;
        private TextBox txtValor;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private Label label6;
        private TextBox txtQtdItens;
        private Label label7;
        private TextBox txtTotPag;
        private DataGridView dtTelaVenda;
        private Label label8;
        private NumericUpDown nudQtd;
        private Label label10;
        private ComboBox cbProduto;
        private MaterialSkin.Controls.MaterialRaisedButton btnRetirarProduto;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdicionarProduto;
        private ComboBox cbFormaPag;
        private Label label11;
        private MaterialSkin.Controls.MaterialRaisedButton btnCadastrarCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegistrarVenda;
        private DateTimePicker dateTelaVenda;
        private DataGridViewTextBoxColumn IDVenda;
        private DataGridViewTextBoxColumn NomeVenda;
        private DataGridViewTextBoxColumn QtdeVenda;
        private DataGridViewTextBoxColumn ValorVenda;
        private DataGridViewTextBoxColumn TotalVenda;
    }
}