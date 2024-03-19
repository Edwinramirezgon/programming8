using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class PetType
    {
        public int Id { get; set; }


        [Display(Name = "Tipo De Mascota")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo  {0} es obligatorio")]
        public string Nombre { get; set; }
    }
}
