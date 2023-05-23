using IDGS903_tema1.Models;
using IDGS903_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_tema1.Controllers
{
    public class DiccionarioController : Controller
    {
        // GET: Diccionario
        public ActionResult AgregarPalabra()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AgregarPalabra(Diccionario dic)
        {
            var op = new DiccionarioService();
            op.GuardarTraduccion(dic);
            return View();
        }

        public ActionResult LeerDiccionario()
        {
            var dic = new DiccionarioService();
            ViewBag.Diccionario = dic.LeerTraduccion();

            return View();
        }
        [HttpPost]
        public ActionResult LeerDiccionario(Diccionario dic)
        {
            var op = new DiccionarioService();
            op.GuardarTraduccion(dic);
            return View();
        }

        public ActionResult Traductor()
        { 
            return View(); 
        }
        [HttpPost]
        public ActionResult Traductor(string palabra, bool idioma)
        {
            var op = new DiccionarioService();
            ViewBag.Traduccion = op.BuscarTraduccion(palabra, idioma);
            return View();
        }
    }
}