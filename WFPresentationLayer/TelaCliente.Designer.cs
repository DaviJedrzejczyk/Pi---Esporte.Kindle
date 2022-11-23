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
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
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
            this.mskDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblGenero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGenero
            // 
            this.cbGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(306, 475);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(193, 29);
            this.cbGenero.TabIndex = 35;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(223, 440);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(80, 21);
            this.lblTelefone.TabIndex = 33;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(306, 403);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 28);
            this.txtEmail.TabIndex = 32;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(244, 406);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 21);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email:";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataNasc.ForeColor = System.Drawing.Color.White;
            this.lblDataNasc.Location = new System.Drawing.Point(129, 376);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(170, 21);
            this.lblDataNasc.TabIndex = 29;
            this.lblDataNasc.Text = "Data de Nascimento:";
            this.lblDataNasc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRG
            // 
            this.txtRG.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRG.Location = new System.Drawing.Point(306, 335);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(193, 28);
            this.txtRG.TabIndex = 28;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRg.ForeColor = System.Drawing.Color.White;
            this.lblRg.Location = new System.Drawing.Point(263, 342);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(36, 21);
            this.lblRg.TabIndex = 27;
            this.lblRg.Text = "RG:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCpf.ForeColor = System.Drawing.Color.White;
            this.lblCpf.Location = new System.Drawing.Point(255, 308);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(44, 21);
            this.lblCpf.TabIndex = 25;
            this.lblCpf.Text = "CPF:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSobrenome.Location = new System.Drawing.Point(306, 267);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(193, 28);
            this.txtSobrenome.TabIndex = 24;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSobrenome.ForeColor = System.Drawing.Color.White;
            this.lblSobrenome.Location = new System.Drawing.Point(197, 274);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(102, 21);
            this.lblSobrenome.TabIndex = 23;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(306, 233);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(193, 28);
            this.txtNome.TabIndex = 22;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(238, 240);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 21);
            this.lblNome.TabIndex = 21;
            this.lblNome.Text = "Nome:";
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
            this.dtCliente.Location = new System.Drawing.Point(711, 77);
            this.dtCliente.Name = "dtCliente";
            this.dtCliente.ReadOnly = true;
            this.dtCliente.RowTemplate.Height = 25;
            this.dtCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtCliente.Size = new System.Drawing.Size(959, 746);
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
            this.txtID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(306, 199);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(81, 28);
            this.txtID.TabIndex = 38;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(268, 206);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 21);
            this.lblID.TabIndex = 37;
            this.lblID.Text = "ID:";
            // 
            // txtIdade
            // 
            this.txtIdade.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIdade.Location = new System.Drawing.Point(450, 369);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.ReadOnly = true;
            this.txtIdade.Size = new System.Drawing.Size(49, 28);
            this.txtIdade.TabIndex = 40;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(393, 372);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(57, 21);
            this.lblIdade.TabIndex = 39;
            this.lblIdade.Text = "Idade:";
            // 
            // mskdCPF
            // 
            this.mskdCPF.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskdCPF.Location = new System.Drawing.Point(306, 301);
            this.mskdCPF.Mask = "000,000,000-00";
            this.mskdCPF.Name = "mskdCPF";
            this.mskdCPF.Size = new System.Drawing.Size(193, 28);
            this.mskdCPF.TabIndex = 41;
            // 
            // mskDataNasc
            // 
            this.mskDataNasc.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskDataNasc.Location = new System.Drawing.Point(306, 369);
            this.mskDataNasc.Mask = "00/00/0000";
            this.mskDataNasc.Name = "mskDataNasc";
            this.mskDataNasc.Size = new System.Drawing.Size(81, 28);
            this.mskDataNasc.TabIndex = 42;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTelefone.Location = new System.Drawing.Point(306, 437);
            this.mskTelefone.Mask = "(00) 0 00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(193, 28);
            this.mskTelefone.TabIndex = 43;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(443, 752);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(193, 71);
            this.btnDelete.TabIndex = 109;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(244, 752);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(193, 71);
            this.btnUpdate.TabIndex = 108;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(44, 752);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(193, 71);
            this.btnCadastrar.TabIndex = 107;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(219, 483);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(70, 21);
            this.lblGenero.TabIndex = 110;
            this.lblGenero.Text = "Genero:";
            // 
            // TelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1728, 902);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.mskDataNasc);
            this.Controls.Add(this.mskdCPF);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dtCliente);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbGenero;
        private Label lblTelefone;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblDataNasc;
        private TextBox txtRG;
        private Label lblRg;
        private Label lblCpf;
        private TextBox txtSobrenome;
        private Label lblSobrenome;
        private TextBox txtNome;
        private Label lblNome;
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
        private MaskedTextBox mskDataNasc;
        private MaskedTextBox mskTelefone;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCadastrar;
        private Label lblGenero;
    }
}