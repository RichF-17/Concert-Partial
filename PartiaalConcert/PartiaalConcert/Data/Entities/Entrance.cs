using System.ComponentModel.DataAnnotations;

namespace PartiaalConcert.Data.Entities
{
    public class Entrance
    {
        public int Id { get; set; }

        [Display(Name = "Puerta de entrada")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Description { get; set; }

        public ICollection<Tickets> Tickets { get; set; }
    }
}
