using IDGS903_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_tema1.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        public ActionResult Ventana()
        {
            return View();
        }

        public ActionResult Calculos(string n1, string n2)
        {
            int res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
            ViewBag.Res = Convert.ToString(res);
            return View();
        }

        public ActionResult Ventana2(OperasBas op)
        {
            op.SeleccionarOperacion();
            var model = new OperasBas();
            model.Res = op.Res;
            return View(model);
        }
    }
}