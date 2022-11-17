namespace WFPresentationLayer
{
    partial class TelaFornecedor
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.dtFornecedor = new System.Windows.Forms.DataGridView();
            this.ForneID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForneRazao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForneNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForneCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForneEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForneTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForneIsAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.ckIsAtivo = new System.Windows.Forms.CheckBox();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(28, 369);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(95, 52);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(129, 369);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 52);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(230, 369);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 52);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.ForeColor = System.Drawing.Color.White;
            this.lblCnpj.Location = new System.Drawing.Point(53, 96);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(37, 15);
            this.lblCnpj.TabIndex = 3;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // dtFornecedor
            // 
            this.dtFornecedor.AllowUserToAddRows = false;
            this.dtFornecedor.AllowUserToDeleteRows = false;
            this.dtFornecedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ForneID,
            this.ForneRazao,
            this.ForneNome,
            this.ForneCNPJ,
            this.ForneEmail,
            this.ForneTelefone,
            this.ForneIsAtivo});
            this.dtFornecedor.Location = new System.Drawing.Point(367, 12);
            this.dtFornecedor.Name = "dtFornecedor";
            this.dtFornecedor.ReadOnly = true;
            this.dtFornecedor.RowTemplate.Height = 25;
            this.dtFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtFornecedor.Size = new System.Drawing.Size(553, 473);
            this.dtFornecedor.TabIndex = 5;
            this.dtFornecedor.DoubleClick += new System.EventHandler(this.dtFornecedor_DoubleClick);
            // 
            // ForneID
            // 
            this.ForneID.HeaderText = "ID";
            this.ForneID.Name = "ForneID";
            this.ForneID.ReadOnly = true;
            // 
            // ForneRazao
            // 
            this.ForneRazao.HeaderText = "Razão Social";
            this.ForneRazao.Name = "ForneRazao";
            this.ForneRazao.ReadOnly = true;
            // 
            // ForneNome
            // 
            this.ForneNome.HeaderText = "Nome";
            this.ForneNome.Name = "ForneNome";
            this.ForneNome.ReadOnly = true;
            // 
            // ForneCNPJ
            // 
            this.ForneCNPJ.HeaderText = "CNPJ";
            this.ForneCNPJ.Name = "ForneCNPJ";
            this.ForneCNPJ.ReadOnly = true;
            // 
            // ForneEmail
            // 
            this.ForneEmail.HeaderText = "Email";
            this.ForneEmail.Name = "ForneEmail";
            this.ForneEmail.ReadOnly = true;
            // 
            // ForneTelefone
            // 
            this.ForneTelefone.HeaderText = "Telefone";
            this.ForneTelefone.Name = "ForneTelefone";
            this.ForneTelefone.ReadOnly = true;
            // 
            // ForneIsAtivo
            // 
            this.ForneIsAtivo.HeaderText = "Está Ativo";
            this.ForneIsAtivo.Name = "ForneIsAtivo";
            this.ForneIsAtivo.ReadOnly = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(97, 122);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(53, 125);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(36, 154);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(55, 15);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(97, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(53, 183);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(97, 24);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 15;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(53, 27);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 15);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID:";
            // 
            // ckIsAtivo
            // 
            this.ckIsAtivo.AutoSize = true;
            this.ckIsAtivo.Checked = true;
            this.ckIsAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckIsAtivo.ForeColor = System.Drawing.Color.White;
            this.ckIsAtivo.Location = new System.Drawing.Point(97, 215);
            this.ckIsAtivo.Name = "ckIsAtivo";
            this.ckIsAtivo.Size = new System.Drawing.Size(78, 19);
            this.ckIsAtivo.TabIndex = 16;
            this.ckIsAtivo.Text = "Está Ativo";
            this.ckIsAtivo.UseVisualStyleBackColor = true;
            // 
            // txtRazao
            // 
            this.txtRazao.Location = new System.Drawing.Point(97, 64);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(100, 23);
            this.txtRazao.TabIndex = 18;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.ForeColor = System.Drawing.Color.White;
            this.lblRazaoSocial.Location = new System.Drawing.Point(21, 67);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(75, 15);
            this.lblRazaoSocial.TabIndex = 17;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Location = new System.Drawing.Point(97, 93);
            this.mskCNPJ.Mask = "00, 000, 000/0001-00";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.Size = new System.Drawing.Size(100, 23);
            this.mskCNPJ.TabIndex = 19;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(97, 151);
            this.mskTelefone.Mask = "(00) 0 00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(100, 23);
            this.mskTelefone.TabIndex = 44;
            // 
            // TelaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(932, 497);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.mskCNPJ);
            this.Controls.Add(this.txtRazao);
            this.Controls.Add(this.lblRazaoSocial);
            this.Controls.Add(this.ckIsAtivo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dtFornecedor);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "TelaFornecedor";
            this.Text = "TelaFornecedor";
            this.Load += new System.EventHandler(this.TelaFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCadastrar;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblCnpj;
        private DataGridView dtFornecedor;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblTelefone;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtID;
        private Label lblID;
        private CheckBox ckIsAtivo;
        private TextBox txtRazao;
        private Label lblRazaoSocial;
        private DataGridViewTextBoxColumn ForneID;
        private DataGridViewTextBoxColumn ForneRazao;
        private DataGridViewTextBoxColumn ForneNome;
        private DataGridViewTextBoxColumn ForneCNPJ;
        private DataGridViewTextBoxColumn ForneEmail;
        private DataGridViewTextBoxColumn ForneTelefone;
        private DataGridViewTextBoxColumn ForneIsAtivo;
        private MaskedTextBox mskCNPJ;
        private MaskedTextBox mskTelefone;
    }
}