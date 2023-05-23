using IDGS903_tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Util;

namespace IDGS903_tema1.Services
{
    public class DiccionarioService
    {
        public void GuardarTraduccion(Diccionario dic)
        {
            var ing = dic.Ingles;
            var esp = dic.Espanol;
            var datos = ing.ToLower() + ":" + esp.ToLower() + Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");
            File.AppendAllText(archivo, datos);
        }

        public Array LeerTraduccion()
        {
            Array dicData = null;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");
            if (File.Exists(archivo))
            {
                dicData = File.ReadAllLines(archivo);
            }
            return dicData;
        }

        public string BuscarTraduccion(string palabra, bool idioma)
        {
            palabra = palabra.ToLower();
            Dictionary<string, string> traducciones = new Dictionary<string, string>();
            List<string> datos = new List<string>();
            string traduccion = "";
            Array dicData = null;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");
            if (File.Exists(archivo))
            {
                dicData = File.ReadAllLines(archivo);
            }
                
            foreach (string item in dicData)
            {
                foreach(string dato in item.Split(':')) 
                {
                    datos.Add(dato);
                }
            }

            for (int i = 0; i < datos.Count - 1; i += 2)
            {
                string ingles = datos[i];
                string espanol = datos[i + 1];
                traducciones[ingles] = espanol;
            }

            if (idioma == true)
            {
                if (traducciones.ContainsKey(palabra))
                {
                    traduccion = "La traducción de \"" + palabra + "\" es: " + traducciones[palabra];
                }
                else
                {
                    traduccion = "Traducción no encontrada";
                }
            }
            else
            {
                var traduccionesEspanol = traducciones.ToDictionary(x => x.Value, x => x.Key);
                if (traduccionesEspanol.ContainsKey(palabra))
                {
                    traduccion = "La traducción de \"" + palabra + "\" es: " + traduccionesEspanol[palabra];
                }
                else
                {
                    traduccion = "Traducción no encontrada";
                }
            }
            return traduccion;
        }
    }
}