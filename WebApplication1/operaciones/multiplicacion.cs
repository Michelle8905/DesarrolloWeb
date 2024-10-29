using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.operaciones
{
    public class multiplicacion
    {
        private int a;
        private int b;

        public multiplicacion(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int getMultiplicacion()
        {
            return a * b;
        }
    }
}