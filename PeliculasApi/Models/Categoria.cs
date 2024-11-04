using System.ComponentModel.DataAnnotations;

namespace PeliculasApi.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public DateTime FechaCreacion { get; set; }

    }
}
