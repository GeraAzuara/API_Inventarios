using System;
using System.Collections.Generic;

namespace InventariosAPI.Models
{
    public partial class Flete
    {
        public Flete()
        {
            Adjflete = new HashSet<Adjflete>();
            Parametrosentrada = new HashSet<Parametrosentrada>();
            Traslado = new HashSet<Traslado>();
        }

        public int FleteId { get; set; }
        public DateTime FleteFechaReg { get; set; }
        public DateTime FleteFechaPrg { get; set; }
        public DateTime FleteFechaIni { get; set; }
        public DateTime FleteFechaFin { get; set; }
        public short FolioId { get; set; }
        public string FleteObserva { get; set; }
        public string FleteEstatus { get; set; }
        public short SgUserId { get; set; }
        public short OperadorId { get; set; }
        public short CamionId { get; set; }
        public short CargoParaId { get; set; }
        public decimal FleteCosto { get; set; }

        public virtual Camiones Camion { get; set; }
        public virtual Empresas CargoPara { get; set; }
        public virtual Folios Folio { get; set; }
        public virtual Operadores Operador { get; set; }
        public virtual ICollection<Adjflete> Adjflete { get; set; }
        public virtual ICollection<Parametrosentrada> Parametrosentrada { get; set; }
        public virtual ICollection<Traslado> Traslado { get; set; }
    }
}
