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
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrar.Location = new System.Drawing.Point(12, 599);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(96, 59);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(114, 599);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 59);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(219, 599);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 59);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblID.Location = new System.Drawing.Point(12, 64);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 21);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(89, 60);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 28);
            this.txtID.TabIndex = 5;
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(225, 60);
            this.cbGenero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(100, 29);
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
            this.dtFuncionario.Location = new System.Drawing.Point(521, 17);
            this.dtFuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFuncionario.Name = "dtFuncionario";
            this.dtFuncionario.ReadOnly = true;
            this.dtFuncionario.RowTemplate.Height = 25;
            this.dtFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtFuncionario.Size = new System.Drawing.Size(377, 679);
            this.dtFuncionario.TabIndex = 7;
            this.dtFuncionario.DoubleClick += new System.EventHandler(this.dtFuncionario_DoubleClick);
            // 
            // FuncionarioID
            // 
            this.FuncionarioID.HeaderText = "ID";
            this.FuncionarioID.Name = "FuncionarioID";
            this.FuncionarioID.ReadOnly = true;
            this.FuncionarioID.Width = 47;
            // 
            // FuncionarioNome
            // 
            this.FuncionarioNome.HeaderText = "Nome";
            this.FuncionarioNome.Name = "FuncionarioNome";
            this.FuncionarioNome.ReadOnly = true;
            this.FuncionarioNome.Width = 69;
            // 
            // FuncionarioSobrenome
            // 
            this.FuncionarioSobrenome.HeaderText = "Sobrenome";
            this.FuncionarioSobrenome.Name = "FuncionarioSobrenome";
            this.FuncionarioSobrenome.ReadOnly = true;
            // 
            // FuncionarioCPF
            // 
            this.FuncionarioCPF.HeaderText = "CPF";
            this.FuncionarioCPF.Name = "FuncionarioCPF";
            this.FuncionarioCPF.ReadOnly = true;
            this.FuncionarioCPF.Width = 58;
            // 
            // FuncionarioRG
            // 
            this.FuncionarioRG.HeaderText = "RG";
            this.FuncionarioRG.Name = "FuncionarioRG";
            this.FuncionarioRG.ReadOnly = true;
            this.FuncionarioRG.Width = 53;
            // 
            // FuncionarioData
            // 
            this.FuncionarioData.HeaderText = "Data de Nascimento";
            this.FuncionarioData.Name = "FuncionarioData";
            this.FuncionarioData.ReadOnly = true;
            this.FuncionarioData.Width = 147;
            // 
            // FuncionarioIdade
            // 
            this.FuncionarioIdade.HeaderText = "Idade";
            this.FuncionarioIdade.Name = "FuncionarioIdade";
            this.FuncionarioIdade.ReadOnly = true;
            this.FuncionarioIdade.Width = 66;
            // 
            // FuncionarioEmail
            // 
            this.FuncionarioEmail.HeaderText = "Email";
            this.FuncionarioEmail.Name = "FuncionarioEmail";
            this.FuncionarioEmail.ReadOnly = true;
            this.FuncionarioEmail.Width = 67;
            // 
            // FuncionarioTelefone
            // 
            this.FuncionarioTelefone.HeaderText = "Telefone";
            this.FuncionarioTelefone.Name = "FuncionarioTelefone";
            this.FuncionarioTelefone.ReadOnly = true;
            this.FuncionarioTelefone.Width = 83;
            // 
            // FuncionarioGenero
            // 
            this.FuncionarioGenero.HeaderText = "Genero";
            this.FuncionarioGenero.Name = "FuncionarioGenero";
            this.FuncionarioGenero.ReadOnly = true;
            this.FuncionarioGenero.Width = 76;
            // 
            // FuncionarioNivelAcesso
            // 
            this.FuncionarioNivelAcesso.HeaderText = "Nível de Acesso";
            this.FuncionarioNivelAcesso.Name = "FuncionarioNivelAcesso";
            this.FuncionarioNivelAcesso.ReadOnly = true;
            this.FuncionarioNivelAcesso.Width = 121;
            // 
            // FuncionarioEndereco
            // 
            this.FuncionarioEndereco.HeaderText = "EnderecoID";
            this.FuncionarioEndereco.Name = "FuncionarioEndereco";
            this.FuncionarioEndereco.ReadOnly = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(89, 111);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 28);
            this.txtNome.TabIndex = 8;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNome.Location = new System.Drawing.Point(12, 122);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(46, 21);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome:";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSobrenome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSobrenome.Location = new System.Drawing.Point(12, 162);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(77, 21);
            this.lblSobrenome.TabIndex = 11;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(89, 162);
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(100, 28);
            this.txtSobrenome.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail.Location = new System.Drawing.Point(12, 207);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 21);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(89, 203);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 28);
            this.txtEmail.TabIndex = 12;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSenha.Location = new System.Drawing.Point(12, 248);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(48, 21);
            this.lblSenha.TabIndex = 15;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(89, 244);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 28);
            this.txtSenha.TabIndex = 14;
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.AutoSize = true;
            this.lblConfSenha.ForeColor = System.Drawing.Color.White;
            this.lblConfSenha.Location = new System.Drawing.Point(89, 280);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(105, 21);
            this.lblConfSenha.TabIndex = 17;
            this.lblConfSenha.Text = "Confrimar Senha:";
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Location = new System.Drawing.Point(89, 305);
            this.txtConfSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Size = new System.Drawing.Size(100, 28);
            this.txtConfSenha.TabIndex = 16;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRG.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRG.Location = new System.Drawing.Point(12, 357);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(30, 21);
            this.lblRG.TabIndex = 19;
            this.lblRG.Text = "RG:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(89, 353);
            this.txtRG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 28);
            this.txtRG.TabIndex = 18;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCPF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCPF.Location = new System.Drawing.Point(12, 399);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(35, 21);
            this.lblCPF.TabIndex = 21;
            this.lblCPF.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(89, 396);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 28);
            this.txtCPF.TabIndex = 20;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblData.Location = new System.Drawing.Point(12, 451);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(38, 21);
            this.lblData.TabIndex = 23;
            this.lblData.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(89, 442);
            this.txtData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 28);
            this.txtData.TabIndex = 22;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGenero.Location = new System.Drawing.Point(225, 35);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(53, 21);
            this.lblGenero.TabIndex = 24;
            this.lblGenero.Text = "Genero:";
            // 
            // lblNivelAcesso
            // 
            this.lblNivelAcesso.AutoSize = true;
            this.lblNivelAcesso.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNivelAcesso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNivelAcesso.Location = new System.Drawing.Point(225, 97);
            this.lblNivelAcesso.Name = "lblNivelAcesso";
            this.lblNivelAcesso.Size = new System.Drawing.Size(98, 21);
            this.lblNivelAcesso.TabIndex = 26;
            this.lblNivelAcesso.Text = "Nivel de Acesso:";
            // 
            // cbNivelAcesso
            // 
            this.cbNivelAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivelAcesso.FormattingEnabled = true;
            this.cbNivelAcesso.Location = new System.Drawing.Point(225, 122);
            this.cbNivelAcesso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbNivelAcesso.Name = "cbNivelAcesso";
            this.cbNivelAcesso.Size = new System.Drawing.Size(100, 29);
            this.cbNivelAcesso.TabIndex = 25;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRua.Location = new System.Drawing.Point(362, 64);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(35, 21);
            this.lblRua.TabIndex = 28;
            this.lblRua.Text = "Rua:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(415, 56);
            this.txtRua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(100, 28);
            this.txtRua.TabIndex = 27;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTelefone.Location = new System.Drawing.Point(225, 162);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(60, 21);
            this.lblTelefone.TabIndex = 30;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(225, 196);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 28);
            this.txtTelefone.TabIndex = 29;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(225, 258);
            this.txtIdade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.ReadOnly = true;
            this.txtIdade.Size = new System.Drawing.Size(100, 28);
            this.txtIdade.TabIndex = 32;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIdade.Location = new System.Drawing.Point(225, 232);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(43, 21);
            this.lblIdade.TabIndex = 31;
            this.lblIdade.Text = "Idade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBairro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBairro.Location = new System.Drawing.Point(362, 111);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(45, 21);
            this.lblBairro.TabIndex = 34;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(415, 97);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 28);
            this.txtBairro.TabIndex = 33;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCidade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCidade.Location = new System.Drawing.Point(362, 148);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(51, 21);
            this.lblCidade.TabIndex = 36;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(415, 137);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 28);
            this.txtCidade.TabIndex = 35;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEstado.Location = new System.Drawing.Point(362, 189);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 21);
            this.lblEstado.TabIndex = 38;
            this.lblEstado.Text = "Estado:";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(413, 185);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(102, 29);
            this.cbEstado.TabIndex = 39;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCep.Location = new System.Drawing.Point(362, 235);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(36, 21);
            this.lblCep.TabIndex = 41;
            this.lblCep.Text = "CEP:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(415, 228);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(100, 28);
            this.txtCEP.TabIndex = 40;
            // 
            // lblPonto
            // 
            this.lblPonto.AutoSize = true;
            this.lblPonto.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPonto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPonto.Location = new System.Drawing.Point(362, 280);
            this.lblPonto.Name = "lblPonto";
            this.lblPonto.Size = new System.Drawing.Size(124, 21);
            this.lblPonto.TabIndex = 43;
            this.lblPonto.Text = "Ponto de Referência:";
            // 
            // txtPonto
            // 
            this.txtPonto.Location = new System.Drawing.Point(362, 305);
            this.txtPonto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPonto.Name = "txtPonto";
            this.txtPonto.Size = new System.Drawing.Size(116, 28);
            this.txtPonto.TabIndex = 42;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComplemento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblComplemento.Location = new System.Drawing.Point(362, 353);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(90, 21);
            this.lblComplemento.TabIndex = 45;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(362, 382);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(116, 28);
            this.txtComplemento.TabIndex = 44;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEndereco.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEndereco.Location = new System.Drawing.Point(362, 419);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(80, 21);
            this.lblEndereco.TabIndex = 47;
            this.lblEndereco.Text = "Endereco ID:";
            // 
            // txtEnderecoID
            // 
            this.txtEnderecoID.Location = new System.Drawing.Point(362, 447);
            this.txtEnderecoID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEnderecoID.Name = "txtEnderecoID";
            this.txtEnderecoID.ReadOnly = true;
            this.txtEnderecoID.Size = new System.Drawing.Size(100, 28);
            this.txtEnderecoID.TabIndex = 48;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumero.Location = new System.Drawing.Point(238, 353);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(57, 21);
            this.lblNumero.TabIndex = 50;
            this.lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(238, 382);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(116, 28);
            this.txtNumero.TabIndex = 49;
            // 
            // TelaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(900, 727);
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
            this.Font = new System.Drawing.Font("Noto Naskh Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TelaFuncionario";
            this.Text = "TelaFuncionario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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