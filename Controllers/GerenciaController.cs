using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ihc.Controllers
{
    public class GerenciaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CamaraCompensacion()
        {
            return View();
        }
        public IActionResult ArchivoDigitalizacion()
        {
            return View();
        }
        public IActionResult ConsultaEmbargos()
        {
            return View();
        }
        public IActionResult OutsourcingRecursoHumano()
        {
            return View();
        }
        public IActionResult ServicioMensajeria()
        {
            return View();
        }
        public IActionResult ServiciosTerceroProcesos()
        {
            return View();
        }
    }
}