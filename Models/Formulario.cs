using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ihc.Models
{
    public class Formulario
    {
        public int Id { get; set; }
        public string NombreFormulario { get; set; }
        public string CodigoFormulario { get; set; }
        [DataType(DataType.Upload)]
        public Byte[] Archivo { get; set; }
    }
}
