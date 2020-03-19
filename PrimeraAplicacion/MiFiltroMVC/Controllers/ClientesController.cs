using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiFiltroMVC.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Buscar(string nombre, string apellido)
        {
            var input = nombre + "-" + apellido;

            return Content(input);
        }

        [HttpGet] //nos permite tener dos funciones con mismo nombre pero diferenciamos por el metodo de solicitud
        public string Buscar()
        {
            return "Selector http GET";
        }
    }
}