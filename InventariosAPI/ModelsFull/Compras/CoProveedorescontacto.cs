using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace InventariosAPI.ModelsFull
{
    public partial class CoProveedorescontacto
    {
        public short ProveedorId { get; set; }
        public short PrvContactoId { get; set; }

        [Display(Name = "Nombre contacto", Description = "Nombre del contacto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string PrvContactoNombre { get; set; }

        [Display(Name = "Puesto del contacto", Description = "Puesto del contacto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string PrvContactoPuesto { get; set; }


        [Display(Name = "Telefono", Description = "Telefono de contacto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string PrvContactoTelefono { get; set; }

        [Display(Name = "E-mail", Description = "E-mail del contacto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string PrvContactoEmail { get; set; }

        [Display(Name = "Celular", Description = "Celular del contacto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string PrvContactoCelular { get; set; }

        [Display(Name = "Extensión", Description = "Extensión del contacto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string PrvContactoExt { get; set; }

        public virtual CoProveedores Proveedor { get; set; }
    }
}
