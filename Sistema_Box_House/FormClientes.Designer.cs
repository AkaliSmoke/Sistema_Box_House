namespace Sistema_Box_House
{
    partial class FormClientes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboPet = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscarNome = new System.Windows.Forms.Button();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.btnSalvarClientes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListaClientes = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboPet);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.mtbTelefone);
            this.groupBox1.Controls.Add(this.btnBuscarNome);
            this.groupBox1.Controls.Add(this.btnLimparCampos);
            this.groupBox1.Controls.Add(this.btnSalvarClientes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Novo Cliente";
            // 
            // cboPet
            // 
            this.cboPet.Location = new System.Drawing.Point(117, 108);
            this.cboPet.Name = "cboPet";
            this.cboPet.Size = new System.Drawing.Size(365, 22);
            this.cboPet.TabIndex = 8;
            this.cboPet.TextChanged += new System.EventHandler(this.cboPet_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(117, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(365, 22);
            this.txtNome.TabIndex = 7;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(117, 75);
            this.mtbTelefone.Mask = "(999) 000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(124, 22);
            this.mtbTelefone.TabIndex = 6;
            this.mtbTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbTelefone_MaskInputRejected);
            // 
            // btnBuscarNome
            // 
            this.btnBuscarNome.Location = new System.Drawing.Point(512, 165);
            this.btnBuscarNome.Name = "btnBuscarNome";
            this.btnBuscarNome.Size = new System.Drawing.Size(257, 28);
            this.btnBuscarNome.TabIndex = 5;
            this.btnBuscarNome.Text = "Buscar por Nome";
            this.btnBuscarNome.UseVisualStyleBackColor = true;
            this.btnBuscarNome.Click += new System.EventHandler(this.btnBuscarNome_Click);
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(248, 165);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(258, 28);
            this.btnLimparCampos.TabIndex = 4;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // btnSalvarClientes
            // 
            this.btnSalvarClientes.Location = new System.Drawing.Point(13, 165);
            this.btnSalvarClientes.Name = "btnSalvarClientes";
            this.btnSalvarClientes.Size = new System.Drawing.Size(228, 28);
            this.btnSalvarClientes.TabIndex = 3;
            this.btnSalvarClientes.Text = "Salvar Cliente";
            this.btnSalvarClientes.UseVisualStyleBackColor = true;
            this.btnSalvarClientes.Click += new System.EventHandler(this.btnSalvarClientes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Pet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListaClientes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Clientes Cadastrados";
            // 
            // dgvListaClientes
            // 
            this.dgvListaClientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaClientes.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvListaClientes.Location = new System.Drawing.Point(13, 22);
            this.dgvListaClientes.Name = "dgvListaClientes";
            this.dgvListaClientes.Size = new System.Drawing.Size(750, 191);
            this.dgvListaClientes.TabIndex = 0;
            this.dgvListaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaClientes_CellContentClick);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarNome;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Button btnSalvarClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListaClientes;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.TextBox cboPet;
        private System.Windows.Forms.TextBox txtNome;
    }
}