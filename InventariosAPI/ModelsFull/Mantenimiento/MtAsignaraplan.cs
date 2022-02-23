using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventariosAPI.ModelsFull
{
    public partial class MtAsignaraplan
    {
        [Display(Name = "Id_Plan", Description = "Identificador único del Plan")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public short MtplanId { get; set; }

        [Display(Name = "Equipo", Description = "ID del Equipo")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(25, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string EquipoId { get; set; }

        [Display(Name = "Valor Último Indicador", Description = "Último Indicador")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public short MtultimoIndicador { get; set; }

        [Display(Name = "Fecha Último Mantenimiento", Description = "Fecha Último Mantenimiento")]
        public DateTime? MtultimaFecha { get; set; }

        [Display(Name = "Fecha Siguiente Mantenimiento", Description = "Fecha Siguiente Mantenimiento")]
        public DateTime? MtsiguienteMantto { get; set; }


        /*  Campo calculado añadido */
        [Display(Name = "Valor Siguiente Indicador", Description = "Siguiente Indicador")]
        [NotMapped]
        public short MtsiguienteIndicador { get; set; }

        [Display(Name = "Plan asociado", Description = "Plan asociado")]
        public virtual MtPlanes Mtplan { get; set; }

        /*  agregada manualmentes*/
        [NotMapped]
        public InProducto InEquipo { get; set; }

        public MtAsignaraplan()
        {
            InEquipo = null;
        }

        public MtAsignaraplan(short PlanActual, string EquipoPorIncorporar)
        {
            MtplanId = PlanActual;
            EquipoId = EquipoPorIncorporar;
            MtultimoIndicador = 0;
            MtultimaFecha = null;
            MtsiguienteMantto = null;
            InEquipo = null;
        }
    }
}
