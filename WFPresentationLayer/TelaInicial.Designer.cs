namespace WFPresentationLayer
{
    partial class TelaInicial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnProdutos);
            this.panel2.Controls.Add(this.btnFornecedores);
            this.panel2.Controls.Add(this.btnFuncionarios);
            this.panel2.Controls.Add(this.btnClientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 567);
            this.panel2.TabIndex = 1;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(160, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(860, 567);
            this.panelDesktop.TabIndex = 2;
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.Location = new System.Drawing.Point(0, 0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(160, 65);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFuncionarios.Location = new System.Drawing.Point(0, 65);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(160, 69);
            this.btnFuncionarios.TabIndex = 1;
            this.btnFuncionarios.Text = "Funcionarios";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFornecedores.Location = new System.Drawing.Point(0, 134);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(160, 72);
            this.btnFornecedores.TabIndex = 2;
            this.btnFornecedores.Text = "Fornecedores";
            this.btnFornecedores.UseVisualStyleBackColor = true;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdutos.Location = new System.Drawing.Point(0, 206);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(160, 74);
            this.btnProdutos.TabIndex = 3;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Location = new System.Drawing.Point(0, 511);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(160, 56);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 667);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnLogout;
        private Button btnProdutos;
        private Button btnFornecedores;
        private Button btnFuncionarios;
        private Button btnClientes;
        private Panel panelDesktop;
    }
}