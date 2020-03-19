using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiFiltroMVC.Controllers
{
    public class ProveedoresController : Controller
    {
        // GET: Proveedores
        public string TodosLosProveedores()
        {
            return @"<ul>
                     <li>Carrefour</li>
                     <li>coto</li>
                     <li>Jumbo</li>
                     <li>Dia</li>
                     </ul>";
        }
    }
}