using Introduccion_csharp.Models;
using Introduccion_csharp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Primer_Proyecto.Controllers
{
    public class PruebaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        
        public ActionResult Suma()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Suma(string x, string y, string r1)
        {
            int res = 0;
            if (r1 == "Suma")
            {
                res = Convert.ToInt16(x) + Convert.ToInt16(y);
            }
            else if (r1 == "Resta")
            {
                res = Convert.ToInt16(x) - Convert.ToInt16(y);
            }    
                ViewBag.Res = Convert.ToString(res);
        

            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "APLICACION PRUEBA.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "CONTROLADOR DE PRUEBA.";

            return View();
        }

        public ActionResult MuestraPeliculas()
        {
            var PeliculasService = new PeliculasServices();
            var model = PeliculasService.ObtenerPelicula();
            return View(model);
        }

        public ActionResult Calculos(OperasBas op)
        {
            op.Suma();
            
            return View(op);
        }

    }
}