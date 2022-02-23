using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventariosAPI.ModelsFull
{
    public partial class Almacenes
    {
        public Almacenes()
        {
            InInventario = new HashSet<InInventario>();
            InMovimientos = new HashSet<InMovimientos>();
        }

        #region Coleccion de Campos

        [Display(Name = "Id del Almacen", Description = "Identificador único del Almacen")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public short AlmacenId { get; set; }

        [Display(Name = "Nombre del Almacén", Description = "Nombre del Almacén")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string AlmacenNombre { get; set; }

        [Display(Name = "Tag del Almacén", Description = "Tag del Almacén")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(5, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string AlmacenTag { get; set; }

        [Display(Name = "Estatus del Almacén", Description = "Estatus del Almacén")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(1, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string AlmacenEstatus { get; set; }

        [Display(Name = "Negocio", Description = "Identificador único del Negocio")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public short NegocioId { get; set; }

        #endregion


        #region Colecciones asociadas

        [Display(Name = "Inventarios", Description = "Inventarios asociados")]
        public virtual ICollection<InInventario> InInventario { get; set; }

        [Display(Name = "Movimientos", Description = "Movimientos asociados")]
        public virtual ICollection<InMovimientos> InMovimientos { get; set; }

        #endregion


        #region Entidades Relacionadas

        [Display(Name = "Negocio", Description = "Negocio relacionado")]
        public virtual Negocios Negocio { get; set; }

        #endregion

    }
}
