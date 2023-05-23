using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_tema1.Models
{
    public class Alumnos
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool Activo { get; set; }
        public DateTime Inscrito { get; set; }

    }
}