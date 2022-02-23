using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace InventariosAPI.ModelsFull
{
    public partial class CoCategoriaPrv
    {
        public CoCategoriaPrv()
        {
            CoSubcategoriaPrv = new HashSet<CoSubcategoriaPrv>();
        }

        public short CategoriaPrvId { get; set; }
        [Display(Name = "Nombre Categoría", Description = "Nombre de la categoría")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string CategoriaPrvNombre { get; set; }

        [Display(Name = "Estatus", Description = "Estatus de la categoría")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(1, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string CategoriaPrvEstatus { get; set; }

        public virtual ICollection<CoSubcategoriaPrv> CoSubcategoriaPrv { get; set; }
    }
}
