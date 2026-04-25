using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Box_House
{
    public partial class FormVendas : Form
    {
        public class Produto
        {
            public string Nome { get; set; }
            public decimal Preco { get; set; }

            public Produto(string nome, decimal preco)
            {
                Nome = nome;
                Preco = preco;
            }

            // Isso faz com que o nome apareça no ComboBox
            public override string ToString() => Nome;
        }

        public FormVendas()
        {
            InitializeComponent();
        }

        private void cboProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
          
        }

        private void dgvItensPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvItensPedido.Columns.Clear();
            dgvItensPedido.Columns.Add("Nome", "Produto");
            dgvItensPedido.Columns.Add("Preco", "Preço Unitário");
            dgvItensPedido.Columns.Add("Qtd", "Quantidade");
            dgvItensPedido.Columns.Add("Subtotal", "Subtotal");

            // Opcional: formatação para dinheiro
            dgvItensPedido.Columns[1].DefaultCellStyle.Format = "C2";
            dgvItensPedido.Columns[3].DefaultCellStyle.Format = "C2";
        }

        private void lbReal_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
            cboProdutos.Items.Add("Ração Golden 10kg");
            cboProdutos.Items.Add("Banho + Tosa");
            cboProdutos.Items.Add("Brinquedo Mordedor");
            cboProdutos.Items.Add("Vermífugo");
            cboProdutos.Items.Add("Ração Premium 10kg");
            cboProdutos.Items.Add("Banho e Tosa Higiênica");
            cboProdutos.Items.Add("Antipulgas (Pipeta)");
            cboProdutos.Items.Add("Brinquedo de Corda");
            cboProdutos.Items.Add("Coleira Ajustável");
            cboProdutos.Items.Add("Sachê Gourmet Cão/Gato");
            cboProdutos.Items.Add("Comida de Gato");
        }
    }
}
