namespace WFPresentationLayer
{
    partial class TelaFuncionario
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.dtFuncionario = new System.Windows.Forms.DataGridView();
            this.FuncionarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionarioNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionarioSobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionarioCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionarioRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionarioData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionarioIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionarioEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionarioTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionarioGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionarioNivelAcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionarioEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblConfSenha = new System.Windows.Forms.Label();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblNivelAcesso = new System.Windows.Forms.Label();
            this.cbNivelAcesso = new System.Windows.Forms.ComboBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblPonto = new System.Windows.Forms.Label();
            this.txtPonto = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEnderecoID = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 428);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(96, 42);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(114, 428);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 42);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(219, 428);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 42);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(12, 46);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 15);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(89, 43);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 5;
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(225, 43);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(100, 23);
            this.cbGenero.TabIndex = 6;
            // 
            // dtFuncionario
            // 
            this.dtFuncionario.AllowUserToAddRows = false;
            this.dtFuncionario.AllowUserToDeleteRows = false;
            this.dtFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FuncionarioID,
            this.FuncionarioNome,
            this.FuncionarioSobrenome,
            this.FuncionarioCPF,
            this.FuncionarioRG,
            this.FuncionarioData,
            this.FuncionarioIdade,
            this.FuncionarioEmail,
            this.FuncionarioTelefone,
            this.FuncionarioGenero,
            this.FuncionarioNivelAcesso,
            this.FuncionarioEndereco});
            this.dtFuncionario.Location = new System.Drawing.Point(521, 12);
            this.dtFuncionario.Name = "dtFuncionario";
            this.dtFuncionario.ReadOnly = true;
            this.dtFuncionario.RowTemplate.Height = 25;
            this.dtFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtFuncionario.Size = new System.Drawing.Size(377, 485);
            this.dtFuncionario.TabIndex = 7;
            this.dtFuncionario.DoubleClick += new System.EventHandler(this.dtFuncionario_DoubleClick);
            // 
            // FuncionarioID
            // 
            this.FuncionarioID.HeaderText = "ID";
            this.FuncionarioID.Name = "FuncionarioID";
            this.FuncionarioID.ReadOnly = true;
            this.FuncionarioID.Width = 43;
            // 
            // FuncionarioNome
            // 
            this.FuncionarioNome.HeaderText = "Nome";
            this.FuncionarioNome.Name = "FuncionarioNome";
            this.FuncionarioNome.ReadOnly = true;
            this.FuncionarioNome.Width = 65;
            // 
            // FuncionarioSobrenome
            // 
            this.FuncionarioSobrenome.HeaderText = "Sobrenome";
            this.FuncionarioSobrenome.Name = "FuncionarioSobrenome";
            this.FuncionarioSobrenome.ReadOnly = true;
            this.FuncionarioSobrenome.Width = 93;
            // 
            // FuncionarioCPF
            // 
            this.FuncionarioCPF.HeaderText = "CPF";
            this.FuncionarioCPF.Name = "FuncionarioCPF";
            this.FuncionarioCPF.ReadOnly = true;
            this.FuncionarioCPF.Width = 53;
            // 
            // FuncionarioRG
            // 
            this.FuncionarioRG.HeaderText = "RG";
            this.FuncionarioRG.Name = "FuncionarioRG";
            this.FuncionarioRG.ReadOnly = true;
            this.FuncionarioRG.Width = 47;
            // 
            // FuncionarioData
            // 
            this.FuncionarioData.HeaderText = "Data de Nascimento";
            this.FuncionarioData.Name = "FuncionarioData";
            this.FuncionarioData.ReadOnly = true;
            this.FuncionarioData.Width = 127;
            // 
            // FuncionarioIdade
            // 
            this.FuncionarioIdade.HeaderText = "Idade";
            this.FuncionarioIdade.Name = "FuncionarioIdade";
            this.FuncionarioIdade.ReadOnly = true;
            this.FuncionarioIdade.Width = 61;
            // 
            // FuncionarioEmail
            // 
            this.FuncionarioEmail.HeaderText = "Email";
            this.FuncionarioEmail.Name = "FuncionarioEmail";
            this.FuncionarioEmail.ReadOnly = true;
            this.FuncionarioEmail.Width = 61;
            // 
            // FuncionarioTelefone
            // 
            this.FuncionarioTelefone.HeaderText = "Telefone";
            this.FuncionarioTelefone.Name = "FuncionarioTelefone";
            this.FuncionarioTelefone.ReadOnly = true;
            this.FuncionarioTelefone.Width = 77;
            // 
            // FuncionarioGenero
            // 
            this.FuncionarioGenero.HeaderText = "Genero";
            this.FuncionarioGenero.Name = "FuncionarioGenero";
            this.FuncionarioGenero.ReadOnly = true;
            this.FuncionarioGenero.Width = 70;
            // 
            // FuncionarioNivelAcesso
            // 
            this.FuncionarioNivelAcesso.HeaderText = "Nível de Acesso";
            this.FuncionarioNivelAcesso.Name = "FuncionarioNivelAcesso";
            this.FuncionarioNivelAcesso.ReadOnly = true;
            this.FuncionarioNivelAcesso.Width = 106;
            // 
            // FuncionarioEndereco
            // 
            this.FuncionarioEndereco.HeaderText = "EnderecoID";
            this.FuncionarioEndereco.Name = "FuncionarioEndereco";
            this.FuncionarioEndereco.ReadOnly = true;
            this.FuncionarioEndereco.Width = 92;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(89, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 8;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(12, 87);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome:";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.ForeColor = System.Drawing.Color.White;
            this.lblSobrenome.Location = new System.Drawing.Point(12, 116);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(71, 15);
            this.lblSobrenome.TabIndex = 11;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(89, 116);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(100, 23);
            this.txtSobrenome.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(12, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(89, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 12;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(12, 177);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(42, 15);
            this.lblSenha.TabIndex = 15;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(89, 174);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 23);
            this.txtSenha.TabIndex = 14;
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.AutoSize = true;
            this.lblConfSenha.ForeColor = System.Drawing.Color.White;
            this.lblConfSenha.Location = new System.Drawing.Point(89, 200);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(99, 15);
            this.lblConfSenha.TabIndex = 17;
            this.lblConfSenha.Text = "Confrimar Senha:";
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Location = new System.Drawing.Point(89, 218);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Size = new System.Drawing.Size(100, 23);
            this.txtConfSenha.TabIndex = 16;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.ForeColor = System.Drawing.Color.White;
            this.lblRG.Location = new System.Drawing.Point(12, 255);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(25, 15);
            this.lblRG.TabIndex = 19;
            this.lblRG.Text = "RG:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(89, 252);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 23);
            this.txtRG.TabIndex = 18;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.ForeColor = System.Drawing.Color.White;
            this.lblCPF.Location = new System.Drawing.Point(12, 285);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(31, 15);
            this.lblCPF.TabIndex = 21;
            this.lblCPF.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(89, 283);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 23);
            this.txtCPF.TabIndex = 20;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(12, 322);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(34, 15);
            this.lblData.TabIndex = 23;
            this.lblData.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(89, 316);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 23);
            this.txtData.TabIndex = 22;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(225, 25);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(48, 15);
            this.lblGenero.TabIndex = 24;
            this.lblGenero.Text = "Genero:";
            // 
            // lblNivelAcesso
            // 
            this.lblNivelAcesso.AutoSize = true;
            this.lblNivelAcesso.ForeColor = System.Drawing.Color.White;
            this.lblNivelAcesso.Location = new System.Drawing.Point(225, 69);
            this.lblNivelAcesso.Name = "lblNivelAcesso";
            this.lblNivelAcesso.Size = new System.Drawing.Size(93, 15);
            this.lblNivelAcesso.TabIndex = 26;
            this.lblNivelAcesso.Text = "Nivel de Acesso:";
            // 
            // cbNivelAcesso
            // 
            this.cbNivelAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivelAcesso.FormattingEnabled = true;
            this.cbNivelAcesso.Location = new System.Drawing.Point(225, 87);
            this.cbNivelAcesso.Name = "cbNivelAcesso";
            this.cbNivelAcesso.Size = new System.Drawing.Size(100, 23);
            this.cbNivelAcesso.TabIndex = 25;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.ForeColor = System.Drawing.Color.White;
            this.lblRua.Location = new System.Drawing.Point(362, 46);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(30, 15);
            this.lblRua.TabIndex = 28;
            this.lblRua.Text = "Rua:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(415, 40);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(100, 23);
            this.txtRua.TabIndex = 27;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(225, 116);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(55, 15);
            this.lblTelefone.TabIndex = 30;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(225, 140);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 23);
            this.txtTelefone.TabIndex = 29;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(225, 184);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.ReadOnly = true;
            this.txtIdade.Size = new System.Drawing.Size(100, 23);
            this.txtIdade.TabIndex = 32;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(225, 166);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(39, 15);
            this.lblIdade.TabIndex = 31;
            this.lblIdade.Text = "Idade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.ForeColor = System.Drawing.Color.White;
            this.lblBairro.Location = new System.Drawing.Point(362, 79);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(41, 15);
            this.lblBairro.TabIndex = 34;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(415, 69);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 23);
            this.txtBairro.TabIndex = 33;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.ForeColor = System.Drawing.Color.White;
            this.lblCidade.Location = new System.Drawing.Point(362, 106);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(47, 15);
            this.lblCidade.TabIndex = 36;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(415, 98);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 23);
            this.txtCidade.TabIndex = 35;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(362, 135);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 38;
            this.lblEstado.Text = "Estado:";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(413, 132);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(102, 23);
            this.cbEstado.TabIndex = 39;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.ForeColor = System.Drawing.Color.White;
            this.lblCep.Location = new System.Drawing.Point(362, 168);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 15);
            this.lblCep.TabIndex = 41;
            this.lblCep.Text = "CEP:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(415, 163);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(100, 23);
            this.txtCEP.TabIndex = 40;
            // 
            // lblPonto
            // 
            this.lblPonto.AutoSize = true;
            this.lblPonto.ForeColor = System.Drawing.Color.White;
            this.lblPonto.Location = new System.Drawing.Point(362, 200);
            this.lblPonto.Name = "lblPonto";
            this.lblPonto.Size = new System.Drawing.Size(116, 15);
            this.lblPonto.TabIndex = 43;
            this.lblPonto.Text = "Ponto de Referência:";
            // 
            // txtPonto
            // 
            this.txtPonto.Location = new System.Drawing.Point(362, 218);
            this.txtPonto.Name = "txtPonto";
            this.txtPonto.Size = new System.Drawing.Size(116, 23);
            this.txtPonto.TabIndex = 42;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.ForeColor = System.Drawing.Color.White;
            this.lblComplemento.Location = new System.Drawing.Point(362, 252);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(87, 15);
            this.lblComplemento.TabIndex = 45;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(362, 273);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(116, 23);
            this.txtComplemento.TabIndex = 44;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.ForeColor = System.Drawing.Color.White;
            this.lblEndereco.Location = new System.Drawing.Point(362, 299);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(73, 15);
            this.lblEndereco.TabIndex = 47;
            this.lblEndereco.Text = "Endereco ID:";
            // 
            // txtEnderecoID
            // 
            this.txtEnderecoID.Location = new System.Drawing.Point(362, 319);
            this.txtEnderecoID.Name = "txtEnderecoID";
            this.txtEnderecoID.ReadOnly = true;
            this.txtEnderecoID.Size = new System.Drawing.Size(100, 23);
            this.txtEnderecoID.TabIndex = 48;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.ForeColor = System.Drawing.Color.White;
            this.lblNumero.Location = new System.Drawing.Point(238, 252);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(54, 15);
            this.lblNumero.TabIndex = 50;
            this.lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(238, 273);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(116, 23);
            this.txtNumero.TabIndex = 49;
            // 
            // TelaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(3)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(900, 519);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEnderecoID);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.lblPonto);
            this.Controls.Add(this.txtPonto);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.lblNivelAcesso);
            this.Controls.Add(this.cbNivelAcesso);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.lblConfSenha);
            this.Controls.Add(this.txtConfSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dtFuncionario);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "TelaFuncionario";
            this.Text = "TelaFuncionario";
            this.Load += new System.EventHandler(this.TelaFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnCadastrar;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblID;
        private TextBox txtID;
        private ComboBox cbGenero;
        private DataGridView dtFuncionario;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblSobrenome;
        private TextBox txtSobrenome;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblSenha;
        private TextBox txtSenha;
        private Label lblConfSenha;
        private TextBox txtConfSenha;
        private Label lblRG;
        private TextBox txtRG;
        private Label lblCPF;
        private TextBox txtCPF;
        private Label lblData;
        private TextBox txtData;
        private Label lblGenero;
        private Label lblNivelAcesso;
        private ComboBox cbNivelAcesso;
        private Label lblRua;
        private TextBox txtRua;
        private Label lblTelefone;
        private TextBox txtTelefone;
        private TextBox txtIdade;
        private Label lblIdade;
        private DataGridViewTextBoxColumn FuncionarioID;
        private DataGridViewTextBoxColumn FuncionarioNome;
        private DataGridViewTextBoxColumn FuncionarioSobrenome;
        private DataGridViewTextBoxColumn FuncionarioCPF;
        private DataGridViewTextBoxColumn FuncionarioRG;
        private DataGridViewTextBoxColumn FuncionarioData;
        private DataGridViewTextBoxColumn FuncionarioIdade;
        private DataGridViewTextBoxColumn FuncionarioEmail;
        private DataGridViewTextBoxColumn FuncionarioTelefone;
        private DataGridViewTextBoxColumn FuncionarioGenero;
        private DataGridViewTextBoxColumn FuncionarioNivelAcesso;
        private DataGridViewTextBoxColumn FuncionarioEndereco;
        private Label lblBairro;
        private TextBox txtBairro;
        private Label lblCidade;
        private TextBox txtCidade;
        private Label lblEstado;
        private ComboBox cbEstado;
        private Label lblCep;
        private TextBox txtCEP;
        private Label lblPonto;
        private TextBox txtPonto;
        private Label lblComplemento;
        private TextBox txtComplemento;
        private Label lblEndereco;
        private TextBox txtEnderecoID;
        private Label lblNumero;
        private TextBox txtNumero;
    }
}