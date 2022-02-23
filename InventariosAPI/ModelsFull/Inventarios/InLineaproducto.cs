using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventariosAPI.ModelsFull
{
    public partial class InLineaproducto
    {
        public InLineaproducto()
        {
            InProducto = new HashSet<InProducto>();
        }

        #region Coleccion de Campos

        [Display(Name = "Id de Línea", Description = "Identificador único del Línea del Producto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public int LineaProductoId { get; set; }

        [Display(Name = "Nombre de la Línea", Description = "Nombre de la Línea")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string LineaProductoNombre { get; set; }

        [Display(Name = "Clave del Prod/Serv", Description = "Clave del Prod/Serv")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(25, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string CveProdServCpid { get; set; }
        
        #endregion

        #region Entidades Relacionadas

        [Display(Name = "Clave del Prod/Servicio", Description = "Clave del Prod/Servicio relacionado")]
        public virtual Cveprodservcp CveProdServCp { get; set; }
        
        #endregion

        #region Colecciones asociadas

        [Display(Name = "Productos", Description = "Productos asociados")]
        public virtual ICollection<InProducto> InProducto { get; set; }
        
        #endregion
    }
}
