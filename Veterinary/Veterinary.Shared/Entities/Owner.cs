using System.ComponentModel.DataAnnotations;

namespace Veterinary.Shared.Entities
{
    public class Owner
    {

        public int Id { get; set; }

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Document { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo  {0} es obligatorio")]
        public string FirstName { get; set; }

        [Display(Name = "Apellido")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo  {0} es obligatorio")]

        public string LastName { get; set; }

        [Display(Name = "Email")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo  {0} es obligatorio")]
        [EmailAddress(ErrorMessage = "Digite un email valido")]
        public string Email { get; set; }


       

        public string FixedPhone { get; set; }


       
        public string addres { get; set; }

       

        public string PhoneNumber { get; set; }

        public string FullName => $"{FirstName}{LastName}";

        public ICollection<Agend> Agends { get; set; }



    }
}
