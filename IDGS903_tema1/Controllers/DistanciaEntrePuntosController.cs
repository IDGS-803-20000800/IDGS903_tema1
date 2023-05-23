using IDGS903_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_tema1.Controllers
{
    public class DistanciaEntrePuntosController : Controller
    {
        // GET: DistanciaEntrePuntos
        public ActionResult Distancia()
        {
            
            return View();
        }

        public ActionResult Resultado(DistanciaEntrePuntos dis)
        {
            dis.Calcular();
            ViewBag.Distancia = dis.Resultado;
            return View(dis);
        }
    }
}