using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventariosAPI.ModelsFull
{
    public partial class InInventario
    {
        #region Coleccion de Campos

        [Display(Name = "Inventario", Description = "Identificador único del Inventario")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public int InInventarioId { get; set; }

        [Display(Name = "Almacen", Description = "Identificador único del Almacen")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public short AlmacenId { get; set; }

        [Display(Name = "Producto", Description = "Identificador único del Producto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public string InProductoId { get; set; }

        [Display(Name = "Lote", Description = "Lote")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public string InProductoLote { get; set; }

        [Display(Name = "Calibre", Description = "Calibre")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public string InProductoCalibre { get; set; }

        [Display(Name = "Color", Description = "Color")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public string InProductoColor { get; set; }

        [Display(Name = "Talla", Description = "Talla")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public string InProductoTalla { get; set; }

        [Display(Name = "Fecha Inv. Inicial", Description = "Fecha Inicial del Inventario")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime InInicial { get; set; }

        [Display(Name = "Lógico", Description = "Inventario Lógico")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [Range(typeof(decimal), "0", "1000000000000000000", ErrorMessage = "{0} debe ser un número decimal entre {1} y {2}.")]
        public decimal InLogico { get; set; }

        [Display(Name = "Físico", Description = "Inventario Físico")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [Range(typeof(decimal), "0", "1000000000000000000", ErrorMessage = "{0} debe ser un número decimal entre {1} y {2}.")]
        public decimal InFisico { get; set; }

        [Display(Name = "Unicación", Description = "Ubicación del Inventario")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        public short UbicacionId { get; set; }

        #endregion

        #region Entidades asociadas

        [Display(Name = "Almacen", Description = "Almacen relacionado")]
        public virtual Almacenes Almacen { get; set; }

        [Display(Name = "Producto", Description = "Producto relacionado")]
        public virtual InProducto InProducto { get; set; }

        [Display(Name = "Ubicación", Description = "Ubicación relacionada")]
        public virtual Ubicacion Ubicacion { get; set; }

        #endregion

    }
}
