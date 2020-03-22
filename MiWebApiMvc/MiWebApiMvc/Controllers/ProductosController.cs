using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MiWebApiMvc.Models;

namespace MiWebApiMvc.Controllers
{
    public class ProductosController : ApiController
    {
        Productos[] productos = new Productos[]
        {
            new Productos { ID = 1, nombre="manzana", categoria="Categoria 1", precio= 3},
            new Productos { ID = 2, nombre="banana", categoria="Categoria 2", precio= 3},
            new Productos { ID = 3, nombre="pera", categoria="Categoria 3", precio= 3}
        };

        public IHttpActionResult GetListaProductos()
        {
            return Json(productos);
        }

        public IHttpActionResult GetProducto(int id)
        {
            Productos pr = productos.Single(m => m.ID == id);

            if(!pr.Equals(null))
            {
                return Json(pr);
            }

            return NotFound();
        }
    }
}
