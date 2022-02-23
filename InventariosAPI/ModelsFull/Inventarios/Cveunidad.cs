using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventariosAPI.ModelsFull
{
    public partial class Cveunidad
    {
        public Cveunidad()
        {
            InUnidadEmpaque = new HashSet<InUnidadEmpaque>();
        }

        #region Coleccion de Campos

        [Display(Name = "Clave de Unidad", Description = "Clave de la Unidad")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(10, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string ClaveUnidadId { get; set; }

        [Display(Name = "Nombre de la Clave de Unidad", Description = "Nombre de la Clave de la Unidad")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string ClaveUnidadNombre { get; set; }

        [Display(Name = "Tipo Clave de Unidad", Description = "Tipo de Clave de la Unidad")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(70, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string ClaveUnidadTipo { get; set; }

        #endregion


        #region Colecciones asociadas

        [Display(Name = "Unidades de Empaque", Description = "Unidades de Empaque asociados")]
        public virtual ICollection<InUnidadEmpaque> InUnidadEmpaque { get; set; }

        #endregion
    }
}
