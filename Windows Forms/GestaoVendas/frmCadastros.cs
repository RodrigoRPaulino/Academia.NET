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
using System.Configuration;




namespace GestaoVendas
{
    public partial class frmCadastros : Form
    {

        //private string conexaoString = ConfigurationManager.ConnectionStrings["GestaoVendasString"].ConnectionString;
        public frmCadastros()
        {
            InitializeComponent();
        }

        

        private void btn_CadastrarCliente_Click(object sender, EventArgs e)
        {
            Clientes pessoas = new Clientes
            (tb_Nome.Text.ToUpper(), tb_Cpf.Text, tb_Telefone.Text, tb_Endereco.Text.ToUpper(), tb_Cidade.Text.ToUpper(), tb_Email.Text.ToLower());
            pessoas.GravarCliente();
            
            
            MessageBox.Show("Cliente cadastrado com sucesso!");
            //dgv_Clientes.Rows.Add(tb_Nome.Text.ToUpper(), tb_Cpf.Text, tb_Telefone.Text, tb_Endereco.Text.ToUpper(), tb_Cidade.Text.ToUpper(), tb_Email.Text.ToLower());

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            frm_Home home = new frm_Home();
            home.ShowDialog();
            home.Focus();
            home.Close();
        }
    }
}
