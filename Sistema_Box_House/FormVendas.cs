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
        public FormVendas()
        {
            InitializeComponent();
        }

        private void cboProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeProduto = cboProdutos.Text;

            // Convertendo decimal para int explicitamente
            int quantidade = (int)nudQuantidade.Value;

            // Se for realmente um preço, use decimal para evitar perda de centavos
            decimal preco = nudQuantidade.Value;
        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvItensPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbReal_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Venda finalizada com sucesso!");
                dgvItensPedido.Rows.Clear();
                lbReal.Text = "R$ 0,00";
            }
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
        }
    }
}
