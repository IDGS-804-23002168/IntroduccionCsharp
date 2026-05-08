using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Introduccion_csharp.Models;

namespace Introduccion_csharp.Controllers
{
    public class DistanciaController : Controller
    {
        

        public ActionResult CalcularPuntos(DistanciaPuntos model)
        {
            
            double X = model.X2 - model.X1;
                double Y = model.Y2 - model.Y1;
                model.Resultado = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            
            return View(model);
        }
              

    }
}