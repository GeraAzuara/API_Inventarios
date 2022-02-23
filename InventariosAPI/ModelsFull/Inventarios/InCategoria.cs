using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventariosAPI.ModelsFull
{
    public partial class InCategoria
    {
        public InCategoria()
        {
            InSubcategoria = new HashSet<InSubcategoria>();
        }

        #region Coleccion de campos

        [Display(Name = "Id_Categoria", Description = "Identificador único de la Categoría")]
        public int InCategoriaId { get; set; }

        [Display(Name = "Nombre", Description = "Nombre de la Categoría")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InCategorianombre { get; set; }

        [Display(Name = "Estatus", Description = "Estatus de la Categoría")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(1, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InCategoriaEstatus { get; set; }

        #endregion


        #region Colecciones Asociadas

        [Display(Name = "Subcategorías", Description = "Subcategorías asociadas")]
        public virtual ICollection<InSubcategoria> InSubcategoria { get; set; }

        #endregion

    }
}
