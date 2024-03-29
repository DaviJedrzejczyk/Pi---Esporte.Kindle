﻿namespace WFPresentationLayer
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
            this.mskDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.mskdCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblPonto = new System.Windows.Forms.Label();
            this.txtPonto = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblNivelAcesso = new System.Windows.Forms.Label();
            this.cbNivelAcesso = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblConfSenha = new System.Windows.Forms.Label();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblIDEndereco = new System.Windows.Forms.Label();
            this.txtEnderecoID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFuncionario
            // 
            this.dtFuncionario.AllowUserToAddRows = false;
            this.dtFuncionario.AllowUserToDeleteRows = false;
            this.dtFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtFuncionario.BackgroundColor = System.Drawing.SystemColors.Window;
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
            this.dtFuncionario.Location = new System.Drawing.Point(768, 103);
            this.dtFuncionario.Name = "dtFuncionario";
            this.dtFuncionario.ReadOnly = true;
            this.dtFuncionario.RowTemplate.Height = 25;
            this.dtFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtFuncionario.Size = new System.Drawing.Size(923, 717);
            this.dtFuncionario.TabIndex = 145;
            // 
            // FuncionarioID
            // 
            this.FuncionarioID.HeaderText = "ID";
            this.FuncionarioID.Name = "FuncionarioID";
            this.FuncionarioID.ReadOnly = true;
            // 
            // FuncionarioNome
            // 
            this.FuncionarioNome.HeaderText = "Nome";
            this.FuncionarioNome.Name = "FuncionarioNome";
            this.FuncionarioNome.ReadOnly = true;
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
            // 
            // FuncionarioRG
            // 
            this.FuncionarioRG.HeaderText = "RG";
            this.FuncionarioRG.Name = "FuncionarioRG";
            this.FuncionarioRG.ReadOnly = true;
            // 
            // FuncionarioData
            // 
            this.FuncionarioData.HeaderText = "Data de Nascimento";
            this.FuncionarioData.Name = "FuncionarioData";
            this.FuncionarioData.ReadOnly = true;
            // 
            // FuncionarioIdade
            // 
            this.FuncionarioIdade.HeaderText = "Idade";
            this.FuncionarioIdade.Name = "FuncionarioIdade";
            this.FuncionarioIdade.ReadOnly = true;
            // 
            // FuncionarioEmail
            // 
            this.FuncionarioEmail.HeaderText = "Email";
            this.FuncionarioEmail.Name = "FuncionarioEmail";
            this.FuncionarioEmail.ReadOnly = true;
            // 
            // FuncionarioTelefone
            // 
            this.FuncionarioTelefone.HeaderText = "Telefone";
            this.FuncionarioTelefone.Name = "FuncionarioTelefone";
            this.FuncionarioTelefone.ReadOnly = true;
            // 
            // FuncionarioGenero
            // 
            this.FuncionarioGenero.HeaderText = "Genero";
            this.FuncionarioGenero.Name = "FuncionarioGenero";
            this.FuncionarioGenero.ReadOnly = true;
            // 
            // FuncionarioNivelAcesso
            // 
            this.FuncionarioNivelAcesso.HeaderText = "Nível de Acesso";
            this.FuncionarioNivelAcesso.Name = "FuncionarioNivelAcesso";
            this.FuncionarioNivelAcesso.ReadOnly = true;
            // 
            // FuncionarioEndereco
            // 
            this.FuncionarioEndereco.HeaderText = "EnderecoID";
            this.FuncionarioEndereco.Name = "FuncionarioEndereco";
            this.FuncionarioEndereco.ReadOnly = true;
            // 
            // mskDataNasc
            // 
            this.mskDataNasc.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskDataNasc.Location = new System.Drawing.Point(130, 347);
            this.mskDataNasc.Mask = "00/00/0000";
            this.mskDataNasc.Name = "mskDataNasc";
            this.mskDataNasc.Size = new System.Drawing.Size(157, 28);
            this.mskDataNasc.TabIndex = 144;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTelefone.Location = new System.Drawing.Point(130, 509);
            this.mskTelefone.Mask = "(00) 0 00000-000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(157, 28);
            this.mskTelefone.TabIndex = 143;
            // 
            // mskCEP
            // 
            this.mskCEP.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskCEP.Location = new System.Drawing.Point(470, 127);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(100, 28);
            this.mskCEP.TabIndex = 142;
            // 
            // mskdCPF
            // 
            this.mskdCPF.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskdCPF.Location = new System.Drawing.Point(130, 294);
            this.mskdCPF.Mask = "000,000,000-00";
            this.mskdCPF.Name = "mskdCPF";
            this.mskdCPF.Size = new System.Drawing.Size(157, 28);
            this.mskdCPF.TabIndex = 141;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumero.ForeColor = System.Drawing.Color.White;
            this.lblNumero.Location = new System.Drawing.Point(470, 325);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(77, 21);
            this.lblNumero.TabIndex = 140;
            this.lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero.Location = new System.Drawing.Point(470, 347);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 28);
            this.txtNumero.TabIndex = 139;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComplemento.ForeColor = System.Drawing.Color.White;
            this.lblComplemento.Location = new System.Drawing.Point(470, 429);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(123, 21);
            this.lblComplemento.TabIndex = 138;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComplemento.Location = new System.Drawing.Point(470, 454);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(163, 28);
            this.txtComplemento.TabIndex = 137;
            // 
            // lblPonto
            // 
            this.lblPonto.AutoSize = true;
            this.lblPonto.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPonto.ForeColor = System.Drawing.Color.White;
            this.lblPonto.Location = new System.Drawing.Point(469, 378);
            this.lblPonto.Name = "lblPonto";
            this.lblPonto.Size = new System.Drawing.Size(169, 21);
            this.lblPonto.TabIndex = 136;
            this.lblPonto.Text = "Ponto de Referência:";
            // 
            // txtPonto
            // 
            this.txtPonto.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPonto.Location = new System.Drawing.Point(469, 398);
            this.txtPonto.Name = "txtPonto";
            this.txtPonto.Size = new System.Drawing.Size(162, 28);
            this.txtPonto.TabIndex = 135;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCep.ForeColor = System.Drawing.Color.White;
            this.lblCep.Location = new System.Drawing.Point(469, 103);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(44, 21);
            this.lblCep.TabIndex = 134;
            this.lblCep.Text = "CEP:";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(648, 127);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(100, 29);
            this.cbEstado.TabIndex = 133;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(648, 103);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(65, 21);
            this.lblEstado.TabIndex = 132;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCidade.ForeColor = System.Drawing.Color.White;
            this.lblCidade.Location = new System.Drawing.Point(470, 270);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(67, 21);
            this.lblCidade.TabIndex = 131;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCidade.Location = new System.Drawing.Point(470, 294);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(162, 28);
            this.txtCidade.TabIndex = 130;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBairro.ForeColor = System.Drawing.Color.White;
            this.lblBairro.Location = new System.Drawing.Point(470, 215);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(59, 21);
            this.lblBairro.TabIndex = 129;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBairro.Location = new System.Drawing.Point(469, 239);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(162, 28);
            this.txtBairro.TabIndex = 128;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(130, 485);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(80, 21);
            this.lblTelefone.TabIndex = 127;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRua.ForeColor = System.Drawing.Color.White;
            this.lblRua.Location = new System.Drawing.Point(470, 160);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(43, 21);
            this.lblRua.TabIndex = 126;
            this.lblRua.Text = "Rua:";
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRua.Location = new System.Drawing.Point(469, 184);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(162, 28);
            this.txtRua.TabIndex = 125;
            // 
            // lblNivelAcesso
            // 
            this.lblNivelAcesso.AutoSize = true;
            this.lblNivelAcesso.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNivelAcesso.ForeColor = System.Drawing.Color.White;
            this.lblNivelAcesso.Location = new System.Drawing.Point(130, 429);
            this.lblNivelAcesso.Name = "lblNivelAcesso";
            this.lblNivelAcesso.Size = new System.Drawing.Size(133, 21);
            this.lblNivelAcesso.TabIndex = 124;
            this.lblNivelAcesso.Text = "Nivel de Acesso:";
            // 
            // cbNivelAcesso
            // 
            this.cbNivelAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivelAcesso.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbNivelAcesso.FormattingEnabled = true;
            this.cbNivelAcesso.Location = new System.Drawing.Point(130, 453);
            this.cbNivelAcesso.Name = "cbNivelAcesso";
            this.cbNivelAcesso.Size = new System.Drawing.Size(157, 29);
            this.cbNivelAcesso.TabIndex = 123;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(130, 373);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(70, 21);
            this.lblGenero.TabIndex = 122;
            this.lblGenero.Text = "Genero:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(130, 323);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(170, 21);
            this.lblData.TabIndex = 121;
            this.lblData.Text = "Data de Nascimento:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCPF.ForeColor = System.Drawing.Color.White;
            this.lblCPF.Location = new System.Drawing.Point(130, 270);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(44, 21);
            this.lblCPF.TabIndex = 120;
            this.lblCPF.Text = "CPF:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRG.ForeColor = System.Drawing.Color.White;
            this.lblRG.Location = new System.Drawing.Point(130, 215);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(36, 21);
            this.lblRG.TabIndex = 119;
            this.lblRG.Text = "RG:";
            // 
            // txtRG
            // 
            this.txtRG.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRG.Location = new System.Drawing.Point(130, 239);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(157, 28);
            this.txtRG.TabIndex = 118;
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.AutoSize = true;
            this.lblConfSenha.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfSenha.ForeColor = System.Drawing.Color.White;
            this.lblConfSenha.Location = new System.Drawing.Point(293, 215);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(143, 21);
            this.lblConfSenha.TabIndex = 117;
            this.lblConfSenha.Text = "Confrimar Senha:";
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfSenha.Location = new System.Drawing.Point(297, 239);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Size = new System.Drawing.Size(139, 28);
            this.txtConfSenha.TabIndex = 116;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(297, 160);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(61, 21);
            this.lblSenha.TabIndex = 115;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.Location = new System.Drawing.Point(297, 184);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(139, 28);
            this.txtSenha.TabIndex = 114;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(293, 103);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 21);
            this.lblEmail.TabIndex = 113;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(297, 127);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(139, 28);
            this.txtEmail.TabIndex = 112;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSobrenome.ForeColor = System.Drawing.Color.White;
            this.lblSobrenome.Location = new System.Drawing.Point(130, 160);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(102, 21);
            this.lblSobrenome.TabIndex = 111;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSobrenome.Location = new System.Drawing.Point(130, 184);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(157, 28);
            this.txtSobrenome.TabIndex = 110;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(130, 103);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 21);
            this.lblNome.TabIndex = 109;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(130, 127);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(157, 28);
            this.txtNome.TabIndex = 108;
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(130, 397);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(157, 29);
            this.cbGenero.TabIndex = 107;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(529, 749);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(193, 71);
            this.btnDelete.TabIndex = 106;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(330, 749);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(193, 71);
            this.btnUpdate.TabIndex = 105;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(130, 749);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(193, 71);
            this.btnCadastrar.TabIndex = 104;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(130, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
            this.label1.TabIndex = 147;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(130, 69);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(157, 28);
            this.txtID.TabIndex = 146;
            // 
            // lblIDEndereco
            // 
            this.lblIDEndereco.AutoSize = true;
            this.lblIDEndereco.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIDEndereco.ForeColor = System.Drawing.Color.White;
            this.lblIDEndereco.Location = new System.Drawing.Point(469, 45);
            this.lblIDEndereco.Name = "lblIDEndereco";
            this.lblIDEndereco.Size = new System.Drawing.Size(107, 21);
            this.lblIDEndereco.TabIndex = 149;
            this.lblIDEndereco.Text = "Endereço ID:";
            // 
            // txtEnderecoID
            // 
            this.txtEnderecoID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnderecoID.Enabled = false;
            this.txtEnderecoID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnderecoID.Location = new System.Drawing.Point(469, 69);
            this.txtEnderecoID.Name = "txtEnderecoID";
            this.txtEnderecoID.Size = new System.Drawing.Size(101, 28);
            this.txtEnderecoID.TabIndex = 148;
            // 
            // TelaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1715, 902);
            this.Controls.Add(this.lblIDEndereco);
            this.Controls.Add(this.txtEnderecoID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dtFuncionario);
            this.Controls.Add(this.mskDataNasc);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.mskCEP);
            this.Controls.Add(this.mskdCPF);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.lblPonto);
            this.Controls.Add(this.txtPonto);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.lblNivelAcesso);
            this.Controls.Add(this.cbNivelAcesso);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblCPF);
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
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCadastrar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaFuncionario";
            this.Text = "TelaFuncionario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtFuncionario;
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
        private MaskedTextBox mskDataNasc;
        private MaskedTextBox mskTelefone;
        private MaskedTextBox mskCEP;
        private MaskedTextBox mskdCPF;
        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblComplemento;
        private TextBox txtComplemento;
        private Label lblPonto;
        private TextBox txtPonto;
        private Label lblCep;
        private ComboBox cbEstado;
        private Label lblEstado;
        private Label lblCidade;
        private TextBox txtCidade;
        private Label lblBairro;
        private TextBox txtBairro;
        private Label lblTelefone;
        private Label lblRua;
        private TextBox txtRua;
        private Label lblNivelAcesso;
        private ComboBox cbNivelAcesso;
        private Label lblGenero;
        private Label lblData;
        private Label lblCPF;
        private Label lblRG;
        private TextBox txtRG;
        private Label lblConfSenha;
        private TextBox txtConfSenha;
        private Label lblSenha;
        private TextBox txtSenha;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblSobrenome;
        private TextBox txtSobrenome;
        private Label lblNome;
        private TextBox txtNome;
        private ComboBox cbGenero;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCadastrar;
        private Label label1;
        private TextBox txtID;
        private Label lblIDEndereco;
        private TextBox txtEnderecoID;
    }
}