using IDGS903_tema1.Models;
using IDGS903_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_tema1.Controllers
{
    public class TrianguloController : Controller
    {
        // GET: Triangulo
        public ActionResult DeterminarTriangulo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeterminarTriangulo(Triangulo tri)
        {
            TrianguloService triSer = new TrianguloService();
            double[] lados = new double[3];
            double lado1 = Math.Round(triSer.CalcularLado(tri.X1, tri.Y1, tri.X2, tri.Y2));
            double lado2 = Math.Round(triSer.CalcularLado(tri.X2, tri.Y2, tri.X3, tri.Y3));
            double lado3 = Math.Round(triSer.CalcularLado(tri.X1, tri.Y1, tri.X3, tri.Y3));
            lados[0] = lado1;
            lados[1] = lado2;
            lados[2] = lado3;
            ViewBag.TipoTriangulo = triSer.DeterminarTriangulo(lados);
            if (ViewBag.TipoTriangulo != "La figura no es un triángulo") 
            {
                ViewBag.Area = "El área del triángulo es: " + triSer.CalcularArea(lado1, lado2, lado3, ViewBag.TipoTriangulo);
            }
            return View();
        }
    }
}