﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal_RodrigoPaulino.Models
{
    [Table("Produtos")]
    public class ProdutosModel
    {
        [Key]
        public int IdProduto { get; set; }
       
        public int Id { get; set; }
        [ForeignKey("Id")]
        //public LojasModel Lojas { get; set; }
        public string NomeProduto { get; set; }
        public string Tamanho { get; set; }
        public string Cor { get; set; }
        public double Valor { get; set; }


    }
}
