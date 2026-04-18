namespace Sistema_Box_House
{
    partial class FormVendas
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
            this.gbSelecaoProdutos = new System.Windows.Forms.GroupBox();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.lbProduto = new System.Windows.Forms.Label();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.cboProdutos = new System.Windows.Forms.ComboBox();
            this.gbItensPedido = new System.Windows.Forms.GroupBox();
            this.dgvItensPedido = new System.Windows.Forms.DataGridView();
            this.lbTotalPedido = new System.Windows.Forms.Label();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.lbReal = new System.Windows.Forms.Label();
            this.gbSelecaoProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.gbItensPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSelecaoProdutos
            // 
            this.gbSelecaoProdutos.Controls.Add(this.btnAdicionarItem);
            this.gbSelecaoProdutos.Controls.Add(this.lbQuantidade);
            this.gbSelecaoProdutos.Controls.Add(this.lbProduto);
            this.gbSelecaoProdutos.Controls.Add(this.nudQuantidade);
            this.gbSelecaoProdutos.Controls.Add(this.cboProdutos);
            this.gbSelecaoProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSelecaoProdutos.Location = new System.Drawing.Point(13, 13);
            this.gbSelecaoProdutos.Name = "gbSelecaoProdutos";
            this.gbSelecaoProdutos.Size = new System.Drawing.Size(775, 206);
            this.gbSelecaoProdutos.TabIndex = 0;
            this.gbSelecaoProdutos.TabStop = false;
            this.gbSelecaoProdutos.Text = "Tela de Seleção de Produtos";
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarItem.Location = new System.Drawing.Point(650, 167);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(119, 33);
            this.btnAdicionarItem.TabIndex = 4;
            this.btnAdicionarItem.Text = "Adicionar Item";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidade.Location = new System.Drawing.Point(25, 82);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(91, 16);
            this.lbQuantidade.TabIndex = 3;
            this.lbQuantidade.Text = "Quantidade:";
            // 
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduto.Location = new System.Drawing.Point(25, 40);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(65, 16);
            this.lbProduto.TabIndex = 2;
            this.lbProduto.Text = "Produto:";
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(149, 76);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(120, 22);
            this.nudQuantidade.TabIndex = 1;
            this.nudQuantidade.ValueChanged += new System.EventHandler(this.nudQuantidade_ValueChanged);
            // 
            // cboProdutos
            // 
            this.cboProdutos.FormattingEnabled = true;
            this.cboProdutos.Location = new System.Drawing.Point(149, 32);
            this.cboProdutos.Name = "cboProdutos";
            this.cboProdutos.Size = new System.Drawing.Size(462, 24);
            this.cboProdutos.TabIndex = 0;
            this.cboProdutos.Tag = "";
            this.cboProdutos.SelectedIndexChanged += new System.EventHandler(this.cboProdutos_SelectedIndexChanged);
            // 
            // gbItensPedido
            // 
            this.gbItensPedido.Controls.Add(this.dgvItensPedido);
            this.gbItensPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItensPedido.Location = new System.Drawing.Point(13, 226);
            this.gbItensPedido.Name = "gbItensPedido";
            this.gbItensPedido.Size = new System.Drawing.Size(775, 205);
            this.gbItensPedido.TabIndex = 1;
            this.gbItensPedido.TabStop = false;
            this.gbItensPedido.Text = "Itens do Pedido";
            // 
            // dgvItensPedido
            // 
            this.dgvItensPedido.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvItensPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensPedido.Location = new System.Drawing.Point(7, 20);
            this.dgvItensPedido.Name = "dgvItensPedido";
            this.dgvItensPedido.Size = new System.Drawing.Size(762, 179);
            this.dgvItensPedido.TabIndex = 0;
            this.dgvItensPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItensPedido_CellContentClick);
            // 
            // lbTotalPedido
            // 
            this.lbTotalPedido.AutoSize = true;
            this.lbTotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPedido.Location = new System.Drawing.Point(13, 460);
            this.lbTotalPedido.Name = "lbTotalPedido";
            this.lbTotalPedido.Size = new System.Drawing.Size(227, 31);
            this.lbTotalPedido.TabIndex = 2;
            this.lbTotalPedido.Text = "Total do Pedido:";
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarPedido.Location = new System.Drawing.Point(663, 460);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(119, 33);
            this.btnFinalizarPedido.TabIndex = 3;
            this.btnFinalizarPedido.Text = "Finalizar Pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = true;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // lbReal
            // 
            this.lbReal.AutoSize = true;
            this.lbReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReal.Location = new System.Drawing.Point(246, 462);
            this.lbReal.Name = "lbReal";
            this.lbReal.Size = new System.Drawing.Size(0, 31);
            this.lbReal.TabIndex = 4;
            this.lbReal.Click += new System.EventHandler(this.lbReal_Click);
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.lbReal);
            this.Controls.Add(this.btnFinalizarPedido);
            this.Controls.Add(this.lbTotalPedido);
            this.Controls.Add(this.gbItensPedido);
            this.Controls.Add(this.gbSelecaoProdutos);
            this.Name = "FormVendas";
            this.Text = "FormVendas";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            this.gbSelecaoProdutos.ResumeLayout(false);
            this.gbSelecaoProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.gbItensPedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSelecaoProdutos;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.ComboBox cboProdutos;
        private System.Windows.Forms.GroupBox gbItensPedido;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Label lbProduto;
        private System.Windows.Forms.DataGridView dgvItensPedido;
        private System.Windows.Forms.Label lbTotalPedido;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.Label lbReal;
    }
}