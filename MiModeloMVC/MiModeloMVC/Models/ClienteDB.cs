using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MiModeloMVC.Models;
using System.Data.Entity;
using System.Data.Common;

namespace MiModeloMVC.Models
{
    public class ClienteDB : DbContext
    {
        public ClienteDB()
        {

        }

        public DbSet<Clientes> Clientes { get; set; }
    }
}