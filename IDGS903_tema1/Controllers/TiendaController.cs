using IDGS903_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDGS903_tema1.Models;

namespace IDGS903_tema1.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda
        public ActionResult MuestraPulques()
        {
            var pulquesVenta = new PulquesServices();
            var model = pulquesVenta.ObtenerPulque();
            return View(model);
        }

        public ActionResult MuestraPulques2()
        {
            TempData["nombres"] = "Mario Lopez";
            var pulquesVenta = new PulquesServices();
            var model = pulquesVenta.ObtenerPulque();
            return View(model);
        }

        public ActionResult Index()
        {
           var pulque1 = new Pulques() {
                Nombre = "Pulque2",
                Descripcion = "Mango Piña",
                Litros = 23,
                Caducidad = new DateTime(2023, 11, 3)
            };

            ViewBag.pulques = pulque1;

            // return Json(pulque1, JsonRequestBehavior(all));
            // return Content("Alejandro Salazar, ASP.NET");
            return View();
        }

        public ActionResult Vista()
        {
            var pulque1 = new Pulques()
            {
                Nombre = "Pulque2",
                Descripcion = "Mango Piña",
                Litros = 23,
                Caducidad = new DateTime(2023, 11, 3)
            };

            ViewBag.pulques = pulque1;
            return View();
        }

        public ActionResult Vista2()
        {
            ViewBag.saludo = "Hola mundo";
            ViewBag.fecha = new DateTime(2023, 11, 2);
            ViewData["Nombre"] = "Ricardo";

            string nombre;
            if (TempData.ContainsKey("nombre"))
            {

            }

            return View();
        }
    }
}