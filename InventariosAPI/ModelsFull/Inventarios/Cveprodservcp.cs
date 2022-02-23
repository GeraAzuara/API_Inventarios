using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventariosAPI.ModelsFull
{
    public partial class Cveprodservcp
    {
        public Cveprodservcp()
        {
            InLineaproducto = new HashSet<InLineaproducto>();
        }

        #region Coleccion de Campos

        [Display(Name = "Clave Prod-Serv CP", Description = "Clave Prod-Serv CP")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(25, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string CveProdServCpid { get; set; }

        [Display(Name = "Descripción", Description = "Descripción")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(255, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string CveProdServDescripcion { get; set; }

        [Display(Name = "Palabras Similares", Description = "Palabras Similares")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(255, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string CveProdServPalabrasSimi { get; set; }

        [Display(Name = "Material Peligroso", Description = "Material Peligroso")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(5, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string CveProdServMaterialPeligro { get; set; }

        [Display(Name = "Clave Material Peligroso", Description = "Clave Material Peligroso")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(4, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string MaterialPeligrosoId { get; set; }

        #endregion


        #region Entidades Relacionadas

        [Display(Name = "Material Peligroso", Description = "Material Peligroso relacionado")]
        public virtual Materialpeligroso MaterialPeligroso { get; set; }

        #endregion


        #region Colecciones asociadas

        [Display(Name = "Lineas de Productos", Description = "Lineas de Productos asociados")]
        public virtual ICollection<InLineaproducto> InLineaproducto { get; set; }

        #endregion
    }
}
