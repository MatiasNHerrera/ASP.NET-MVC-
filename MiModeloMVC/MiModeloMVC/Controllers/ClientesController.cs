using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiModeloMVC.Models;

namespace MiModeloMVC.Controllers
{
    public class ClientesController : Controller
    {
        public static List<Clientes> lstClientes = new List<Clientes> {

            new Clientes
                {
                    id = 1,
                    nombre = "Matias",
                    fechaAlta = DateTime.Now,
                    edad = 20
                },

                new Clientes
                {
                    id = 2,
                    nombre = "Joselito",
                    fechaAlta = DateTime.Now,
                    edad = 43
                }

        };

        
        // GET: Clientes
        public ActionResult Index()
        {
            var Clientes = from e in lstClientes
                           orderby e.id
                           select e;

            return View(Clientes.ToList());
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(Clientes emp)
        {
            try
            {
                lstClientes.Add(emp);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            List<Clientes> lista = lstClientes;

            var Cliente = lstClientes.Single(model => model.id == id);

            return View(Cliente);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var clientes = lstClientes.Single(model => model.id == id);
                if(TryUpdateModel(clientes))
                {
                    return RedirectToAction("Index", "Clientes");
                }

                return View(clientes);

            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [NonAction]
        public List<Clientes> TodosLosClientes()
        {

            /*UNA DE LAS FORMAS DE CREAR LA LISTA 
             * var lstClientes = new List<Clientes>();

            var cliente1 = new Clientes(1, "Matias", DateTime.Now, 20);
            var cliente2 = new Clientes(2, "Joselito", DateTime.Now, 45);

            lstClientes.Add(cliente1);
            lstClientes.Add(cliente2);
            */

            return new List<Clientes>
            {
                new Clientes
                {
                    id = 1,
                    nombre = "Matias",
                    fechaAlta = DateTime.Now,
                    edad = 20
                },

                new Clientes
                {
                    id = 2,
                    nombre = "Joselito",
                    fechaAlta = DateTime.Now,
                    edad = 43
                }
            };
        }
    }
}
