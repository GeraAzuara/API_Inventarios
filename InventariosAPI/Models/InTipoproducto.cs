using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventariosAPI.Models
{
    public partial class InTipoproducto
    {
        public InTipoproducto()
        {
            InProducto = new HashSet<InProducto>();
        }

        #region Coleccion de Campos
        [Display(Name = "Id_TipoProducto", Description = "Identificador único del Tipo de Producto")]
        public int InTipoProductoId { get; set; }

        [Display(Name = "Nombre", Description = "Nombre del Tipo de Producto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InTipoProductoNombre { get; set; }

        [Display(Name = "Estatus", Description = "Estatus del Tipo de Producto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(1, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InTipoProductoEstatus { get; set; }
        #endregion

        #region Colecciones asocidas
        [Display(Name = "Productos", Description = "Productos asociados")]
        public virtual ICollection<InProducto> InProducto { get; set; }
        #endregion
    }
}
