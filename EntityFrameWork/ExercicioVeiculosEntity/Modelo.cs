using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVeiculosEntity
{
    [Table("Modelos")] //fique ligado nessa notação
    public class Modelo
    {
        [Key()] //forçando que Id é a chave primária
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
