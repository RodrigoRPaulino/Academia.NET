

using System.ComponentModel.DataAnnotations;

namespace ProjetoFinal_RodrigoPaulino.Models
{
    /// <summary>
    /// oitavo passo
    /// depois de criar o front-end comecamos a criar a classe de lojas para iniciar o back-end
    /// </summary>
    public class LojasModel
    {
        public int Id { get; set; }
        /// <summary>
        /// validando os campos como obrigatórios
        /// </summary>
        [Required(ErrorMessage ="Campo Obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Campo Obrigatório")]
        public string Localizacao { get; set; }
        [Required(ErrorMessage ="Campo Obrigatório")]
        public string Seguimento { get; set; }
        [Required(ErrorMessage ="Campo Obrigatório")]
        public string Telefone { get; set; }
    }
}
