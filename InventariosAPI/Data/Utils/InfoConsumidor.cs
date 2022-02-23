using System.ComponentModel.DataAnnotations;

namespace InventariosAPI.Data.Utils
{
    public class InfoConsumidor
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [EmailAddress(ErrorMessage = "Correo electrónico inválido.")]
        [Display(Name = "Correo Electrónico")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        /// <summary>
        /// Nombre de la Aplicación que intenta autorizar
        /// </summary>
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string AppName { get; set; }

        /// <summary>
        /// Plataforma que intenta Autorizar (Web | Windows | Móvil)
        /// </summary>
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Plataform { get; set; }

        /// <summary>
        /// Hours Number to Token's Validity
        /// </summary>
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int TokenHours { get; set; }

        /// <summary>
        /// Integer that represents the Default Role in case missing Role Table on Server
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// String that represents the Default Role in case missing Role table on Server
        /// </summary>
        public string RoleName { get; set; }

        
    }
}
