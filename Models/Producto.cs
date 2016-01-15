using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PrimerosPasos.Models
{
    public class Producto
    {
        public int ID { get; set; }
        public String Nombre { get; set; }
        public String Descripcion {get;set;}
        public decimal Precio { get; set; }
    }

    public class ProductoDBContext:DbContext
    {
        public DbSet<Producto> Productos { get; set; }
    }
}