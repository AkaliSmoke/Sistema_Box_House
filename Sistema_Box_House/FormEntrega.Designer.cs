namespace Sistema_Box_House
{
    partial class FormEntrega
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
            this.gbControleEntregas = new System.Windows.Forms.GroupBox();
            this.txtEnderecoEntrega = new System.Windows.Forms.TextBox();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.btnAdicionarEntrega = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.gbEntregaCadastro = new System.Windows.Forms.GroupBox();
            this.dgvEntregasCadastro = new System.Windows.Forms.DataGridView();
            this.gbControleEntregas.SuspendLayout();
            this.gbEntregaCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregasCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // gbControleEntregas
            // 
            this.gbControleEntregas.Controls.Add(this.cboStatus);
            this.gbControleEntregas.Controls.Add(this.cboClientes);
            this.gbControleEntregas.Controls.Add(this.txtEnderecoEntrega);
            this.gbControleEntregas.Controls.Add(this.btnStatus);
            this.gbControleEntregas.Controls.Add(this.btnLimparCampos);
            this.gbControleEntregas.Controls.Add(this.btnAdicionarEntrega);
            this.gbControleEntregas.Controls.Add(this.label3);
            this.gbControleEntregas.Controls.Add(this.label2);
            this.gbControleEntregas.Controls.Add(this.label1);
            this.gbControleEntregas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbControleEntregas.Location = new System.Drawing.Point(13, 13);
            this.gbControleEntregas.Name = "gbControleEntregas";
            this.gbControleEntregas.Size = new System.Drawing.Size(775, 233);
            this.gbControleEntregas.TabIndex = 0;
            this.gbControleEntregas.TabStop = false;
            this.gbControleEntregas.Text = "Controle de Entregas";
            // 
            // txtEnderecoEntrega
            // 
            this.txtEnderecoEntrega.Location = new System.Drawing.Point(167, 87);
            this.txtEnderecoEntrega.Name = "txtEnderecoEntrega";
            this.txtEnderecoEntrega.Size = new System.Drawing.Size(577, 22);
            this.txtEnderecoEntrega.TabIndex = 7;
            this.txtEnderecoEntrega.TextChanged += new System.EventHandler(this.txtEnderecoEntrega_TextChanged);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(518, 201);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(251, 26);
            this.btnStatus.TabIndex = 5;
            this.btnStatus.Text = "Atualizar Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(254, 201);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(258, 26);
            this.btnLimparCampos.TabIndex = 4;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // btnAdicionarEntrega
            // 
            this.btnAdicionarEntrega.Location = new System.Drawing.Point(7, 201);
            this.btnAdicionarEntrega.Name = "btnAdicionarEntrega";
            this.btnAdicionarEntrega.Size = new System.Drawing.Size(240, 26);
            this.btnAdicionarEntrega.TabIndex = 3;
            this.btnAdicionarEntrega.Text = "Adicionar Entrega";
            this.btnAdicionarEntrega.UseVisualStyleBackColor = true;
            this.btnAdicionarEntrega.Click += new System.EventHandler(this.btnAdicionarEntrega_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status Atual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço de Entrega:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecionar Cliente:";
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(167, 49);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(577, 24);
            this.cboClientes.TabIndex = 8;
            this.cboClientes.SelectedIndexChanged += new System.EventHandler(this.cboClientes_SelectedIndexChanged);
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(167, 126);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(577, 24);
            this.cboStatus.TabIndex = 9;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // gbEntregaCadastro
            // 
            this.gbEntregaCadastro.Controls.Add(this.dgvEntregasCadastro);
            this.gbEntregaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEntregaCadastro.Location = new System.Drawing.Point(13, 253);
            this.gbEntregaCadastro.Name = "gbEntregaCadastro";
            this.gbEntregaCadastro.Size = new System.Drawing.Size(769, 185);
            this.gbEntregaCadastro.TabIndex = 1;
            this.gbEntregaCadastro.TabStop = false;
            this.gbEntregaCadastro.Text = "Lista de Entregas Cadastro";
            // 
            // dgvEntregasCadastro
            // 
            this.dgvEntregasCadastro.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEntregasCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregasCadastro.Location = new System.Drawing.Point(7, 22);
            this.dgvEntregasCadastro.Name = "dgvEntregasCadastro";
            this.dgvEntregasCadastro.Size = new System.Drawing.Size(756, 157);
            this.dgvEntregasCadastro.TabIndex = 0;
            this.dgvEntregasCadastro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntregasCadastro_CellContentClick);
            // 
            // FormEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbEntregaCadastro);
            this.Controls.Add(this.gbControleEntregas);
            this.Name = "FormEntrega";
            this.Text = "FormEntrega";
            this.gbControleEntregas.ResumeLayout(false);
            this.gbControleEntregas.PerformLayout();
            this.gbEntregaCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregasCadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbControleEntregas;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Button btnAdicionarEntrega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnderecoEntrega;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.GroupBox gbEntregaCadastro;
        private System.Windows.Forms.DataGridView dgvEntregasCadastro;
    }
}