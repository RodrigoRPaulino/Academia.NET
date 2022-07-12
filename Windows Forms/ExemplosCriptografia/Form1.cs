using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemplosCriptografia
{
    public partial class Form1 : Form
    {
        Simetrica s;
        Assimetrica a;
        public Form1()
        {
            InitializeComponent();
            a = new Assimetrica();
            s = new Simetrica();
        }

        private void btn_Criptografia_Click(object sender, EventArgs e)
        {
            string frase, fraseCripto;
            frase = tb_Frase.Text;         
            fraseCripto = a.encrypt(frase);
            lbl_Cripto.Text = fraseCripto;

        }

        private void btn_Descriptografar_Click(object sender, EventArgs e)
        {
            string frase, fraseCriptografada;
            fraseCriptografada = lbl_Cripto.Text;
            frase = a.decrypt(fraseCriptografada);
            lbl_Descriptografar.Text = frase;
        }

        private void btn_CriptoSimetrica_Click(object sender, EventArgs e)
        {
            string frase, fraseCripto, chave;
            chave = tb_Chave.Text;
            frase = tb_Chave.Text;
            fraseCripto = s.EncryptData(frase, chave);
            lbl_Cripto.Text = fraseCripto;
        }

        private void btn_DescriptoSimetrico_Click(object sender, EventArgs e)
        {
            string fraseCripto, frase, chave;
            chave = tb_Chave.Text;
            fraseCripto = lbl_Cripto.Text;
            frase = s.DecryptData(fraseCripto,chave);
            lbl_Descriptografar.Text = frase;



        }
       
    }
}
