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
            this.txtCNPJ = new System.Windows.Forms.TextBox();
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
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.ckIsAtivo = new System.Windows.Forms.CheckBox();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.btnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCalcular = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            ((System.ComponentModel.ISupportInitialize)(this.dtFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCnpj.ForeColor = System.Drawing.Color.White;
            this.lblCnpj.Location = new System.Drawing.Point(59, 154);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(49, 21);
            this.lblCnpj.TabIndex = 3;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(131, 156);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(181, 23);
            this.txtCNPJ.TabIndex = 4;
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
            this.txtNome.Location = new System.Drawing.Point(69, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(12, 55);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 21);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(131, 246);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(181, 23);
            this.txtTelefone.TabIndex = 9;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(38, 244);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(70, 21);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 204);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 23);
            this.txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(57, 202);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 21);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(220, 55);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 15;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(186, 55);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 21);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID:";
            // 
            // ckIsAtivo
            // 
            this.ckIsAtivo.AutoSize = true;
            this.ckIsAtivo.Checked = true;
            this.ckIsAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckIsAtivo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ckIsAtivo.FlatAppearance.BorderSize = 3;
            this.ckIsAtivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckIsAtivo.ForeColor = System.Drawing.Color.White;
            this.ckIsAtivo.Location = new System.Drawing.Point(131, 288);
            this.ckIsAtivo.Name = "ckIsAtivo";
            this.ckIsAtivo.Size = new System.Drawing.Size(97, 25);
            this.ckIsAtivo.TabIndex = 16;
            this.ckIsAtivo.Text = "Está Ativo";
            this.ckIsAtivo.UseVisualStyleBackColor = true;
            // 
            // txtRazao
            // 
            this.txtRazao.Location = new System.Drawing.Point(131, 113);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(181, 23);
            this.txtRazao.TabIndex = 18;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRazaoSocial.ForeColor = System.Drawing.Color.White;
            this.lblRazaoSocial.Location = new System.Drawing.Point(8, 111);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(100, 21);
            this.lblRazaoSocial.TabIndex = 17;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // btnDelete
            // 
            this.btnDelete.Depth = 0;
            this.btnDelete.Location = new System.Drawing.Point(260, 369);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = true;
            this.btnDelete.Size = new System.Drawing.Size(101, 50);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Location = new System.Drawing.Point(137, 369);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(103, 50);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Depth = 0;
            this.btnCalcular.Location = new System.Drawing.Point(12, 369);
            this.btnCalcular.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Primary = true;
            this.btnCalcular.Size = new System.Drawing.Size(103, 50);
            this.btnCalcular.TabIndex = 21;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.White;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(12, 341);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(349, 1);
            this.materialDivider1.TabIndex = 22;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.White;
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(346, 29);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(1, 323);
            this.materialDivider2.TabIndex = 23;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // TelaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(932, 497);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtRazao);
            this.Controls.Add(this.lblRazaoSocial);
            this.Controls.Add(this.ckIsAtivo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dtFornecedor);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.lblCnpj);
            this.Name = "TelaFornecedor";
            this.Text = "TelaFornecedor";
            this.Load += new System.EventHandler(this.TelaFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblCnpj;
        private TextBox txtCNPJ;
        private DataGridView dtFornecedor;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtTelefone;
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
        private MaterialSkin.Controls.MaterialRaisedButton btnDelete;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private MaterialSkin.Controls.MaterialRaisedButton btnCalcular;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
    }
}