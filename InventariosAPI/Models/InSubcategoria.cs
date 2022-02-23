using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventariosAPI.Models
{
    public partial class InSubcategoria
    {
        public InSubcategoria()
        {
            InProducto = new HashSet<InProducto>();
        }

        [Display(Name = "Id_Subcategoria", Description = "Identificador único de la Subcategoría")]
        public int InSubCategoriaId { get; set; }

        [Display(Name = "Nombre", Description = "Nombre de la Subcategoría")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InSubCategoriaNombre { get; set; }

        [Display(Name = "Categoría", Description = "Categoría asociada")]
        public int InCategoriaId { get; set; }

        [Display(Name = "Estatus", Description = "Subcategorías relacionadas")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(1, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InSubCategoriaEstatus { get; set; }

        [Display(Name = "Categoría", Description = "Categoría asociada")]
        public virtual InCategoria InCategoria { get; set; }

        [Display(Name = "Productos", Description = "Productos relacionadas")]
        public virtual ICollection<InProducto> InProducto { get; set; }
    }
}
