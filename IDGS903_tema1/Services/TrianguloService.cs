using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_tema1.Services
{
    public class TrianguloService
    {
        public double CalcularLado(double x1, double y1, double x2, double y2)
        {
            double lado = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return lado;
        }

        public double CalcularArea(double lado1, double lado2, double lado3, string tipoTriangulo)
        {
            double area = 0;
            switch(tipoTriangulo)
            {
                case "La figura es un triángulo equílatero": area = Math.Pow(lado1, 2) * Math.Sqrt(3) / 4; break;
                case "La figura es un triángulo isosceles": if (lado1 == lado2) {
                        area = lado3 * Math.Sqrt(Math.Pow(lado1, 2) - Math.Pow(lado3, 2) / 4)/2;
                        break;
                    } else
                    {
                        area = lado2 * Math.Sqrt(Math.Pow(lado1, 2) - Math.Pow(lado2, 2) / 4) / 2;
                        break;
                    }
                case "La figura es un triángulo escaleno":
                    double semiPerimetro = (lado1 + lado2 + lado3) / 2;
                    area = Math.Sqrt(semiPerimetro * (semiPerimetro - lado1) * (semiPerimetro - lado2) * (semiPerimetro - lado3)); break;
            }
            return area;
        }

        public string DeterminarTriangulo(double[] lados)
        {
            string tipo = "";
            double lado1 = lados[0];
            double lado2 = lados[1];
            double lado3 = lados[2];
            if (lado1 >= lado2 + lado3 || lado2 >= lado1 + lado3 || lado3 >= lado1 + lado2)
            {
                tipo = "La figura no es un triángulo";
            }
            else
            {
                if (lado1 == lado2 && lado1 == lado3 )
                {
                    tipo = "La figura es un triángulo equílatero";
                }
                else
                {
                    if (lado1 == lado2 || lado1 == lado3)
                    {
                        tipo = "La figura es un triángulo isosceles";
                    }
                    else
                    {
                        tipo = "La figura es un triángulo escaleno";
                    }
                }
            }

            return tipo;
        }
    }
}