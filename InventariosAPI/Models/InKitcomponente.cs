using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventariosAPI.Models
{
    public partial class InKitcomponente
    {
        #region Colección de Campos
        [Display(Name = "Id del Kit", Description = "Identificador único del Kit")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public short KitId { get; set; }

        [Display(Name = "Id del Componente", Description = "Identificador Único del Componente")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(25, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string ComponenteId { get; set; }

        [Display(Name = "Cantidad", Description = "Cantidad del Componente")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public decimal ComponenteCantidad { get; set; }
        #endregion

        #region Entidades relacionadas
        [Display(Name = "Componente", Description = "Componente relacionado")]
        public virtual InProducto Componente { get; set; }

        [Display(Name = "Kit", Description = "Kit relacionado")]
        public virtual InKit Kit { get; set; }
        #endregion


        public InKitcomponente() { }
        public InKitcomponente(short KitId, string ComponenteId)
        {
            this.KitId = KitId;
            this.ComponenteId = ComponenteId;
            ComponenteCantidad = 0;
        }

    }
}
