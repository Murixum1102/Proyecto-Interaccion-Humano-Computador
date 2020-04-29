using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ihc.Controllers
{
    public class AdministrativoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Proveedores()
        {
            return View();
        }

        public IActionResult SolicitudProveeduria()
        {
            return View();
        }

        public IActionResult BoletaVacaciones()
        {
            return View();
        }

        public IActionResult FormulariosOficiales()
        {
            return View();
        }
    }
}