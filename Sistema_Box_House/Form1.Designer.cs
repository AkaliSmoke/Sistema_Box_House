namespace Sistema_Box_House
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVendaProdutos = new System.Windows.Forms.Button();
            this.btnCadastroClientes = new System.Windows.Forms.Button();
            this.btnCadastroFuncionarios = new System.Windows.Forms.Button();
            this.btnControleEntregas = new System.Windows.Forms.Button();
            this.btnFecharSistema = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVendaProdutos
            // 
            this.btnVendaProdutos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVendaProdutos.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendaProdutos.Location = new System.Drawing.Point(13, 13);
            this.btnVendaProdutos.Name = "btnVendaProdutos";
            this.btnVendaProdutos.Size = new System.Drawing.Size(249, 90);
            this.btnVendaProdutos.TabIndex = 0;
            this.btnVendaProdutos.Text = "Controle de vendas de produtos";
            this.btnVendaProdutos.UseVisualStyleBackColor = false;
            // 
            // btnCadastroClientes
            // 
            this.btnCadastroClientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastroClientes.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroClientes.Location = new System.Drawing.Point(268, 13);
            this.btnCadastroClientes.Name = "btnCadastroClientes";
            this.btnCadastroClientes.Size = new System.Drawing.Size(276, 90);
            this.btnCadastroClientes.TabIndex = 1;
            this.btnCadastroClientes.Text = "Cadastro de clientes";
            this.btnCadastroClientes.UseVisualStyleBackColor = false;
            // 
            // btnCadastroFuncionarios
            // 
            this.btnCadastroFuncionarios.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastroFuncionarios.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroFuncionarios.Location = new System.Drawing.Point(13, 124);
            this.btnCadastroFuncionarios.Name = "btnCadastroFuncionarios";
            this.btnCadastroFuncionarios.Size = new System.Drawing.Size(249, 84);
            this.btnCadastroFuncionarios.TabIndex = 2;
            this.btnCadastroFuncionarios.Text = "Cadastro de funcionários";
            this.btnCadastroFuncionarios.UseVisualStyleBackColor = false;
            // 
            // btnControleEntregas
            // 
            this.btnControleEntregas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnControleEntregas.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControleEntregas.Location = new System.Drawing.Point(268, 124);
            this.btnControleEntregas.Name = "btnControleEntregas";
            this.btnControleEntregas.Size = new System.Drawing.Size(276, 84);
            this.btnControleEntregas.TabIndex = 3;
            this.btnControleEntregas.Text = "Controle de entregas";
            this.btnControleEntregas.UseVisualStyleBackColor = false;
            // 
            // btnFecharSistema
            // 
            this.btnFecharSistema.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFecharSistema.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharSistema.Location = new System.Drawing.Point(157, 238);
            this.btnFecharSistema.Name = "btnFecharSistema";
            this.btnFecharSistema.Size = new System.Drawing.Size(216, 74);
            this.btnFecharSistema.TabIndex = 4;
            this.btnFecharSistema.Text = "Fechar o Sistema";
            this.btnFecharSistema.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 324);
            this.Controls.Add(this.btnFecharSistema);
            this.Controls.Add(this.btnControleEntregas);
            this.Controls.Add(this.btnCadastroFuncionarios);
            this.Controls.Add(this.btnCadastroClientes);
            this.Controls.Add(this.btnVendaProdutos);
            this.Name = "Form1";
            this.Text = "FormPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVendaProdutos;
        private System.Windows.Forms.Button btnCadastroClientes;
        private System.Windows.Forms.Button btnCadastroFuncionarios;
        private System.Windows.Forms.Button btnControleEntregas;
        private System.Windows.Forms.Button btnFecharSistema;
    }
}

