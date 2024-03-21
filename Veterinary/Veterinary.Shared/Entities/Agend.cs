using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class Agend
    {

        public int Id { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}",
           ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo  {0} es obligatorio")]
        public DateTime Date { get; set; }

        public string Remarks { get; set; }


        [Display(Name="Is available")]
        public bool Isavailable { get; set; }


        public Pet pets { get; set; }

        public Owner owners { get; set; }    
    }
}
