using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_tema1.Models
{
    public class OperasBas
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Res { get; set; }

        public int Operacion { get; set; }

        public void Sumar() { 
            this.Res = this.Num1 + this.Num2;
        }

        public void Restar()
        {
            this.Res = this.Num1 - this.Num2;
        }

        public void Multiplicar()
        {
            this.Res = this.Num1 * this.Num2;
        }

        public void Division()
        {
            this.Res = this.Num1 / this.Num2;
        }

        public void SeleccionarOperacion()
        {
            switch(this.Operacion)
            {
                case 1: Sumar(); break;
                case 2: Restar(); break;
                case 3: Multiplicar(); break;
                case 4: Division(); break;
            }
        }
    }
}