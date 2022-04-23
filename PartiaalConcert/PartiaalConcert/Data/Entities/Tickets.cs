using System.ComponentModel.DataAnnotations;

namespace PartiaalConcert.Data.Entities
{
    public class Tickets
    {
        public int Id { get; set; }

        [Display(Name = "Estado")]
        public bool WasUsed { get; set; }

        [Display(Name = "Cédula")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Document { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Name { get; set; }

        [Display(Name = "Entrada")]
        public Entrance Entrance { get; set; }

        [Display(Name = "Fecha y hora")]
        public DateTime Date { get; set; }

        public Entrance EntranceR;
    }
}
