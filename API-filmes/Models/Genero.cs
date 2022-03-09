using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Genero
    {
        [Key]
        public int Id { get; set; }
        public string Gender { get; set; }
    }
}
