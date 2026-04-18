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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVendaProdutos
            // 
            this.btnVendaProdutos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVendaProdutos.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendaProdutos.Location = new System.Drawing.Point(13, 160);
            this.btnVendaProdutos.Name = "btnVendaProdutos";
            this.btnVendaProdutos.Size = new System.Drawing.Size(249, 90);
            this.btnVendaProdutos.TabIndex = 0;
            this.btnVendaProdutos.Text = "Registrar Vendas";
            this.btnVendaProdutos.UseVisualStyleBackColor = false;
            this.btnVendaProdutos.Click += new System.EventHandler(this.btnVendaProdutos_Click);
            // 
            // btnCadastroClientes
            // 
            this.btnCadastroClientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastroClientes.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroClientes.Location = new System.Drawing.Point(268, 160);
            this.btnCadastroClientes.Name = "btnCadastroClientes";
            this.btnCadastroClientes.Size = new System.Drawing.Size(276, 90);
            this.btnCadastroClientes.TabIndex = 1;
            this.btnCadastroClientes.Text = "Clientes e Pets";
            this.btnCadastroClientes.UseVisualStyleBackColor = false;
            this.btnCadastroClientes.Click += new System.EventHandler(this.btnCadastroClientes_Click);
            // 
            // btnCadastroFuncionarios
            // 
            this.btnCadastroFuncionarios.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastroFuncionarios.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroFuncionarios.Location = new System.Drawing.Point(13, 271);
            this.btnCadastroFuncionarios.Name = "btnCadastroFuncionarios";
            this.btnCadastroFuncionarios.Size = new System.Drawing.Size(249, 84);
            this.btnCadastroFuncionarios.TabIndex = 2;
            this.btnCadastroFuncionarios.Text = "Gerenciar Funcionário";
            this.btnCadastroFuncionarios.UseVisualStyleBackColor = false;
            this.btnCadastroFuncionarios.Click += new System.EventHandler(this.btnCadastroFuncionarios_Click);
            // 
            // btnControleEntregas
            // 
            this.btnControleEntregas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnControleEntregas.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControleEntregas.Location = new System.Drawing.Point(268, 271);
            this.btnControleEntregas.Name = "btnControleEntregas";
            this.btnControleEntregas.Size = new System.Drawing.Size(276, 84);
            this.btnControleEntregas.TabIndex = 3;
            this.btnControleEntregas.Text = "Status de Entregas";
            this.btnControleEntregas.UseVisualStyleBackColor = false;
            this.btnControleEntregas.Click += new System.EventHandler(this.btnControleEntregas_Click);
            // 
            // btnFecharSistema
            // 
            this.btnFecharSistema.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFecharSistema.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharSistema.Location = new System.Drawing.Point(150, 385);
            this.btnFecharSistema.Name = "btnFecharSistema";
            this.btnFecharSistema.Size = new System.Drawing.Size(216, 74);
            this.btnFecharSistema.TabIndex = 4;
            this.btnFecharSistema.Text = "Encerrar a Sessão";
            this.btnFecharSistema.UseVisualStyleBackColor = false;
            this.btnFecharSistema.Click += new System.EventHandler(this.btnFecharSistema_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 79);
            this.label1.TabIndex = 5;
            this.label1.Text = "BOX HOUSE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFecharSistema);
            this.Controls.Add(this.btnControleEntregas);
            this.Controls.Add(this.btnCadastroFuncionarios);
            this.Controls.Add(this.btnCadastroClientes);
            this.Controls.Add(this.btnVendaProdutos);
            this.Name = "Form1";
            this.Text = "FormPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVendaProdutos;
        private System.Windows.Forms.Button btnCadastroClientes;
        private System.Windows.Forms.Button btnCadastroFuncionarios;
        private System.Windows.Forms.Button btnControleEntregas;
        private System.Windows.Forms.Button btnFecharSistema;
        private System.Windows.Forms.Label label1;
    }
}

