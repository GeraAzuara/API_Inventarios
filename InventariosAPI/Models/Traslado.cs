using System;
using System.Collections.Generic;

namespace InventariosAPI.Models
{
    public partial class Traslado
    {
        public Traslado()
        {
            Adjtraslado = new HashSet<Adjtraslado>();
        }

        public int TrasladoId { get; set; }
        public short TipoTrasladoId { get; set; }
        public DateTime TrasladoFechaEnv { get; set; }
        public decimal TrasladoCanEnv { get; set; }
        public DateTime TrasladoFechaRec { get; set; }
        public decimal TrasladoCanRec { get; set; }
        public string TrasladoObjetoId { get; set; }
        public string TrasladoObservacion { get; set; }
        public short DestinoId { get; set; }
        public short OrigenId { get; set; }
        public int? FleteId { get; set; }
        public string TrasladoDisRec { get; set; }
        public string TrasladoDisEnv { get; set; }
        public string TrasladoGeorec { get; set; }
        public short TrasladoUserRec { get; set; }
        public string TrasladoGeoenv { get; set; }
        public short TrasladoUserEnv { get; set; }

        public virtual Ubicacion Destino { get; set; }
        public virtual Flete Flete { get; set; }
        public virtual Ubicacion Origen { get; set; }
        public virtual Tipotraslado TipoTraslado { get; set; }
        public virtual ICollection<Adjtraslado> Adjtraslado { get; set; }
    }
}
