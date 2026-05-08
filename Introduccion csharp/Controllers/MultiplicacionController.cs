using Introduccion_csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introduccion_csharp.Controllers
{
    public class MultiplicacionController : Controller
    {
        
        public ActionResult Multiplicacion(Multiplicacion model)
        {
            int resultado = 0;

            string operacion = "";

            for (int i = 0; i < model.B; i++)
            {
                resultado += model.A;

                operacion += model.A;

                if (i < model.B - 1)
                {
                    operacion += "+";
                }
            }

            operacion += " = " + resultado;

            model.Resultado = resultado;
            model.Operacion = operacion;

            return View(model);
        }
    }
}