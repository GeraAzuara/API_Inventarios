using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventariosAPI.Models
{
    public partial class InProducto
    {
        public InProducto()
        {
            InInventario = new HashSet<InInventario>();
            InMovimientos = new HashSet<InMovimientos>();
            InKit = new HashSet<InKit>();
            InKitcomponente = new HashSet<InKitcomponente>();
        }

        #region Coleccion de Campos
        [Display(Name = "Id del Producto", Description = "Identificador único del Producto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(25, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InProductoId { get; set; }

        [Display(Name = "Nombre", Description = "Nombre del Producto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InProductoNombre { get; set; }

        [Display(Name = "Serie", Description = "Serie del Producto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InProductoSerie { get; set; }

        [Display(Name = "Etiqueta", Description = "Tag del Producto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(25, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InProductoTag { get; set; }

        [Display(Name = "Descripción", Description = "Descripción del Producto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(255, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InProductoDescripcion { get; set; }

        [Display(Name = "Tipo de Producto", Description = "Identificador único del Tipo de Producto")]
        public int InTipoProductoId { get; set; }

        [Display(Name = "Marca", Description = "Identificador único de la Marca")]
        public int InMarcaId { get; set; }

        [Display(Name = "Subcategoria", Description = "Identificador único de la Subcategoría")]
        public int InSubCategoriaId { get; set; }

        [Display(Name = "Aplica Lote", Description = "Aplica Lote ?")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(1, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InProductoAlote { get; set; }

        [Display(Name = "Aplica Calibre", Description = "Aplica Calibre ?")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(1, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InProductoAcalibre { get; set; }

        [Display(Name = "Aplica Color", Description = "Aplica Color ?")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(1, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InProductoAcolor { get; set; }

        [Display(Name = "Aplica Talla", Description = "Aplica Talla ?")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(1, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InProductoAtalla { get; set; }

        [Display(Name = "Estatus", Description = "Estatus del Producto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(1, ErrorMessage = "El campo {0} debe tener al menos {2} y máximo {1} caracteres.", MinimumLength = 1)]
        public string InProductoEstatus { get; set; }

        [Display(Name = "Unidad de Empaque", Description = "Unidad de Empaque del Producto")]
        public short? UnidadEmpaqueId { get; set; }

        public int? LineaProductoId { get; set; }
        #endregion

        #region Entidades relacionadas
        [Display(Name = "Marca", Description = "Marca relacionada")]
        public virtual InMarca InMarca { get; set; }

        [Display(Name = "Subcategoría", Description = "Subcategoría relacionada")]
        public virtual InSubcategoria InSubCategoria { get; set; }

        [Display(Name = "Tipo de Producto", Description = "Tipo de Producto relacionado")]
        public virtual InTipoproducto InTipoProducto { get; set; }

        public virtual InLineaproducto LineaProducto { get; set; }

        [Display(Name = "Unidad de Empaque", Description = "Unidad de Empaque relacionada")]
        public virtual InUnidadEmpaque UnidadEmpaque { get; set; }
        #endregion

        #region Colecciones asociadas
        [Display(Name = "Inventarios", Description = "Inventarios asociados")]
        public virtual ICollection<InInventario> InInventario { get; set; }

        [Display(Name = "Movimientos", Description = "Movimientos asociados")]
        public virtual ICollection<InMovimientos> InMovimientos { get; set; }


        public virtual ICollection<InKitcomponente> InKitcomponente { get; set; }
        public virtual ICollection<InKit> InKit { get; set; }
        #endregion
    }
}
