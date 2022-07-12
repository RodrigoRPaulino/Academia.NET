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
    public partial class frm_Clientes : Form
    {

       
        public frm_Clientes()
        {
            InitializeComponent();           
        }
       
        private void btn_CadastrarCliente_Click(object sender, EventArgs e)
        {

            ClienteExiste();           
        }
        /// <summary>
        /// método para verificar se o cliente ja está cadastrado no banco de dados.
        /// </summary>
        /// <returns></returns>
        public bool ClienteExiste()
        {
            // condicão escolhida pelo nome que o usuario digitar. 
            if (tb_Nome.Text.Equals(tb_Nome))
            {
                MessageBox.Show("Cliente já cadastrado");
                return true;   
            }
            // se a condição do if for falsa o programa adiciona o cliente.
            else
            {
                Clientes pessoas = new Clientes
                (tb_Nome.Text.ToUpper(), tb_Cpf.Text, tb_Telefone.Text, tb_Endereco.Text.ToUpper(), tb_Cidade.Text.ToUpper(), tb_Email.Text.ToLower());
                pessoas.GravarCliente();
                // criei uma array no data grid para mostrar os dados inseridos.
                dgv_Clientes.Rows.Add (new object[] { tb_Nome.Text.ToUpper(), tb_Cpf.Text, tb_Telefone.Text, tb_Endereco.Text.ToUpper(), tb_Cidade.Text.ToUpper(), tb_Email.Text.ToLower()});               
                MessageBox.Show("Cliente cadastrado com sucesso!");            
            }
            return false;
            
        }
        /// <summary>
        /// botao que volta a tela principal do programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            frm_Home home = new frm_Home();
            home.ShowDialog();
            home.Focus();
            home.Close();
            frm_Clientes cadastros = new frm_Clientes();
            cadastros.Close();
        }
        /// <summary>
        /// botao que executa o método para cadastrar o cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CadastrarCliente_Click_1(object sender, EventArgs e)
        {
            ClienteExiste();
        }
    }
}
