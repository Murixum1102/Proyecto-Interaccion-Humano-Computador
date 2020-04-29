using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ihc.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Contrasena { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string CorreoUsuario { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaCreacion { get; set; }
    }
}
