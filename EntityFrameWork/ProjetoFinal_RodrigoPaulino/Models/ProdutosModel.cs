using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal_RodrigoPaulino.Models
{
    [Table("Produtos")]
    public class ProdutosModel
    {
        [Key]
        public int Id { get; set; }
        public int IdLoja { get; set; }
        public LojasModel Loja { get; set; }
        public string Nome { get; set; }
        public string Tamanho { get; set; }
        public string Cor { get; set; }
        public double Valor { get; set; }


    }
}
