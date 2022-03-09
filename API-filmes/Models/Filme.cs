using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [MinLength(1, ErrorMessage = "O titulo do filme deve conter no minimo 1 caracter")]
        [MaxLength(80, ErrorMessage = "O titulo do filme deve conter no máximo 80 caracteres")]
        [Required(ErrorMessage = "Titulo obrigatório")]
        public string Titulo { get; set; }

        [MinLength(20, ErrorMessage = "A descrição do filme deve conter no minimo 20 caracteres")]
        [MaxLength(160, ErrorMessage = "A descrição do filme deve conter no máximo 160 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Classificação obrigatória")]
        public string Classificacao { get; set; }

        [Required(ErrorMessage = "Gênero obrigatório")]
        public Genero Genero { get; set; }
    }
}
