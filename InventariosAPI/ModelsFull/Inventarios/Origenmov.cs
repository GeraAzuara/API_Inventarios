using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventariosAPI.ModelsFull
{
    public partial class Origenmov
    {
        public Origenmov()
        {
            InMovimientos = new HashSet<InMovimientos>();
        }

        #region Coleccion de campos
        [Display(Name = "Origen de Movimiento", Description = "Identificador único del Origen de Movimiento")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public int OrigenMovId { get; set; }

        [Display(Name = "Nombre", Description = "Nombre de la Unidad de Empaque")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string OrigenMovNombre { get; set; }

        [Display(Name = "Estatus", Description = "Estatus de la Unidad de Empaque")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(1, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string OrigenMovEstatus { get; set; }
        #endregion

        #region Colecciones asociadas
        [Display(Name = "Movimientos", Description = "Movimientos asociados")]
        public virtual ICollection<InMovimientos> InMovimientos { get; set; }
        #endregion
    }
}
