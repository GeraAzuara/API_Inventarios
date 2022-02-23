using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace InventariosAPI.ModelsFull
{
    public partial class CoProductosPrv
    {
        public int PrdPrvId { get; set; }
        public short ProveedorId { get; set; }
        public string InProductoId { get; set; }

        public virtual InProducto InProducto { get; set; }
        public virtual CoProveedores Proveedor { get; set; }

        public CoProductosPrv()
        {
          

        }
        public CoProductosPrv(short ProveedorActual, string ProductoPorIncorporar)
        {
            ProveedorId = ProveedorActual;
            InProductoId = ProductoPorIncorporar;
           
        }
    }
}
