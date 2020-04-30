using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ihc.Models
{
    public class SolicitudVacaciones
    {
        public int Id { get; set; }
        public string NombreSolicitante { get; set; }
        public string ApellidoSolicitante { get; set; }

        public Empleado Empleado { get; set; }
        public int NumeroEmpleado { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaFin { get; set; }
    }
}
