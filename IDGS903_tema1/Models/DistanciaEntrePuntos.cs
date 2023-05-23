using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_tema1.Models
{
    public class DistanciaEntrePuntos
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public double Resultado { get; set; }

        public void Calcular()
        {
            this.Resultado = Math.Sqrt(Math.Pow(X2-X1, 2) + Math.Pow(Y2-Y1, 2));
        }
    }
}