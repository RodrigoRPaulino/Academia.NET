using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    internal class Livro
    //atributos

    {
        public string Titulo;
        public string Autor;
        public int Paginas;
        public int Ano;
        public int Edicao;

        public Livro(string tit, string au, int pag, int an, int ed)
        {
            Titulo = tit;
            Autor = au;
            Paginas = pag;
            Ano = an;
            Edicao = ed;

        }

        public void apresentaInfoLivro()
        {
            Console.WriteLine($"O livro de titulo {Titulo} do autor {Autor} com {Paginas} paginas do ano de {Ano} da edição {Edicao}");

        }
    }
}
