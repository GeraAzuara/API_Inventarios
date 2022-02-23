using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace InventariosAPI.ModelsFull
{
    public partial class CoSubcategoriaPrv
    {
        public short SubCategoriaPrvId { get; set; }
        [Display(Name = "Nombre subcategoria", Description = "Nombre de la subcategoria")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string SubCategoriaPrvNombre { get; set; }

        [Display(Name = "Estatus", Description = "Estatus")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(1, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string SubCategoriaPrvEstatus { get; set; }

        [Display(Name = "Categoria", Description = "Categoria del proveedor")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public short CategoriaPrvId { get; set; }

        [Display(Name = "Categoria", Description = "Categoria relacionada")]
        public virtual CoCategoriaPrv CategoriaPrv { get; set; }
    }
}
