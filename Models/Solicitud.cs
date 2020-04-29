using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ihc.Models
{
    public class Solicitud
    {
        public int Id { get; set; }
        public int IdSolicitante { get; set; }
        public string NombreSolicitante { get; set; }
        public string TipoSolicitud { get; set; }
        public string Descripcion { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaCreacion { get; set; }
    }
}
