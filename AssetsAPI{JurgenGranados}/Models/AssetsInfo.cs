using System;
using System.Collections.Generic;

namespace AssetsAPI_JurgenGranados__.Models
{
    public partial class AssetsInfo
    {
        public int Idactivo { get; set; }
        public string NombreActivo { get; set; } = null!;
        public string? NumeroSerie { get; set; }
        public decimal CostoActivo { get; set; }
        public string? Descripcion { get; set; }
        public string Ubicacion { get; set; } = null!;
        public string Responsable { get; set; } = null!;
        public decimal PorcentajeDepreciacion { get; set; }
        public int VidaUtilAnnios { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool EstadoActivo { get; set; }
    }
}
