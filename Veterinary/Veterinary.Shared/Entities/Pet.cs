using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class Pet
    {

        public int Id { get; set; }


        [Display(Name = "Nombre Mascota")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo  {0} es obligatorio")]
        public string Name { get; set; }


        [Display(Name = "Foto")]
        public string ImageUrl {  get; set; }


        [Display(Name = "Raza")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo  {0} es obligatorio")]
        public string race { get; set; }


        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}",
           ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo  {0} es obligatorio")]
        public DateTime Born { get; set; }


        public string Remarks { get; set; }

        public Owner  Owners { get; set; }

        public ICollection<History> Historys { get; set; }   
        
        public PetType PetTypes { get; set; }

        public ICollection<Agend> Agends { get; set; }



    }
}
