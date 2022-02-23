using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace InventariosAPI.ModelsFull
{
    public partial class CoProveedores
    {
        public CoProveedores()
        {
            CoProductosPrv = new HashSet<CoProductosPrv>();
            CoProveedorescomprador = new HashSet<CoProveedorescomprador>();
            CoProveedorescontacto = new HashSet<CoProveedorescontacto>();
        }

        public short ProveedorId { get; set; }
        [Display(Name = "Nombre Proveedor", Description = "Nombre del proveedor")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string ProveedorNombre { get; set; }

        [Display(Name = "Razón social", Description = "Razón social")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(255, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string ProveedorRazonSocial { get; set; }

        [Display(Name = "RFC Empresa", Description = "RFC de la empresa")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [RegularExpression("[A-Z]{4}[0-9]{6}[A-Z0-9]{3}")]
        [StringLength(255, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string ProveedorRfc { get; set; }


        public string ProveedorTag { get; set; }

        [Display(Name = "Estatus", Description = "Estatus del proveedor")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(1, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string ProveedorEstatus { get; set; }


        public string ProveedorCp { get; set; }
        public string RegFisId { get; set; }

        [Display(Name = "Calle", Description = "Calle del proveedor")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string ProveedorCalle { get; set; }

        [Display(Name = "No.Exterior", Description = "Número exterior")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string ProveedorNoExt { get; set; }

        [Display(Name = "No.Interior", Description = "Número interior")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string ProveedorNoInt { get; set; }

        [Display(Name = "Referencia Proveedor", Description = "Referencia del proveedor")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string ProveedorReferencia { get; set; }

        [Display(Name = "Colonia", Description = "Colonia del proveedor")]
        public int? CColoniaId { get; set; }

        [Display(Name = "Localidad", Description = "Localidad del proveedor")]
        public int? CLocalidadId { get; set; }

        [Display(Name = "Municipio", Description = "Municipio del proveedor")]
        public int? CMunicipioId { get; set; }

        public virtual ICollection<CoProductosPrv> CoProductosPrv { get; set; }
        public virtual ICollection<CoProveedorescomprador> CoProveedorescomprador { get; set; }
        public virtual ICollection<CoProveedorescontacto> CoProveedorescontacto { get; set; }


    }
}
