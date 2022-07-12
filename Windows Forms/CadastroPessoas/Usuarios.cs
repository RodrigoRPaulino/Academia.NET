/*Criar uma aplicação utilizando windows form para cadastro de usuários.
O sistema deve possuir uma classe usuário e ter todos os atributos necessários para
cadastro de um usuário.
Atributos: nome, telefone, cpf, login, senha, status(ativo ou inativo),
tipo(administrador ou usuário).
Crie um formulário para cadastro contendo estes campos para cadastro. Ao clicar no botão,
 deve ser instanciado um objeto da classe.*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPessoas
{
    /// <summary>
    /// Criando as variaveis para cadastro
    /// </summary>
    class Usuarios
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Status { get; set; }
        public string Tipo { get; set; }

        public Usuarios(string nome, string telefone, string cpf, string login, string senha, bool status, string tipo)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
            this.Login = login;
            this.Senha = senha;
            this.Status = status;
            this.Tipo = tipo;

        }
        public static void MostrarCadastros()
        {
            MessageBox.Show($"Nome: ");
            
        }
    }



}
