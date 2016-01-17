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

        public ActionResult Crear()
        {
           
            return View();
        }
    }
}