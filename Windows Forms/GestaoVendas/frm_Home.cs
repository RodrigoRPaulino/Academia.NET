using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace GestaoVendas
{
    public partial class frm_Home : Form
    {

        public frm_Home()
        {
            InitializeComponent();
        }
       

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Clientes clientes = new frm_Clientes();
            clientes.ShowDialog();
            clientes.Focus();


           

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Produtos produtos = new frm_Produtos();
            produtos.ShowDialog();
            produtos.Focus();   
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Vendas estoque = new frm_Vendas();
            estoque.ShowDialog();
            estoque.Focus();
        }

        private void itensVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ItemVenda itemVenda = new frm_ItemVenda();
            itemVenda.ShowDialog();
            itemVenda.Focus();

        }
    }
}
