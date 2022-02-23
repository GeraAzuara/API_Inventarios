using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace InventariosAPI.ModelsFull
{
    public partial class CoProveedorescomprador
    {
        public short ProveedorId { get; set; }
        public short CocontactoId { get; set; }


        [Display(Name = "Nombre Comprador", Description = "Nombre del Comprador")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string CocontactoNombre { get; set; }

        [Display(Name = "Puesto del comprador", Description = "Puesto del comprador")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string CocontactoPuesto { get; set; }

        [Display(Name = "Telefono", Description = "Telefono de contacto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string CocontactoTelefono { get; set; }

        [Display(Name = "Extensión", Description = "Extensión comprador")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string CocontactoExt { get; set; }

        [Display(Name = "Celular", Description = "Celular del comprador")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string CocontactoCelular { get; set; }


        [Display(Name = "E-mail", Description = "E-mail del comprador")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string CocontactoEmail { get; set; }
        public virtual CoProveedores Proveedor { get; set; }
    }
}
