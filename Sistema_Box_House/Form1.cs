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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVendaProdutos_Click(object sender, EventArgs e)
        {
            // Substitua 'FormVendas' pelo nome que você deu ao seu formulário
            FormVendas telaVendas = new FormVendas();
            telaVendas.ShowDialog(); // Isso abre a tela em cima da principal
        }

        private void btnCadastroClientes_Click(object sender, EventArgs e)
        {
            FormClientes telaCliente = new FormClientes();
            telaCliente.ShowDialog(); // Isso abre a tela em cima da principal
        }

        private void btnCadastroFuncionarios_Click(object sender, EventArgs e)
        {
            FormFuncionarios telaFuncionarios = new FormFuncionarios();
            telaFuncionarios.ShowDialog(); // Isso abre a tela em cima da principal
        }

        private void btnControleEntregas_Click(object sender, EventArgs e)
        {
            FormEntrega telaEntrega = new FormEntrega();
            telaEntrega.ShowDialog(); // Isso abre a tela em cima da principal
        }

        private void btnFecharSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
