using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiWebApiMvc.Models
{
    public class Productos
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public float precio { get; set; }


    }
}