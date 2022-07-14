
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal_RodrigoPaulino.Models
{
    //forçando o programa a criar a tabela lojas
    [Table("lojas")]
    public class LojasModel
    {
        public int Id { get; set; }
        //validando o campo como obrigatório exibindo uma menssagem de erro 
        [Required(ErrorMessage ="Digite um nome válido")]
        public string NomeLoja { get; set; }
        [Required(ErrorMessage ="Digite um endereço válido")]
        public string Localizacao { get; set; }
        //validando o campo telefone como obrigatório e fazendo tambem um phone error message
        [Required(ErrorMessage ="Digite um telefone válido")]
        [Phone(ErrorMessage ="Digite um numero de telefone válido")]
        public string Telefone { get; set; }
    }
}
