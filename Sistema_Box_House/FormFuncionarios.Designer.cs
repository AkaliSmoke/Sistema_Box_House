namespace Sistema_Box_House
{
    partial class FormFuncionarios
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
            this.gbCadastroFuncionario = new System.Windows.Forms.GroupBox();
            this.gbListaFuncionario = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvListaFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.gbCadastroFuncionario.SuspendLayout();
            this.gbListaFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCadastroFuncionario
            // 
            this.gbCadastroFuncionario.Controls.Add(this.txtCPF);
            this.gbCadastroFuncionario.Controls.Add(this.txtTelefone);
            this.gbCadastroFuncionario.Controls.Add(this.btnExcluir);
            this.gbCadastroFuncionario.Controls.Add(this.btnLimpar);
            this.gbCadastroFuncionario.Controls.Add(this.btnSalvar);
            this.gbCadastroFuncionario.Controls.Add(this.txtNome);
            this.gbCadastroFuncionario.Controls.Add(this.label3);
            this.gbCadastroFuncionario.Controls.Add(this.label2);
            this.gbCadastroFuncionario.Controls.Add(this.label1);
            this.gbCadastroFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastroFuncionario.Location = new System.Drawing.Point(13, 13);
            this.gbCadastroFuncionario.Name = "gbCadastroFuncionario";
            this.gbCadastroFuncionario.Size = new System.Drawing.Size(775, 206);
            this.gbCadastroFuncionario.TabIndex = 0;
            this.gbCadastroFuncionario.TabStop = false;
            this.gbCadastroFuncionario.Text = "Cadastro de Funcionários";
            // 
            // gbListaFuncionario
            // 
            this.gbListaFuncionario.Controls.Add(this.dgvListaFuncionarios);
            this.gbListaFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListaFuncionario.Location = new System.Drawing.Point(13, 225);
            this.gbListaFuncionario.Name = "gbListaFuncionario";
            this.gbListaFuncionario.Size = new System.Drawing.Size(775, 213);
            this.gbListaFuncionario.TabIndex = 1;
            this.gbListaFuncionario.TabStop = false;
            this.gbListaFuncionario.Text = "Lista de Funcionários";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(103, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(666, 22);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // dgvListaFuncionarios
            // 
            this.dgvListaFuncionarios.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListaFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaFuncionarios.Location = new System.Drawing.Point(9, 25);
            this.dgvListaFuncionarios.Name = "dgvListaFuncionarios";
            this.dgvListaFuncionarios.Size = new System.Drawing.Size(760, 182);
            this.dgvListaFuncionarios.TabIndex = 0;
            this.dgvListaFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaFuncionarios_CellContentClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(9, 162);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(247, 38);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar Funcionário";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(263, 162);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(240, 38);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(509, 162);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(260, 38);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir Funcionário";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(103, 69);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 22);
            this.txtTelefone.TabIndex = 10;
            this.txtTelefone.Text = "(__) ___-____";
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtTelefone_TextChanged);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(103, 104);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(199, 22);
            this.txtCPF.TabIndex = 11;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbListaFuncionario);
            this.Controls.Add(this.gbCadastroFuncionario);
            this.Name = "FormFuncionarios";
            this.Text = "FormFuncionarios";
            this.gbCadastroFuncionario.ResumeLayout(false);
            this.gbCadastroFuncionario.PerformLayout();
            this.gbListaFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCadastroFuncionario;
        private System.Windows.Forms.GroupBox gbListaFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvListaFuncionarios;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCPF;
    }
}