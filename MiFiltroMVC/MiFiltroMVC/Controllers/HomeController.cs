using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiFiltroMVC.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize]
        // GET: Home
        public string Index()
        {
            return "mi controlador  home";
        }

        //[Authorize (Roles = "Administrador")] Nos ayuda a validar quienes tienen permiso a aquella funcion
        //[OutputCache (Duration = 10)] la cantidad de tiempo que queda guardada esa funcion en cache
        [ActionName ("Hora")] //permite cambiar el nombre de action
        public string HoraActual()
        {
            return CadenaHora();
        }

        [NonAction]
        public string CadenaHora()
        {
            return "Son las: " + DateTime.Now.ToString("T");
        }

    }
}