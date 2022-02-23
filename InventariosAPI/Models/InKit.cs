using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace InventariosAPI.Models
{
    public partial class InKit
    {
        public InKit()
        {
            InKitcomponente = new HashSet<InKitcomponente>();
        }

        #region Colección de Campos
        [Display(Name = "Id_Kit", Description = "Identificador único del Kit")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public short KitId { get; set; }

        [Display(Name = "Producto", Description = "Identificador Único del Producto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(25, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InProductoId { get; set; }

        [Display(Name = "Estatus", Description = "Estatus del Kit")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(1, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string KitEstatus { get; set; }
        #endregion

        #region Entidades relacionadas
        [Display(Name = "Producto", Description = "Producto del Kit")]
        public virtual InProducto InProducto { get; set; }
        #endregion

        #region Colecciones asociadas
        [Display(Name = "Componentes", Description = "Componentes del Kit")]
        public virtual ICollection<InKitcomponente> InKitcomponente { get; set; }
        #endregion
    }
}
