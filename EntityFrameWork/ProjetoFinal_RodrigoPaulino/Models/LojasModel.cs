
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal_RodrigoPaulino.Models
{
    [Table("lojas")]
    public class LojasModel
    {
        public int Id { get; set; }
        public string? NomeLoja { get; set; }
        public string? Localizacao { get; set; }
        public string? Telefone { get; set; }
    }
}
