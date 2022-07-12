using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drop7_ListaArquivoEEscrita
{
    internal class Pessoa
    {
       public  string nome;
        public string email;

        //método construtor
      public Pessoa(string n, string e)
        {
            nome = n;
            email = e;
        }
    }
}
