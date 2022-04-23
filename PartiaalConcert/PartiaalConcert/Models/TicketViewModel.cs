using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace PartiaalConcert.Models
{
    public class TicketViewModel
    {
        public int Id { get; set; }


        [Display(Name = "Estado")]
        [MaxLength(500, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public bool WasUsed { get; set; }

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Documento { get; set; }

        [Display(Name = "Name")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        [Display(Name = "Entrada")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes de seleccionar la puerta por la que va entrar.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int EntraceId { get; set; }
        public IEnumerable<SelectListItem> Entrances { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public DataType Datatype { get; set; }
    }
}
