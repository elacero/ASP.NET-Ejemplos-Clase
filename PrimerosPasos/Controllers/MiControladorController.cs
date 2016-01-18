using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrimerosPasos.Models;


namespace PrimerosPasos.Controllers
{
    public class MiControladorController : Controller
    {
        private ProductoDBContext contexto = new ProductoDBContext();

        // GET: MiControlador
        public ActionResult Index()
        {
            ViewData["productos"] = contexto.Productos;
            return View();
        }

        [HttpGet]
        public ActionResult Crear()
        {
            // Necesario si no utilizo la sobrecarga de la acción Crear con notación HttpPost
            //if(Request.RequestType=="POST")
            //{
            //    Producto nuevo = new Producto()
            //    {
            //        Nombre = Request["nombre"],
            //        Descripcion = Request["descripcion"],
            //        Precio = decimal.Parse(Request["precio"]),
            //    };
            //    contexto.Productos.Add(nuevo);
            //    contexto.SaveChanges();
            //}
           
            return View();
        }

        [HttpPost]
        public ActionResult Crear(FormCollection form)
        {
            Producto nuevo = new Producto()
            {
                Nombre = form["nombre"],
                Descripcion = form["descripcion"],
                Precio = decimal.Parse(form["precio"]),
            };
            contexto.Productos.Add(nuevo);
            contexto.SaveChanges();
            return View();
        }
    }
}