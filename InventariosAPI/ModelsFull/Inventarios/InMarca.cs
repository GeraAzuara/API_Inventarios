using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace InventariosAPI.ModelsFull
{
    public partial class InMarca
    {
        public InMarca()
        {
            InProducto = new HashSet<InProducto>();
        }

        #region Coleccion de Campos

        [Display(Name = "Id_Marca", Description = "Identificador único de la Marca")]
        public int InMarcaId { get; set; }

        [Display(Name = "Nombre", Description = "Nombre Completo de la Marca")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InMarcaNombre { get; set; }

        [Display(Name = "Estatus", Description = "Estatus de la Marca")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(1, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InMarcaEstatus { get; set; }

        #endregion

        #region Colecciones asociadas

        [Display(Name = "Estatus", Description = "Coleccion de Productos Relacionados")]
        public virtual ICollection<InProducto> InProducto { get; set; }
        
        #endregion
    }
}
