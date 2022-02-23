using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventariosAPI.Models
{
    public partial class InMovimientos
    {
        #region Coleccion de Campos
        [Display(Name = "Id del Movimiento", Description = "Identificador único del Movimiento")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public int InMovimientoId { get; set; }

        [Display(Name = "Fecha Registro", Description = "Fecha de Registro del Movimiento")]
        public DateTime InMovimientoRegistro { get; set; }

        [Display(Name = "Almacén", Description = "Almacén del Movimiento")]
        [Required]
        public short AlmacenId { get; set; }

        [Display(Name = "Producto", Description = "Identificador único del Producto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(25, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InProductoId { get; set; }

        [Display(Name = "Lote", Description = "Aplica Lote ?")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InMovimientoLote { get; set; }

        [Display(Name = "Calibre", Description = "Aplica Calibre ?")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(10, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InMovimientoCalibre { get; set; }

        [Display(Name = "Color", Description = "Aplica Color ?")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(25, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InMovimientoColor { get; set; }

        [Display(Name = "Talla", Description = "Aplica Talla ?")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(10, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InMovimientoTalla { get; set; }

        [Display(Name = "Documento", Description = "Documento")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public int InMovimientoDoc { get; set; }

        [Display(Name = "Fecha Registro Documento", Description = "Fecha de Registro en Documento del Movimiento")]
        public DateTime InMovimientoFecDoc { get; set; }

        [Display(Name = "Cantidad", Description = "Cantidad Del Producto")]
        public decimal InMovimientoCantidad { get; set; }

        [Display(Name = "Observaciones", Description = "Observaciones del Movimiento")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(255, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InMovimientoObs { get; set; }

        [Display(Name = "Tipo de Movimiento", Description = "Tipo de Movimiento")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(1, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InMovimientoTipo { get; set; }

        [Display(Name = "Origen del Movimiento", Description = "Origen del Movimiento")]
        public int OrigenMovId { get; set; }
        #endregion

        #region Entidades relacionadas
        [Display(Name = "Almacen", Description = "Almacén relacionado")]
        public virtual Almacenes Almacen { get; set; }
        [Display(Name = "Producto", Description = "Producto Relacionado")]
        public virtual InProducto InProducto { get; set; }
        [Display(Name = "Origen de Movimiento", Description = "Origen del Movimiento relacionado")]
        public virtual Origenmov OrigenMov { get; set; }
        #endregion
    }
}
