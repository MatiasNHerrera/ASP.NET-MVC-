using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiModeloMVC.Models
{
    public class Clientes
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public DateTime fechaAlta { get; set; }
        public int edad { get; set; }

        /*SE PUEDE CREAR LA LISTA A TRAVES DE ATRIBUTOS TAMBIEN
         * public Clientes(int _id, string _nombre, DateTime _fechaAlta, int _edad)
        {
            this.id = _id;
            this.nombre = _nombre;
            this.fechaAlta = _fechaAlta;
            this.edad = _edad;
        }*/

    }
}