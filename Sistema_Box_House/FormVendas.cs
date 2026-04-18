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
            // 1. VARIÁVEIS (Guardando os dados)
            string produto = cboProdutos.Text;
            int quantidade = (int)nudQuantidade.Value;
            decimal preco = 0;

            // 2. SE / SENÃO (Atribuindo o preço conforme o produto)
            if (produto == "Ração Golden 10kg") { preco = 150.00m; }
            else if (produto == "Banho + Tosa") { preco = 80.00m; }
            else if (produto == "Brinquedo Mordedor") { preco = 25.00m; }
            else if (produto == "Ração Premium 10kg") { preco = 180.00m; }
            else { preco = 10.00m; } // Um preço padrão caso esqueça algum

            // 3. ATRIBUIÇÃO E CONTA
            decimal totalItem = quantidade * preco;

            // 4. MOSTRANDO NO OBJETO (DataGridView)
            dgvItensPedido.Rows.Add(produto, quantidade, preco, totalItem);

            // Chame a função de somar o total aqui (aquela que criamos antes)
            AtualizarTotalVenda();
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
        private void AtualizarTotalVenda()
        {
            // 1. VARIÁVEL para guardar a soma
            decimal totalGeral = 0;

            // 2. LAÇO DE REPETIÇÃO (Começa em 0 e vai até o total de linhas da tabela)
            for (int i = 0; i < dgvItensPedido.Rows.Count; i++)
            {
                // 3. SE a linha não estiver vazia, soma o valor da coluna 3 (Total do Item)
                if (dgvItensPedido.Rows[i].Cells[3].Value != null)
                {
                    totalGeral = totalGeral + Convert.ToDecimal(dgvItensPedido.Rows[i].Cells[3].Value);
                }
            }

            // 4. ATRIBUIÇÃO do resultado final para o seu lbReal
            lbReal.Text = totalGeral.ToString("C2");
        }
    }
}
