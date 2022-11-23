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
            this.lblCnpj = new System.Windows.Forms.Label();
            this.dtFornecedor = new System.Windows.Forms.DataGridView();
            this.ForneID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForneRazao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForneNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForneCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForneEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForneTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCnpj.ForeColor = System.Drawing.Color.White;
            this.lblCnpj.Location = new System.Drawing.Point(111, 241);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(54, 21);
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
            this.ForneTelefone});
            this.dtFornecedor.Location = new System.Drawing.Point(675, 27);
            this.dtFornecedor.Name = "dtFornecedor";
            this.dtFornecedor.ReadOnly = true;
            this.dtFornecedor.RowTemplate.Height = 25;
            this.dtFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtFornecedor.Size = new System.Drawing.Size(998, 761);
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
            // txtNome
            // 
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(172, 272);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(166, 28);
            this.txtNome.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(105, 272);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 21);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(86, 309);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(80, 21);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(172, 340);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 28);
            this.txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(111, 343);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 21);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(172, 170);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(70, 28);
            this.txtID.TabIndex = 15;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(134, 173);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 21);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID:";
            // 
            // txtRazao
            // 
            this.txtRazao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRazao.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRazao.Location = new System.Drawing.Point(172, 204);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(166, 28);
            this.txtRazao.TabIndex = 18;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRazaoSocial.ForeColor = System.Drawing.Color.White;
            this.lblRazaoSocial.Location = new System.Drawing.Point(56, 204);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(109, 21);
            this.lblRazaoSocial.TabIndex = 17;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mskCNPJ.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskCNPJ.Location = new System.Drawing.Point(172, 238);
            this.mskCNPJ.Mask = "00, 000, 000/0001-00";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.Size = new System.Drawing.Size(166, 28);
            this.mskCNPJ.TabIndex = 19;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTelefone.Location = new System.Drawing.Point(172, 306);
            this.mskTelefone.Mask = "(00) 0 00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(166, 28);
            this.mskTelefone.TabIndex = 44;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(448, 717);
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
            this.btnUpdate.Location = new System.Drawing.Point(249, 717);
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
            this.btnCadastrar.Location = new System.Drawing.Point(49, 717);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(193, 71);
            this.btnCadastrar.TabIndex = 107;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // TelaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1728, 902);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.mskCNPJ);
            this.Controls.Add(this.txtRazao);
            this.Controls.Add(this.lblRazaoSocial);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dtFornecedor);
            this.Controls.Add(this.lblCnpj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TelaFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaFornecedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblCnpj;
        private DataGridView dtFornecedor;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblTelefone;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtID;
        private Label lblID;
        private TextBox txtRazao;
        private Label lblRazaoSocial;
        private MaskedTextBox mskCNPJ;
        private MaskedTextBox mskTelefone;
        private DataGridViewTextBoxColumn ForneID;
        private DataGridViewTextBoxColumn ForneRazao;
        private DataGridViewTextBoxColumn ForneNome;
        private DataGridViewTextBoxColumn ForneCNPJ;
        private DataGridViewTextBoxColumn ForneEmail;
        private DataGridViewTextBoxColumn ForneTelefone;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCadastrar;
    }
}