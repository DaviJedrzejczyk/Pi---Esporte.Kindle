namespace WFPresentationLayer
{
    partial class TelaCliente
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
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDataNasc = new System.Windows.Forms.TextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtCliente = new System.Windows.Forms.DataGridView();
            this.ClienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteSobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.mskdCPF = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(49, 285);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(166, 23);
            this.cbGenero.TabIndex = 35;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(115, 256);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 23);
            this.txtTelefone.TabIndex = 34;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(38, 261);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 15);
            this.lblTelefone.TabIndex = 33;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(115, 227);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 32;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(38, 232);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email:";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(161, 198);
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(100, 23);
            this.txtDataNasc.TabIndex = 30;
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.ForeColor = System.Drawing.Color.White;
            this.lblDataNasc.Location = new System.Drawing.Point(38, 201);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(117, 15);
            this.lblDataNasc.TabIndex = 29;
            this.lblDataNasc.Text = "Data de Nascimento:";
            this.lblDataNasc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(115, 167);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 23);
            this.txtRG.TabIndex = 28;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.ForeColor = System.Drawing.Color.White;
            this.lblRg.Location = new System.Drawing.Point(38, 172);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(25, 15);
            this.lblRg.TabIndex = 27;
            this.lblRg.Text = "RG:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.ForeColor = System.Drawing.Color.White;
            this.lblCpf.Location = new System.Drawing.Point(38, 143);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(31, 15);
            this.lblCpf.TabIndex = 25;
            this.lblCpf.Text = "CPF:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(115, 109);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(100, 23);
            this.txtSobrenome.TabIndex = 24;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.ForeColor = System.Drawing.Color.White;
            this.lblSobrenome.Location = new System.Drawing.Point(38, 114);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(71, 15);
            this.lblSobrenome.TabIndex = 23;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(115, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 22;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(38, 85);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 21;
            this.lblNome.Text = "Nome:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(121, 363);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 35);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(235, 363);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(108, 35);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(7, 363);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(108, 35);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dtCliente
            // 
            this.dtCliente.AllowUserToAddRows = false;
            this.dtCliente.AllowUserToDeleteRows = false;
            this.dtCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClienteID,
            this.ClienteNome,
            this.ClienteSobrenome,
            this.ClienteCPF,
            this.ClienteRG,
            this.ClienteEmail,
            this.ClienteIdade,
            this.ClienteData,
            this.ClienteTelefone,
            this.ClienteGenero});
            this.dtCliente.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtCliente.Location = new System.Drawing.Point(369, 12);
            this.dtCliente.Name = "dtCliente";
            this.dtCliente.ReadOnly = true;
            this.dtCliente.RowTemplate.Height = 25;
            this.dtCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtCliente.Size = new System.Drawing.Size(664, 462);
            this.dtCliente.TabIndex = 36;
            this.dtCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCliente_CellContentClick);
            this.dtCliente.DoubleClick += new System.EventHandler(this.dtCliente_DoubleClick);
            // 
            // ClienteID
            // 
            this.ClienteID.HeaderText = "ID";
            this.ClienteID.Name = "ClienteID";
            this.ClienteID.ReadOnly = true;
            // 
            // ClienteNome
            // 
            this.ClienteNome.HeaderText = "Nome";
            this.ClienteNome.Name = "ClienteNome";
            this.ClienteNome.ReadOnly = true;
            // 
            // ClienteSobrenome
            // 
            this.ClienteSobrenome.HeaderText = "Sobrenome";
            this.ClienteSobrenome.Name = "ClienteSobrenome";
            this.ClienteSobrenome.ReadOnly = true;
            // 
            // ClienteCPF
            // 
            this.ClienteCPF.HeaderText = "CPF";
            this.ClienteCPF.Name = "ClienteCPF";
            this.ClienteCPF.ReadOnly = true;
            // 
            // ClienteRG
            // 
            this.ClienteRG.HeaderText = "RG";
            this.ClienteRG.Name = "ClienteRG";
            this.ClienteRG.ReadOnly = true;
            // 
            // ClienteEmail
            // 
            this.ClienteEmail.HeaderText = "Email";
            this.ClienteEmail.Name = "ClienteEmail";
            this.ClienteEmail.ReadOnly = true;
            // 
            // ClienteIdade
            // 
            this.ClienteIdade.HeaderText = "Idade";
            this.ClienteIdade.Name = "ClienteIdade";
            this.ClienteIdade.ReadOnly = true;
            // 
            // ClienteData
            // 
            this.ClienteData.HeaderText = "Data de Nascimento";
            this.ClienteData.Name = "ClienteData";
            this.ClienteData.ReadOnly = true;
            // 
            // ClienteTelefone
            // 
            this.ClienteTelefone.HeaderText = "Telefone";
            this.ClienteTelefone.Name = "ClienteTelefone";
            this.ClienteTelefone.ReadOnly = true;
            // 
            // ClienteGenero
            // 
            this.ClienteGenero.HeaderText = "Genero";
            this.ClienteGenero.Name = "ClienteGenero";
            this.ClienteGenero.ReadOnly = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(115, 48);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 38;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(38, 56);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 15);
            this.lblID.TabIndex = 37;
            this.lblID.Text = "ID:";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(267, 198);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.ReadOnly = true;
            this.txtIdade.Size = new System.Drawing.Size(49, 23);
            this.txtIdade.TabIndex = 40;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(267, 180);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(39, 15);
            this.lblIdade.TabIndex = 39;
            this.lblIdade.Text = "Idade:";
            // 
            // mskdCPF
            // 
            this.mskdCPF.Location = new System.Drawing.Point(115, 140);
            this.mskdCPF.Mask = "000,000,000-00";
            this.mskdCPF.Name = "mskdCPF";
            this.mskdCPF.Size = new System.Drawing.Size(100, 23);
            this.mskdCPF.TabIndex = 41;
            // 
            // TelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(3)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1045, 486);
            this.Controls.Add(this.mskdCPF);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dtCliente);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCadastrar);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "TelaCliente";
            this.Text = "TelaCliente";
            this.Load += new System.EventHandler(this.TelaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbGenero;
        private TextBox txtTelefone;
        private Label lblTelefone;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtDataNasc;
        private Label lblDataNasc;
        private TextBox txtRG;
        private Label lblRg;
        private Label lblCpf;
        private TextBox txtSobrenome;
        private Label lblSobrenome;
        private TextBox txtNome;
        private Label lblNome;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnCadastrar;
        private DataGridView dtCliente;
        private TextBox txtID;
        private Label lblID;
        private DataGridViewTextBoxColumn ClienteID;
        private DataGridViewTextBoxColumn ClienteNome;
        private DataGridViewTextBoxColumn ClienteSobrenome;
        private DataGridViewTextBoxColumn ClienteCPF;
        private DataGridViewTextBoxColumn ClienteRG;
        private DataGridViewTextBoxColumn ClienteEmail;
        private DataGridViewTextBoxColumn ClienteIdade;
        private DataGridViewTextBoxColumn ClienteData;
        private DataGridViewTextBoxColumn ClienteTelefone;
        private DataGridViewTextBoxColumn ClienteGenero;
        private TextBox txtIdade;
        private Label lblIdade;
        private MaskedTextBox mskdCPF;
    }
}