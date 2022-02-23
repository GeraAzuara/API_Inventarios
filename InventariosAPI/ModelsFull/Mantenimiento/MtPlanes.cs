using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventariosAPI.ModelsFull
{
    public partial class MtPlanes
    {
        public MtPlanes()
        {
            MtAsignaraplan = new HashSet<MtAsignaraplan>();
        }

        [Display(Name = "Id_Plan", Description = "Identificador único del Plan")]
        public short MtplanId { get; set; }

        [Display(Name = "Nombre del Plan", Description = "Nombre del Plan")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string MtplanNombre { get; set; }

        [Display(Name = "Indicador", Description = "Indicador")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public short MtplanIndicador { get; set; }

        [Display(Name = "Periodo", Description = "Periodo")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public short MtplanPeriodo { get; set; }

        [Display(Name = "Estatus", Description = "Estatus")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(1, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string MtplanEstatus { get; set; }

        public virtual ICollection<MtAsignaraplan> MtAsignaraplan { get; set; }
    }
}
