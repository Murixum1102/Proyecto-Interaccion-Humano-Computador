using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ihc.Models
{
    public class Sala
    {
        public int Id { get; set; }
        public string NombreSala { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime FechaHoraInicio { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime FechaHoraFin { get; set; }
        public string NombreSolicitante { get; set; }
        public string IdSolicitante { get; set; }
    }
}
