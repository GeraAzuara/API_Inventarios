using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventariosAPI.ModelsFull
{
    public partial class Materialpeligroso
    {
        public Materialpeligroso()
        {
            Cveprodservcp = new HashSet<Cveprodservcp>();
        }

        #region Coleccion de Campos

        [Display(Name = "Clave del Material Peligroso", Description = "Clave del Material Peligroso")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(4, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string MaterialPeligrosoId { get; set; }

        [Display(Name = "Descripcion", Description = "Descripcion")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(255, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string MaterialPeligrosoDescripcion { get; set; }

        [Display(Name = "Clase", Description = "Clase")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(10, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string MaterialPeligrosoClase { get; set; }

        [Display(Name = "Secundario", Description = "Secundario")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(10, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string MaterialPeligrosoSecundario { get; set; }

        [Display(Name = "Nombre Técnico", Description = "Nombre Técnico")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(255, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string MaterialPeligrosoNombreTecnico { get; set; }
        
        #endregion


        #region Colecciones asociadas

        [Display(Name = "Claves del Producto/Servicio", Description = "Claves del Producto/Servicio")]
        public virtual ICollection<Cveprodservcp> Cveprodservcp { get; set; }
        
        #endregion
    }
}
