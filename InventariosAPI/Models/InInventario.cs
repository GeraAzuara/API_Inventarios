using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace InventariosAPI.Models
{
    public partial class InInventario
    {
        public int InInventarioId { get; set; }
        public short AlmacenId { get; set; }
        public string InProductoId { get; set; }
        public string InProductoLote { get; set; }
        public string InProductoCalibre { get; set; }
        public string InProductoColor { get; set; }
        public string InProductoTalla { get; set; }
        public DateTime InInicial { get; set; }
        public decimal InLogico { get; set; }
        public decimal InFisico { get; set; }
        public short UbicacionId { get; set; }

        public virtual Almacenes Almacen { get; set; }
        public virtual InProducto InProducto { get; set; }
        public virtual Ubicacion Ubicacion { get; set; }
    }
}
