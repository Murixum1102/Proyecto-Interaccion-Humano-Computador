using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ihc.Models
{
    public class Noticia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime FechaPublicacion { get; set; }
        public string Autor { get; set; }
        public string Contenido { get; set; }
        public string Imagen { get; set; }
    }
}
