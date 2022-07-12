using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoVendas
{
    public partial class frm_ItemVenda : Form
    {
        public frm_ItemVenda()
        {
            InitializeComponent();
        }
        public bool JaVendeu()
        {
            if (tb_IdProduto.Text.Equals(tb_IdProduto))
            {
                MessageBox.Show("Essa venda já foi registrada!");
                return true;
            }
            else
            {
                ItemVenda itemVenda = new ItemVenda
                (int.Parse(tb_IdCliente.Text), int.Parse(tb_IdProduto.Text), int.Parse(tb_IdVenda.Text), double.Parse(tb_ValorUnitario.Text), int.Parse(tb_Quantidade.Text), double.Parse(tb_TotalVenda.Text));
                itemVenda.GravarItensVenda();
                dgv_ItemVenda.Rows.Add(new object[] {int.Parse(tb_IdCliente.Text), int.Parse(tb_IdProduto.Text), int.Parse(tb_IdVenda.Text), double.Parse(tb_ValorUnitario.Text), int.Parse(tb_Quantidade.Text), double.Parse(tb_TotalVenda.Text)});

                MessageBox.Show("Venda Efetuada com sucesso!");
            }
            return false;

        }

        private void btn_GravarVenda_Click(object sender, EventArgs e)
        {
            JaVendeu();
        }
    }
}
