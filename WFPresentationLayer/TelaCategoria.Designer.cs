namespace WFPresentationLayer
{
    partial class TelaCategoria
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
            this.dtCategoria = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.CategoriaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(1, 343);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(103, 53);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dtCategoria
            // 
            this.dtCategoria.AllowUserToAddRows = false;
            this.dtCategoria.AllowUserToDeleteRows = false;
            this.dtCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoriaID,
            this.CategoriaNome,
            this.CategoriaDescricao});
            this.dtCategoria.Location = new System.Drawing.Point(328, 12);
            this.dtCategoria.Name = "dtCategoria";
            this.dtCategoria.ReadOnly = true;
            this.dtCategoria.RowTemplate.Height = 25;
            this.dtCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtCategoria.Size = new System.Drawing.Size(342, 412);
            this.dtCategoria.TabIndex = 1;
            this.dtCategoria.DoubleClick += new System.EventHandler(this.dtCategoria_DoubleClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(23, 70);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 15);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(65, 67);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(101, 23);
            this.txtID.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(65, 96);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(101, 23);
            this.txtNome.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(1, 99);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(65, 130);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(101, 23);
            this.txtDesc.TabIndex = 7;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(1, 133);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 15);
            this.lblDescricao.TabIndex = 6;
            this.lblDescricao.Text = "Descrição";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(110, 343);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 53);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(219, 343);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 53);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CategoriaID
            // 
            this.CategoriaID.HeaderText = "ID";
            this.CategoriaID.Name = "CategoriaID";
            this.CategoriaID.ReadOnly = true;
            // 
            // CategoriaNome
            // 
            this.CategoriaNome.HeaderText = "Nome";
            this.CategoriaNome.Name = "CategoriaNome";
            this.CategoriaNome.ReadOnly = true;
            // 
            // CategoriaDescricao
            // 
            this.CategoriaDescricao.HeaderText = "Descrição";
            this.CategoriaDescricao.Name = "CategoriaDescricao";
            this.CategoriaDescricao.ReadOnly = true;
            // 
            // TelaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 436);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dtCategoria);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "TelaCategoria";
            this.Text = "TelaCategoria";
            this.Load += new System.EventHandler(this.TelaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCadastrar;
        private DataGridView dtCategoria;
        private DataGridViewTextBoxColumn CategoriaID;
        private DataGridViewTextBoxColumn CategoriaNome;
        private DataGridViewTextBoxColumn CategoriaDescricao;
        private Label lblID;
        private TextBox txtID;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtDesc;
        private Label lblDescricao;
        private Button btnUpdate;
        private Button btnDelete;
    }
}