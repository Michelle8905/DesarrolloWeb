using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.operaciones
{
    public class dividir
    {
        private int a;
        private int b;

        public dividir(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public string getDivision()
        {
            if(b == 0)
            {
                return "No se puede dividir por cero";
            }
            return "La división es: " + (a / b);
        }
    }
}