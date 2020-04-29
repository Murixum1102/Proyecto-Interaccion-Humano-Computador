using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ihc.Models
{
    public class Contacto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Relacion { get; set; }
        public string Entidad { get; set; }
        public string Area { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Descripcion { get; set; }
    }
}
