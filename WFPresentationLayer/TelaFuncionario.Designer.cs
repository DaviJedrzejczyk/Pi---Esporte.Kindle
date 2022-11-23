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
            this.tbFuncionario = new System.Windows.Forms.TabControl();
            this.tbCadastroFuncionario = new System.Windows.Forms.TabPage();
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
            this.tbListFuncionario = new System.Windows.Forms.TabPage();
            this.panelDesktopFuncionario = new System.Windows.Forms.Panel();
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnTabela = new System.Windows.Forms.Button();
            this.btnInformacoesFunc = new System.Windows.Forms.Button();
            this.tbFuncionario.SuspendLayout();
            this.tbCadastroFuncionario.SuspendLayout();
            this.tbListFuncionario.SuspendLayout();
            this.panelDesktopFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFuncionario)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFuncionario
            // 
            this.tbFuncionario.Controls.Add(this.tbCadastroFuncionario);
            this.tbFuncionario.Controls.Add(this.tbListFuncionario);
            this.tbFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFuncionario.Location = new System.Drawing.Point(0, 0);
            this.tbFuncionario.Name = "tbFuncionario";
            this.tbFuncionario.SelectedIndex = 0;
            this.tbFuncionario.Size = new System.Drawing.Size(900, 519);
            this.tbFuncionario.TabIndex = 54;
            // 
            // tbCadastroFuncionario
            // 
            this.tbCadastroFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.tbCadastroFuncionario.Controls.Add(this.mskDataNasc);
            this.tbCadastroFuncionario.Controls.Add(this.mskTelefone);
            this.tbCadastroFuncionario.Controls.Add(this.mskCEP);
            this.tbCadastroFuncionario.Controls.Add(this.mskdCPF);
            this.tbCadastroFuncionario.Controls.Add(this.lblNumero);
            this.tbCadastroFuncionario.Controls.Add(this.txtNumero);
            this.tbCadastroFuncionario.Controls.Add(this.lblComplemento);
            this.tbCadastroFuncionario.Controls.Add(this.txtComplemento);
            this.tbCadastroFuncionario.Controls.Add(this.lblPonto);
            this.tbCadastroFuncionario.Controls.Add(this.txtPonto);
            this.tbCadastroFuncionario.Controls.Add(this.lblCep);
            this.tbCadastroFuncionario.Controls.Add(this.cbEstado);
            this.tbCadastroFuncionario.Controls.Add(this.lblEstado);
            this.tbCadastroFuncionario.Controls.Add(this.lblCidade);
            this.tbCadastroFuncionario.Controls.Add(this.txtCidade);
            this.tbCadastroFuncionario.Controls.Add(this.lblBairro);
            this.tbCadastroFuncionario.Controls.Add(this.txtBairro);
            this.tbCadastroFuncionario.Controls.Add(this.lblTelefone);
            this.tbCadastroFuncionario.Controls.Add(this.lblRua);
            this.tbCadastroFuncionario.Controls.Add(this.txtRua);
            this.tbCadastroFuncionario.Controls.Add(this.lblNivelAcesso);
            this.tbCadastroFuncionario.Controls.Add(this.cbNivelAcesso);
            this.tbCadastroFuncionario.Controls.Add(this.lblGenero);
            this.tbCadastroFuncionario.Controls.Add(this.lblData);
            this.tbCadastroFuncionario.Controls.Add(this.lblCPF);
            this.tbCadastroFuncionario.Controls.Add(this.lblRG);
            this.tbCadastroFuncionario.Controls.Add(this.txtRG);
            this.tbCadastroFuncionario.Controls.Add(this.lblConfSenha);
            this.tbCadastroFuncionario.Controls.Add(this.txtConfSenha);
            this.tbCadastroFuncionario.Controls.Add(this.lblSenha);
            this.tbCadastroFuncionario.Controls.Add(this.txtSenha);
            this.tbCadastroFuncionario.Controls.Add(this.lblEmail);
            this.tbCadastroFuncionario.Controls.Add(this.txtEmail);
            this.tbCadastroFuncionario.Controls.Add(this.lblSobrenome);
            this.tbCadastroFuncionario.Controls.Add(this.txtSobrenome);
            this.tbCadastroFuncionario.Controls.Add(this.lblNome);
            this.tbCadastroFuncionario.Controls.Add(this.txtNome);
            this.tbCadastroFuncionario.Controls.Add(this.cbGenero);
            this.tbCadastroFuncionario.Controls.Add(this.btnDelete);
            this.tbCadastroFuncionario.Controls.Add(this.btnUpdate);
            this.tbCadastroFuncionario.Controls.Add(this.btnCadastrar);
            this.tbCadastroFuncionario.Location = new System.Drawing.Point(4, 24);
            this.tbCadastroFuncionario.Name = "tbCadastroFuncionario";
            this.tbCadastroFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastroFuncionario.Size = new System.Drawing.Size(892, 491);
            this.tbCadastroFuncionario.TabIndex = 0;
            this.tbCadastroFuncionario.Text = "Cadastro";
            // 
            // mskDataNasc
            // 
            this.mskDataNasc.Location = new System.Drawing.Point(58, 254);
            this.mskDataNasc.Mask = "00/00/0000";
            this.mskDataNasc.Name = "mskDataNasc";
            this.mskDataNasc.Size = new System.Drawing.Size(117, 23);
            this.mskDataNasc.TabIndex = 102;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(58, 395);
            this.mskTelefone.Mask = "(00) 0 00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(117, 23);
            this.mskTelefone.TabIndex = 101;
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(593, 80);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(100, 23);
            this.mskCEP.TabIndex = 100;
            // 
            // mskdCPF
            // 
            this.mskdCPF.Location = new System.Drawing.Point(58, 210);
            this.mskdCPF.Mask = "000,000,000-00";
            this.mskdCPF.Name = "mskdCPF";
            this.mskdCPF.Size = new System.Drawing.Size(117, 23);
            this.mskdCPF.TabIndex = 99;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.ForeColor = System.Drawing.Color.White;
            this.lblNumero.Location = new System.Drawing.Point(592, 239);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(54, 15);
            this.lblNumero.TabIndex = 98;
            this.lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(593, 257);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 97;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.ForeColor = System.Drawing.Color.White;
            this.lblComplemento.Location = new System.Drawing.Point(593, 327);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(87, 15);
            this.lblComplemento.TabIndex = 94;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(592, 342);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(163, 23);
            this.txtComplemento.TabIndex = 93;
            // 
            // lblPonto
            // 
            this.lblPonto.AutoSize = true;
            this.lblPonto.ForeColor = System.Drawing.Color.White;
            this.lblPonto.Location = new System.Drawing.Point(591, 283);
            this.lblPonto.Name = "lblPonto";
            this.lblPonto.Size = new System.Drawing.Size(116, 15);
            this.lblPonto.TabIndex = 92;
            this.lblPonto.Text = "Ponto de Referência:";
            // 
            // txtPonto
            // 
            this.txtPonto.Location = new System.Drawing.Point(593, 301);
            this.txtPonto.Name = "txtPonto";
            this.txtPonto.Size = new System.Drawing.Size(162, 23);
            this.txtPonto.TabIndex = 91;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.ForeColor = System.Drawing.Color.White;
            this.lblCep.Location = new System.Drawing.Point(591, 62);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 15);
            this.lblCep.TabIndex = 90;
            this.lblCep.Text = "CEP:";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(761, 80);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(100, 23);
            this.cbEstado.TabIndex = 89;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(761, 62);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 88;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.ForeColor = System.Drawing.Color.White;
            this.lblCidade.Location = new System.Drawing.Point(593, 198);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(47, 15);
            this.lblCidade.TabIndex = 87;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(593, 213);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(162, 23);
            this.txtCidade.TabIndex = 86;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.ForeColor = System.Drawing.Color.White;
            this.lblBairro.Location = new System.Drawing.Point(592, 154);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(41, 15);
            this.lblBairro.TabIndex = 85;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(593, 172);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(162, 23);
            this.txtBairro.TabIndex = 84;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(58, 371);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(55, 15);
            this.lblTelefone.TabIndex = 81;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.ForeColor = System.Drawing.Color.White;
            this.lblRua.Location = new System.Drawing.Point(592, 107);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(30, 15);
            this.lblRua.TabIndex = 80;
            this.lblRua.Text = "Rua:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(593, 127);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(162, 23);
            this.txtRua.TabIndex = 79;
            // 
            // lblNivelAcesso
            // 
            this.lblNivelAcesso.AutoSize = true;
            this.lblNivelAcesso.ForeColor = System.Drawing.Color.White;
            this.lblNivelAcesso.Location = new System.Drawing.Point(58, 324);
            this.lblNivelAcesso.Name = "lblNivelAcesso";
            this.lblNivelAcesso.Size = new System.Drawing.Size(93, 15);
            this.lblNivelAcesso.TabIndex = 78;
            this.lblNivelAcesso.Text = "Nivel de Acesso:";
            // 
            // cbNivelAcesso
            // 
            this.cbNivelAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivelAcesso.FormattingEnabled = true;
            this.cbNivelAcesso.Location = new System.Drawing.Point(58, 342);
            this.cbNivelAcesso.Name = "cbNivelAcesso";
            this.cbNivelAcesso.Size = new System.Drawing.Size(117, 23);
            this.cbNivelAcesso.TabIndex = 77;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(58, 280);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(48, 15);
            this.lblGenero.TabIndex = 76;
            this.lblGenero.Text = "Genero:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(58, 236);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(117, 15);
            this.lblData.TabIndex = 75;
            this.lblData.Text = "Data de Nascimento:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.ForeColor = System.Drawing.Color.White;
            this.lblCPF.Location = new System.Drawing.Point(58, 191);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(31, 15);
            this.lblCPF.TabIndex = 73;
            this.lblCPF.Text = "CPF:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.ForeColor = System.Drawing.Color.White;
            this.lblRG.Location = new System.Drawing.Point(58, 147);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(25, 15);
            this.lblRG.TabIndex = 72;
            this.lblRG.Text = "RG:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(58, 165);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(117, 23);
            this.txtRG.TabIndex = 71;
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.AutoSize = true;
            this.lblConfSenha.ForeColor = System.Drawing.Color.White;
            this.lblConfSenha.Location = new System.Drawing.Point(225, 154);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(99, 15);
            this.lblConfSenha.TabIndex = 70;
            this.lblConfSenha.Text = "Confrimar Senha:";
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Location = new System.Drawing.Point(225, 178);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Size = new System.Drawing.Size(100, 23);
            this.txtConfSenha.TabIndex = 69;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(225, 107);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(42, 15);
            this.lblSenha.TabIndex = 68;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(225, 127);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 23);
            this.txtSenha.TabIndex = 67;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(225, 62);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 66;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(225, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(139, 23);
            this.txtEmail.TabIndex = 65;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.ForeColor = System.Drawing.Color.White;
            this.lblSobrenome.Location = new System.Drawing.Point(58, 107);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(71, 15);
            this.lblSobrenome.TabIndex = 64;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(58, 125);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(117, 23);
            this.txtSobrenome.TabIndex = 63;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(58, 62);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 62;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(58, 80);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(117, 23);
            this.txtNome.TabIndex = 61;
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(58, 298);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(117, 23);
            this.cbGenero.TabIndex = 59;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(488, 424);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 42);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(383, 424);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 42);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(281, 424);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(96, 42);
            this.btnCadastrar.TabIndex = 54;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // tbListFuncionario
            // 
            this.tbListFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.tbListFuncionario.Controls.Add(this.panelDesktopFuncionario);
            this.tbListFuncionario.Controls.Add(this.panelButtons);
            this.tbListFuncionario.Location = new System.Drawing.Point(4, 24);
            this.tbListFuncionario.Name = "tbListFuncionario";
            this.tbListFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tbListFuncionario.Size = new System.Drawing.Size(892, 491);
            this.tbListFuncionario.TabIndex = 1;
            this.tbListFuncionario.Text = "Listagem de Funcionários";
            // 
            // panelDesktopFuncionario
            // 
            this.panelDesktopFuncionario.Controls.Add(this.dtFuncionario);
            this.panelDesktopFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopFuncionario.Location = new System.Drawing.Point(3, 3);
            this.panelDesktopFuncionario.Name = "panelDesktopFuncionario";
            this.panelDesktopFuncionario.Size = new System.Drawing.Size(732, 485);
            this.panelDesktopFuncionario.TabIndex = 63;
            // 
            // dtFuncionario
            // 
            this.dtFuncionario.AllowUserToAddRows = false;
            this.dtFuncionario.AllowUserToDeleteRows = false;
            this.dtFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
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
            this.dtFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtFuncionario.Location = new System.Drawing.Point(0, 0);
            this.dtFuncionario.Name = "dtFuncionario";
            this.dtFuncionario.ReadOnly = true;
            this.dtFuncionario.RowTemplate.Height = 25;
            this.dtFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtFuncionario.Size = new System.Drawing.Size(732, 485);
            this.dtFuncionario.TabIndex = 62;
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
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnTabela);
            this.panelButtons.Controls.Add(this.btnInformacoesFunc);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(735, 3);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(154, 485);
            this.panelButtons.TabIndex = 62;
            // 
            // btnTabela
            // 
            this.btnTabela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabela.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTabela.Location = new System.Drawing.Point(6, 86);
            this.btnTabela.Name = "btnTabela";
            this.btnTabela.Size = new System.Drawing.Size(144, 77);
            this.btnTabela.TabIndex = 1;
            this.btnTabela.Text = "Tabela de Funcionários";
            this.btnTabela.UseVisualStyleBackColor = true;
            // 
            // btnInformacoesFunc
            // 
            this.btnInformacoesFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacoesFunc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInformacoesFunc.Location = new System.Drawing.Point(6, 3);
            this.btnInformacoesFunc.Name = "btnInformacoesFunc";
            this.btnInformacoesFunc.Size = new System.Drawing.Size(144, 77);
            this.btnInformacoesFunc.TabIndex = 0;
            this.btnInformacoesFunc.Text = "Informações do Funcionário";
            this.btnInformacoesFunc.UseVisualStyleBackColor = true;
            this.btnInformacoesFunc.Click += new System.EventHandler(this.btnInformacoesFunc_Click);
            // 
            // TelaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(900, 519);
            this.Controls.Add(this.tbFuncionario);
            this.Name = "TelaFuncionario";
            this.Text = "TelaFuncionario";
            this.Load += new System.EventHandler(this.TelaFuncionario_Load);
            this.tbFuncionario.ResumeLayout(false);
            this.tbCadastroFuncionario.ResumeLayout(false);
            this.tbCadastroFuncionario.PerformLayout();
            this.tbListFuncionario.ResumeLayout(false);
            this.panelDesktopFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtFuncionario)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbFuncionario;
        private TabPage tbCadastroFuncionario;
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
        private TabPage tbListFuncionario;
        private Panel panelDesktopFuncionario;
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
        private Panel panelButtons;
        private Button btnTabela;
        private Button btnInformacoesFunc;
        private MaskedTextBox mskDataNasc;
    }
}