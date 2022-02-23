using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventariosAPI.ModelsFull
{
    public partial class InUnidadEmpaque
    {
        public InUnidadEmpaque()
        {
            InProducto = new HashSet<InProducto>();
        }

        #region Colección de Campos

        [Display(Name = "Id de la Unidad de Empaque", Description = "Identificador único de la Unidad de Empaque")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public short UnidadEmpaqueId { get; set; }

        [Display(Name = "Etiqueta", Description = "Etiqueta de la Unidad de Empaque")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(25, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string UnidadEmpaqueTag { get; set; }

        [Display(Name = "Nombre", Description = "Nombre de la Unidad de Empaque")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string UnidadEmpaqueNombre { get; set; }

        [Display(Name = "Estatus", Description = "Estatus de la Unidad de Empaque")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(1, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string UnidadEmpaqueEstatus { get; set; }

        [Display(Name = "Id de la Unidad de Empaque", Description = "Identificador único de la Clave de Unidad")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public string ClaveUnidadId { get; set; }

        #endregion

        #region Entidades Relacionadas

        [Display(Name = "Clave de Unidad", Description = "Clave de Unidad Relacionada")]
        public virtual Cveunidad ClaveUnidad { get; set; }

        #endregion

        #region Colecciones asociadas

        [Display(Name = "Productos", Description = "Productos asociados")]
        public virtual ICollection<InProducto> InProducto { get; set; }

        #endregion
    }
}
